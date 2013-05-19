using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace logicPuzzles
{
   public interface PresentTestDelegate
    {
       void showOpenTask(string nameTest);
    }

    public partial class PresentTestViewController : Form
    {
        private PresentTestDelegate presentTestDelegate;
        private string nameTest;

        public string NameTest
        {
            get { return nameTest; }
            set { nameTest = value; }
        }

        public PresentTestViewController(PresentTestDelegate _presenTestDelegate)
        {
            presentTestDelegate = _presenTestDelegate;
            InitializeComponent();
        }

        private void открытьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presentTestDelegate.showOpenTask(nameTest);
        }
    }
}
