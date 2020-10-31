using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopWF.Pages
{
    
    public partial class TopPlayersPage : UserControl
    {
        MyDbContext context = new MyDbContext();
        public TopPlayersPage()
        {
            InitializeComponent();
            List<Player> playersList = context.Players.ToList();
            BubbleSort(playersList);
            int counter = 0;
            string topText = "";
            foreach (var a in playersList)
            {
                counter++;
                topText += counter + " - " + a.Login + " - " + " Score - " + a.Score + "\n";
            }
            topPlayersLabel.Text = topText;
        }

        static List<Player> BubbleSort(List<Player> list)
        {
            Player temp;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].Score > list[j].Score)
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
