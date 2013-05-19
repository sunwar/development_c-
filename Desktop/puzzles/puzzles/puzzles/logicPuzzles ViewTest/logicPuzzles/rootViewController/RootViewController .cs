using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Data.SqlClient;
using logicPuzzles.DataBase;

namespace logicPuzzles
{
   public interface RootControllerDelegate
    {
        void showCreateController();
    }

    struct itemTask
    {
        private TextBox textBoxTask;
        private PictureBox pictureBoxTask;

        public itemTask(TextBox textBoxTask, PictureBox pictureBoxTask)
        {
            this.textBoxTask = textBoxTask;
            this.pictureBoxTask = pictureBoxTask;
        }

        public PictureBox PictureBoxTask
        {
            get { return pictureBoxTask; }
        }

        public TextBox TextBoxTask
        {
            get { return textBoxTask; }
        }
    }

    public partial class RootViewController : Form
    {
        private RootControllerDelegate rootDelegate;
        private DataBaseModel dataBase;

        public RootViewController(RootControllerDelegate _rootDelegate)
        {
            InitializeComponent();
            rootDelegate = _rootDelegate;
        }

        private void создатьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                DataBaseModel._connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileDialog.FileName;
                dataBase = DataBaseModel.getInstance();
                rootDelegate.showCreateController();
            }
        }

        private void setup()
        { 
           
        }

    }

    }

