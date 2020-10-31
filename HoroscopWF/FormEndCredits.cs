using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopWF
{
    public partial class FormEndCredits : Form
    {
        
        public FormEndCredits()
        {
            InitializeComponent();
            

        }
    
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
