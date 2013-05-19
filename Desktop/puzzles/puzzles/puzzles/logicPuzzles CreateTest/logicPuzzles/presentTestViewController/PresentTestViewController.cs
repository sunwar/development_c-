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
       void showChangeTask(string nameTest);
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

        public void setupTask(bool changeTask)
        {
            if (changeTask)
            {
                changeTaskButton.Visible = true;
                createTaskButton.Visible = false;
            }
            else
            {
                changeTaskButton.Visible = false;
                createTaskButton.Visible = true;
            }
        }


        private void createTaskButton_Click(object sender, EventArgs e)
        {
            presentTestDelegate.showCreateTask();
        }

        private void ChangeTaskButton_Click(object sender, EventArgs e)
        {
            presentTestDelegate.showChangeTask(NameTest);
        }
    }
}
