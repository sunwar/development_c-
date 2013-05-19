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
       void showCreateTask();
    }

    public partial class PresentTestViewController : Form
    {
        private PresentTestDelegate presentTestDelegate;
        public PresentTestViewController(PresentTestDelegate _presenTestDelegate)
        {
            presentTestDelegate = _presenTestDelegate;
            InitializeComponent();
        }

        private void создатьЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presentTestDelegate.showCreateTask();
        }
    }
}
