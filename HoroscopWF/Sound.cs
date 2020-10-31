using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopWF
{
    
    class Sound
    {
        string victoryPath, clickPath, failPath, mainPath, successPath, newPath;
        //string startPath = Application.StartupPath;
        public void WinMusic()
        {
            victoryPath = Application.StartupPath + @"\Sounds\victory.wav";
            MyPlayer.Play(victoryPath);
            
        }
        public void ClickMusic()
        {
            clickPath = Application.StartupPath + @"\Sounds\click.wav";
            MyPlayer.Play(clickPath);
            
        }
        public void FailMusic()
        {
            failPath = Application.StartupPath + @"\Sounds\fail.wav";
            MyPlayer.Play(failPath);
            
        }
        public void MainMusic()
        {
            mainPath = Application.StartupPath + @"\Sounds\mainMusic.wav";
            MyPlayer.Play(mainPath);
            
        }
        public void SuccessMusic()
        {
            successPath = Application.StartupPath + @"\Sounds\success.wav";
            MyPlayer.Play(successPath);

        }
        public void NewGameMusic()
        {
            newPath = Application.StartupPath + @"\Sounds\newgame.wav";
            MyPlayer.Play(newPath);

        }
    }
}
