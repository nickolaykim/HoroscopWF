using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace HoroscopWF
{
    public partial class FormProphecy : Form
    {

        MyDbContext context = new MyDbContext();
        
        public static StringBuilder sb = new StringBuilder();

        string[] signsRus = { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };
        string[] signsEng = { "aries", "taurus", "gemini", "cancer", "leo", "virgo", "libra", "scorpio", "sagittarius", "capricorn", "aquarius", "pisces" };

        public static byte[] buf = new byte[8192];
        public static string uri = "";
        public static string url = "";
        public static int count = 0;
        public static string zodiak = "♈ ♉ ♊ ♋ ♌ ♍ ♎ ♏ ♐ ♑ ♒ ♓" + Environment.NewLine + Environment.NewLine;

        public FormProphecy(int Id)
        {
            InitializeComponent();
            this.textBox1.ForeColor = System.Drawing.Color.Goldenrod;
            List<Player> playersList = context.Players.ToList();
            Player currentPlayer = new Player();
            foreach (var a in playersList)
            {
                if (a.Id == Id)
                    currentPlayer = a;
            }
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].Id == Id)
                {
                    for (int j = 0; j < signsRus.Length; j++)
                    {
                        if (signsRus[j] == playersList[i].Sign)
                        {
                            uri = "https://horo.mail.ru/prediction/" + signsEng[j] + "/today/"; //Находим нужный uri по id пользователя и присваем нужное строковое значение
                        }
                    }
                }
            }
            url = getResponse(uri); // отправляем запрос на сервер и получаем ответ в виде адреса на нужную страницу
          
            // Используем HtmlAgilityPack и получаем абстрактную вебстраницу в виде объекта класса HtmlDocument
            HtmlDocument HD = new HtmlDocument();
            HD.LoadHtml(url); //Используя полученный url, через метод LoadHtml получаем реальную страницу находящуюся по указанному адресу
            //Находим на сайте нужный контейнер div, копируем его селектор и через метод SelectNodes получаем строковое содержимое указанного контейнера
            var strs = HD.DocumentNode.SelectNodes("//div[@class='article__item article__item_alignment_left article__item_html']/p"); //указываем, что нас интересуют именно параграфы <p> 
            textBox1.Text = "\n\n"
                +currentPlayer.Login + " !!!" + Environment.NewLine
                + "Сегодня " + DateTime.Today.ToString("dd MMMM") + Environment.NewLine
                + " И в этот день, звезды тебе открывают следующее: " + Environment.NewLine + Environment.NewLine
                + zodiak;
            foreach (HtmlNode node in strs)
            {
                textBox1.Text += node.InnerText.Trim() + Environment.NewLine + Environment.NewLine;
            }
            textBox1.Text += zodiak;
        }
        public static string getResponse(string uri)// Метод отправляет запрос на сервер, получает ответ в виде адреса вебстраницы и возвращает в виде строкового значения
        {
            sb.Clear();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();

            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.UTF8.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
          
            FormEndCredits endCreditsForm = new FormEndCredits();
            endCreditsForm.Show();

        }
    }
}