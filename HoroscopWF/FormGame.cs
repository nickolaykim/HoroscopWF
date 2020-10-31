using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Windows.Media;
using HoroscopWF.Pages;

namespace HoroscopWF
{
    public partial class FormGame : Form
    {
        MyDbContext context = new MyDbContext(); // Создаем связь с базой данных
        //Создаем коллекцию иконок
        List<PictureBox> pbGameField;
        Sound sound = new Sound(); // создаем экземпляр класса Sound
        int playerId = -1;
        int mainCounter = 0;//счетчик угаданных пар иконок(максимум 12)
        int openCounter = 0; //счетчик открытых иконок (максимум 2)
        int seconds, minutes, countDown;
        int[] iconPairs, openedIcons;

        
        public FormGame(int Id) //Конструктор принимает ID пользователя в качестве аргумента
        {
            InitializeComponent();
            
            openedIcons = new int[2]; //массив для обозначения двух открытых иконок
            //Массив обозначенных целочисленными значениями пар иконок
            iconPairs = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11 };
            //Заполняем коллекцию готовых иконок хранящихся в PictureBox
            pbGameField = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3,
            pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10,
            pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16,
            pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22,
            pictureBox23, pictureBox24};

            List<Player> playersList = context.Players.ToList(); //Коллекция игроков (таблица игроков в базе данных)
           

            foreach (var a in playersList) // поиск игрока по базе данных по переданному ID  
                if (a.Id == Id) //При нахождении выдаем персональное приветствие в лейбл
                {
                    playerId = a.Id;
                    labelGame.Text = "Приветствую тебя странник в этом путешествии\n"
                        +"Я вижу что тебе покровительствует знак " +a.Sign +" и я расскажу тебе о том, что тебя ждет сегодня...\n" +
                        "Но тебе придется открыть это предсказание\n" +
                        "Удачи тебе "+ a.Login;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread mainMusicThread = new Thread(sound.MainMusic); //Запуск фоновой музыки в отдельном потоке
            mainMusicThread.Start();

            HideCounter();
            ShuffleIcons();
            GetIcons();
            HideIcons();
            DisableIcons();
        }
      
        private void ProphecyWindow() // Метод открывает окно с предсказанием и прячет игровое поле
        {
            FormProphecy prophecyForm = new FormProphecy(playerId);
            prophecyForm.Show();
            this.Visible = false;
            Thread winMusicThread = new Thread(sound.WinMusic);
            winMusicThread.Start();
        }
        private void GetIcons()// Заполнение коллекции иконками
        {
            for (int i = 0; i < pbGameField.Count; i++)
            {
                pbGameField[i].BackgroundImage = imageList1.Images[iconPairs[i]];
            }
        }
        private void HideIcons()//Метод закрытия иконок
        {
            for (int i = 0; i < pbGameField.Count; i++)
            {
                pbGameField[i].BackgroundImage = imageList1.Images[12];
            }
        }
        private void DisableIcons()//Иконки недоступны для клика
        {
            for (int i = 0; i < pbGameField.Count; i++)
            {

                pbGameField[i].Enabled = false;
            }
        }
        private void EnableIcons()//Иконки доступны для клика
        {
            for (int i = 0; i < pbGameField.Count; i++)
            {

                pbGameField[i].Enabled = true;
            }
        }

