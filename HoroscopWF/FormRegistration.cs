using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopWF
{
    public partial class FormRegistration : Form
    {
        
        FormEnter enterForm = new FormEnter();
        string userSign = "";
        int score = 0;

        public FormRegistration()
        {
            InitializeComponent();
    
        }

        private void GetUserSign()
        {
            int[] date = new int[2];
            date[0] = Convert.ToInt32(DayTb.Text);
            date[1] = Convert.ToInt32(MonthTb.Text);
            if (date[0] > 31 || date[1] > 12 || (date[0] < 0) || date[1] < 0)
                MessageBox.Show("Неверная дата!");



            if ((date[0] >= 21 && date[1] == 3) || (date[0] <= 20 && date[1] == 4)) userSign = "Овен";
            else if ((date[0] >= 21 && date[1] == 4) || (date[0] <= 20 && date[1] == 5)) userSign = "Телец";
            else if ((date[0] >= 21 && date[1] == 5) || (date[0] <= 21 && date[1] == 6)) userSign = "Близнецы";
            else if ((date[0] >= 22 && date[1] == 6) || (date[0] <= 22 && date[1] == 7)) userSign = "Рак";
            else if ((date[0] >= 23 && date[1] == 7) || (date[0] <= 23 && date[1] == 8)) userSign = "Лев";
            else if ((date[0] >= 24 && date[1] == 8) || (date[0] <= 23 && date[1] == 9)) userSign = "Дева";
            else if ((date[0] >= 24 && date[1] == 9) || (date[0] <= 23 && date[1] == 10)) userSign = "Весы";
            else if ((date[0] >= 24 && date[1] == 10) || (date[0] <= 22 && date[1] == 11)) userSign = "Скорпион";
            else if ((date[0] >= 23 && date[1] == 11) || (date[0] <= 21 && date[1] == 12)) userSign = "Стрелец";
            else if ((date[0] >= 22 && date[1] == 12) || (date[0] <= 20 && date[1] == 1)) userSign = "Козерог";
            else if ((date[0] >= 21 && date[1] == 1) || (date[0] <= 18 && date[1] == 2)) userSign = "Водолей";
            else userSign = "Рыбы";

        }
        private void regButton_Click(object sender, EventArgs e)
        {
            Player player = new Player();

            if (loginTb.Text.Length > 0)
            {
                if (passwordTb.Text.Length > 0)
                {
                    if (Convert.ToInt32(DayTb.Text) > 0)
                    {
                        if (Convert.ToInt32(MonthTb.Text) > 0)
                        {
                            if (Convert.ToInt32(YearTb.Text) > 0)
                            {

                            }
                            else MessageBox.Show("Укажите год рождения(две последние цифры)");

                        }
                        else MessageBox.Show("Укажите месяц рождения (без нуля)");

                    }
                    else MessageBox.Show("Укажите день рождения(без нуля");

                }
                else MessageBox.Show("Укажите пароль");
            }
            else MessageBox.Show("Укажите логин");

            GetUserSign();
            //MessageBox.Show(userSign);
            using (var context = new MyDbContext())
            {
                var newPlayer = new Player()
                {
                    Login = loginTb.Text,
                    Password = passwordTb.Text,
                    Sign = userSign,
                    Score = score
                };
                context.Players.Add(newPlayer);
                context.SaveChanges();
                //MessageBox.Show("Получилось!!!");
                this.Hide();
                FormEnter enterForm = new FormEnter();

                enterForm.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            enterForm.Show();

        }
    }
}
