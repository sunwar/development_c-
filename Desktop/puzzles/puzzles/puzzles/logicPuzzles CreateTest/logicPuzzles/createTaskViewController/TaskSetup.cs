using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