        private void ShuffleIcons() // Метод рандомного перемешивания иконок
        {
            Random R = new Random();
            for (int i = iconPairs.Length - 1; i >= 1; i--)
            {
                int j = R.Next(i + 1);
                int tmp = iconPairs[j];
                iconPairs[j] = iconPairs[i];
                iconPairs[i] = tmp;
            }
            for (int i = 0; i < pbGameField.Count; i++)
            {
                pbGameField[i].Visible = true;
            }

        }
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            startBtn.Text = "Start Game";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds = seconds - 1;
            if (seconds == -1)
            {
                minutes = minutes - 1;
                seconds = 59;
            }
            if (minutes == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }
            secondsLbl.Text = seconds.ToString();
            minutesLbl.Text = minutes.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e) // отсчет до начала игры
        {
            GetIcons();
            countDown = countDown - 1;
            if (countDown == 0)
            {
                timer2.Stop();
                leftLabel.Text = "UserName";
                EnableIcons();
                HideIcons();
                Thread ngMusicThread = new Thread(sound.NewGameMusic);
                ngMusicThread.Start();
                ShowCounter();
                timer1.Start();
            }
            leftLabel.Text = countDown.ToString();
        }
        private void HideCounter()
        {
            secondsLbl.Visible = false;
            minutesLbl.Visible = false;
            minutesLbl.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вот тут надо сделать отдельное окно. Идея со страницами была плохой
            gamePanel.Controls.Clear();
            gamePanel.Controls.Add(new TopPlayersPage());
        }


        private void ShowCounter()
        {
            secondsLbl.Visible = true;
            minutesLbl.Visible = true;
            minutesLbl.Visible = true;
        }

        //Чтобы не прописывать клик для каждой иконки отдельно, используем Control.Tag
        //В данном случае получаем номер используемого элемента управления, а именно нажатый pictureBox
        private void pictureBox2_Click(object sender, EventArgs e)
        {
       

            Thread clickMusicThread = new Thread(sound.ClickMusic);
            clickMusicThread.Start();

            PictureBox pictureBox = (PictureBox)sender;
            int index = Convert.ToInt32(pictureBox.Tag);//Получаем целочисленное значение, которое равно номеру нажатой иконки

            openedIcons[openCounter] = index; //находим в массиве открытых иконок ту, индекс которой, был получен при клике
            EnableIcons();
            openCounter++;
            //делаем второй клик по открытым иконкам невозможным
            if (openCounter == 1)
            {
                pbGameField[openedIcons[0]].Enabled = false;
            }

            if (openCounter == 2)
            {
                pbGameField[openedIcons[1]].Enabled = false;
            }
            //Если значения открытых иконок в массиве не равны, то закрываем все поле и обнуляем счетчик кликов
            if (openCounter == 2 && iconPairs[openedIcons[0]] != iconPairs[openedIcons[1]])
            {
                HideIcons();
                openCounter = 0;
                pbGameField[openedIcons[1]].Enabled = false;
                Thread failMusicThread = new Thread(sound.FailMusic);
                failMusicThread.Start();
            }
            //Если значения открытых иконок в массиве равны, то убираем их с поля и используем счетчик угаданных пар
            if ((openCounter == 2 && iconPairs[openedIcons[0]] == iconPairs[openedIcons[1]]))
            {
                HideIcons();
                openCounter = 0;
                pbGameField[openedIcons[0]].Visible = false;
                pbGameField[openedIcons[1]].Visible = false;
                mainCounter++;
                Thread successMusicThread = new Thread(sound.SuccessMusic);
                successMusicThread.Start();
                //Когда счетчик угаданных пар доходит до 12 - Игра окончена. Со сменой текста в лейбле надо еще разобраться
                if (mainCounter == 12)
                {
                    this.labelGame.Text = "Ну вот и все! Мои поздравления\n"
                                 + "У тебя получилось открыть предсказание и ты заслужил его!\n"
                                 + "\n"
                                 + "Немного терпения и ты получишь его!";

                    Thread.Sleep(3000);
                    ProphecyWindow();

                }
            }
            // Задаем нажатаой иконке изображение, числовое значение которого в коллекции Images, хранящейся в imageList1 
            // равно индексу в массиве перемешанных пар, который в свою очередь, равен индексу полученому при клике
            pictureBox.BackgroundImage = imageList1.Images[iconPairs[index]]; 
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            Thread winMusicThread = new Thread(sound.WinMusic);
            winMusicThread.Start();
            HideCounter();
            EnableIcons();
            ShuffleIcons();
            DisableIcons();
            HideIcons();
            countDown = 5;
            seconds = 59;
            minutes = 5;
            startBtn.Enabled = false;
            
            timer2.Start();
            startBtn.Text = "Good Luck";
            startBtn.ForeColor = System.Drawing.Color.Goldenrod;


        }
    }
}
