using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace logicPuzzles
{
   public enum wraper
    {
        Horizontal,
        Vertical
    }

   public class TaskSetup
    {
        public int countPictures;
        public string nameTask;
        public wraper wraperControl;
        public int counPage;
        //public List<PictureBox> listPick;
        //public List<string> namePick;
        public List<PuzzleBox> listPuzzleBox;
    }
}
