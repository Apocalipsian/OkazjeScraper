﻿/*
 * ----------------------------------------------------------------------------
 * "THE BEER-WARE LICENSE" (Revision 42):
 * <phk@FreeBSD.ORG> wrote this file. As long as you retain this notice you
 * can do whatever you want with this stuff. If we meet some day, and you think
 * this stuff is worth it, you can buy me a beer.  
 * ----------------------------------------------------------------------------
 */

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCountProject
{
    public partial class Form1 : Form
    {

        static IWebDriver driver;
        static string tittle = "";
        static List<string> lista = new List<string>();
        static StringBuilder csvWrite = new StringBuilder();
        static public List<string> productIdList = new List<string>();
        public static List<string> listBox = new List<string>();
        public List<List<string>> oneList = new List<List<string>>();

        public List<string> getDuplicateProduct(List<string> listProductId)
        {
            listProductId = driver.FindElements(By.XPath(
                   @"//div[@id='listingPage']//div[contains(@class,'rightCol')]/div[contains(@class,'squaresListing')]
                    /div[contains(@class, 'squaresContent narrow')]/div[contains(@class, 'productItem')]//a[contains(@class,'productItemContent')]")).Select(w => w.GetAttribute("data_product_id")).ToList();

            var duplicate = listProductId.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            return duplicate;
        }

        public static List<string> checkShop(List<string> lista, string url)
        {
            lista = new List<string>();
            if (driver == null)
                driver = new PhantomJSDriver();
            driver.Url = url;


            //string cookieName = driver.Manage().Cookies.GetCookieNamed("OIATM").Value.ToString();
            //Cookie cookie = new Cookie("OIATM", "8af3%3A1%3A1");
            //Cookie cookie2 = new Cookie("OIATM", "8af3%3A2%3A1");

            //driver.Manage().Cookies.DeleteCookieNamed("OIATM");
            //driver.Manage().Cookies.AddCookie(cookie);

            //driver.Url = url;

            //driver.Manage().Cookies.DeleteCookieNamed("OIATM");
            //driver.Manage().Cookies.AddCookie(cookie2);

            driver.Url = url;

            tittle = driver.Title;
            if (url.Contains("okazje.info.pl") == false)
            {
                tittle += " - trunk";
            }
            tittle = tittle.Replace("najlepsze ceny", DateTime.Now.ToString("HH_mm_ss"));


            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
            var la = driver.FindElements(By.XPath(
                @"//div[@id='listingPage']//div[contains(@class,'rightCol')]/div[contains(@class,'squaresListing')]
                     /div[contains(@class,'squaresContent narrow')]/div[contains(@class,'productItem')]//a[contains(@class,'productItemContent')]
                     /div[contains(@class, 'productPricesFieldArea')]/div[contains(@class, 'productShopName') or contains (@class,'orangeTex productOffersCount') ]"));


            foreach (var item in la)
            {
                lista.Add(item.Text);
            }


            sortList(lista, 1);
            if (Directory.Exists(@".\" + DateTime.Today.ToString("dd_MM_yyyy")) == false)
                Directory.CreateDirectory(@".\" + DateTime.Today.ToString("dd_MM_yyyy"));

            File.WriteAllText(@".\" + @".\" + DateTime.Today.ToString("dd_MM_yyyy") + @"\" + tittle + ".cvs", csvWrite.ToString());
            csvWrite.Clear();

            return lista;

        }


        public static List<string> checkShop(List<string> listaAll, string url, int countWeb)
        {
            if (listaAll == null)
                listaAll = new List<string>();

            List<string> lista = new List<string>();

            if (driver == null)
                driver = new PhantomJSDriver();

            driver.Url = url;
            tittle = driver.Title;
            if (url.Contains("okazje.info.pl") == false)
            {
                tittle += " - trunk";
            }
            tittle = tittle.Replace("najlepsze ceny", DateTime.Now.ToString("HH_mm_ss"));

            var count = driver.FindElements(By.XPath("//div[@id='listingPageArea']/div[@id='listingPage']/div[@class='rightCol overflowH']/div[@class='yu']/div/div[@class='wholePages']/a"));

            if (count.Count >= 5)
                countWeb = 5;
            else
                countWeb = count.Count + 1;

            for (int i = 1; i <= countWeb; i++)
            {
                driver.Url = url + i + ".html";
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
                var la = driver.FindElements(By.XPath(
                    @"//div[@id='listingPage']//div[contains(@class,'rightCol')]/div[contains(@class,'squaresListing')]
                     /div[contains(@class,'squaresContent narrow')]/div[contains(@class,'productItem')]//a[contains(@class,'productItemContent')]
                     /div[contains(@class, 'productPricesFieldArea')]/div[contains(@class, 'productShopName') or contains (@class,'orangeTex productOffersCount') ]"));


                var productID = driver.FindElements(By.XPath(
                   @"//div[@id='listingPage']//div[contains(@class,'rightCol')]/div[contains(@class,'squaresListing')]
                    /div[contains(@class, 'squaresContent narrow')]/div[contains(@class, 'productItem')]//a[contains(@class,'productItemContent')]")).Select(w => w.GetAttribute("data_product_id"));


                foreach (var item in la)
                {
                    lista.Add(item.Text);
                    listaAll.Add(item.Text);
                }

                foreach (var item in productID)
                {
                    productIdList.Add(item);
                }

  
                    sortList(lista, 1);


                lista = new List<string>();

            }

            // teset
            sortList(listaAll, 0);


            //        var topCategory_id = driver.FindElements(By.XPath(
            //           @"//div[@id='listingPage']//div[contains(@class,'rightCol')]/div[contains(@class,'squaresListing')]
            //                / div[contains(@class, 'squaresContent narrow')]/div[contains(@class, 'productItem')]//a[contains(@class,'productItemContent')]")).Select(w => w.GetAttribute("data_topcategory_id"));

            //        var category_id = driver.FindElements(By.XPath(
            //          @"//*[@id='categoryId']")).Select(w => w.GetAttribute("value"));

            //        string solrUrl = "http://biuro:9983/solr/collection1/select?qt=standard&q=*:*&fq=topcategory_id:"+topCategory_id.FirstOrDefault().ToString()+"&fq=+categories:"+category_id.FirstOrDefault().ToString()+"&fq=+status:1&fl=id,topcategory_id&facet=true&facet.field=price_range&facet.mincount=5&facet.limit=-1&facet.sort=true&facet.field=p_1&facet.mincount=5&facet.limit=90&facet.sort=true&facet.field=p_237&facet.mincount=5&facet.limit=90&facet.sort=true&facet.field=p_238&facet.mincount=5&facet.limit=-1&facet.sort=true&sort=pretty_sort%20desc,%20price%20asc&json.nl=map&start=240&rows=480000&indent=1";


            //        driver.Url = solrUrl;

            //        var allProduct = driver.FindElements(By.XPath("response/result/doc/int[@name='id']")).Select(w => w.Text).ToList();


            //     //   var duplicateProduct = productIdList.Where(b => allProduct.Any(a => b.Contains(a)));

            //  //var tmp = productIdList.Where(b => allProduct.Any(a => b.Contains(a)))
            //  //                   .Select(x => new { x, index = allProduct.IndexOf(x) });




            //        var result = allProduct.Select((x, y) => new { element = x, index = y })  
            //.Where(z => productIdList.Contains(z.element));


            //        var tmp = result.Count();
            //// na plikach
            if (Directory.Exists(@".\" + DateTime.Today.ToString("dd_MM_yyyy")) == false)
                Directory.CreateDirectory(@".\" + DateTime.Today.ToString("dd_MM_yyyy"));

            File.WriteAllText(@".\" + @".\" + DateTime.Today.ToString("dd_MM_yyyy") + @"\" + tittle + ".cvs", csvWrite.ToString());
            csvWrite.Clear();
            return lista;

        }

        public static void sortList(List<string> lista, int lastPage)
        {
            // csvWrite.Clear();

            //  csvWrite.AppendLine(driver.Url);

            string tmp = "";

            var numberMulti = from c in lista
                              where c.Contains("ofert")

                              select new { c };

            int countTmp = numberMulti.Count();

            lista.RemoveAll(u => u.Contains("ofert"));


            var q = from x in lista

                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Count = count };



            foreach (var x in q)
            {
                if (lastPage == 0)
                {
                    var newLine = string.Format("TOTAL;{0};{1};", x.Value, x.Count);
                    csvWrite.AppendLine(newLine);
                    tmp = "TOTAL";
                }
                else
                {
                    var newLine = string.Format("{0};{1};{2};", driver.Url, x.Value, x.Count);
                    csvWrite.AppendLine(newLine);
                    tmp = driver.Url;
                }
            }



            var newLine2 = string.Format("{0};Produkty wielofertowe;{1}", tmp, countTmp);
            csvWrite.AppendLine(newLine2);


            var newLine3 = string.Format("{0};Ilość produktów; {1}", tmp, (lista.Count + countTmp));
            csvWrite.AppendLine(newLine3);


            var newLine4 = string.Format("{0};Ilość sklepów; {1}", tmp, (q.Count()));
            csvWrite.AppendLine(newLine4);


            csvWrite.AppendLine(Environment.NewLine);

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Listing 
            if (checkListing.Enabled)
            {
                if (richTextBox1.Lines.Length > 0)
                {
                    listBox.AddRange((string[])richTextBox1.Lines);

                    if (simpleSite.Checked)
                    {
                        foreach (var url in listBox)
                        {
                            lista = checkShop(lista, url);
                            lista = new List<string>();

                            if (compareTrunk.Checked)
                            {
                                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));

                                lista = checkShop(lista, url.Replace("www.okazje.info.pl", trunkUrl.Text));
                                lista = new List<string>();
                            }
                        }
                        driver.Quit();
                        driver = null;
                        listBox = new List<string>();
                    }

                    if (radioButton2.Checked)
                    {
                        foreach (var url in listBox)
                        {
                            lista = checkShop(lista, url, 5);
                            lista = new List<string>();


                            if (compareTrunk.Checked)
                            {
                                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(120));

                                lista = checkShop(lista, url.Replace("www.okazje.info.pl", trunkUrl.Text), 5);
                                lista = new List<string>();
                            }

                        }
                        driver.Quit();
                        driver = null;
                        listBox = new List<string>();
                    }
                }
                else
                    MessageBox.Show("Podaj prawidłowe urle");

            }
            #endregion

            #region LF

            if (checkLf.Enabled)
            {
                foreach (var url in listBox)
                {
                    if (driver == null)
                        driver = new PhantomJSDriver();

                    driver.Url = url;
                    List<string> duplicate = new List<string>();
                    duplicate = getDuplicateProduct(duplicate);

                    richTextBox2.Text += "Ilosc duplikatów : " + duplicate.Count();


                }
                listBox = new List<string>();
                //driver.Quit();
            }

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Zapisz urle";
            saveFileDialog1.ShowDialog();

            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text|*.txt";
            openFile.Title = "Otwórz urle";
            openFile.ShowDialog();

            richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
