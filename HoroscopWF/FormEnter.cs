using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopWF
{
    public partial class FormEnter : Form
    {
        static MyDbContext context = new MyDbContext();
   
        
        string startPath = Directory.GetCurrentDirectory();
        int counter = 0;

        public FormEnter()
        {
            InitializeComponent();
            //MessageBox.Show(startPath+@"\victory.wav");
            
            this.AcceptButton = enterButton; // enterButton срабатывает по нажатию клавиши Enter, а нет только по клику
   
        }
        private void UserEnter()
        {
            
                

        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            List<Player> playersList = context.Players.ToList();
            foreach (var a in playersList)
            {
                if (loginTb.Text == a.Login && passwordTb.Text == a.Password)
                {

                    FormGame gameForm = new FormGame(a.Id);
                    // Открываем новое игровое поле и передаем туда ID пользователя
                    gameForm.Show();
                    this.Hide();
                    
                }
                else
                    counter++;
                  
            }

            if (counter == playersList.Count)
            {

                passwordTb.Text = null;
                loginTb.Text = null;
                MessageBox.Show("Проверьте правильность написания логина и пароля");
                this.Refresh(); // Перезапускаем данную форму в случае неправильного ввода данных


            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration regForm = new FormRegistration();
            regForm.Show();
        }

  
    }
}
