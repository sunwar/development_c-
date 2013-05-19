using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using logicPuzzles.DataBase;
using System.Data.OleDb;

namespace logicPuzzles
{
    public  interface CreateTestDelegate
    {
        void showPresentTestController(string nameTest);
    }

    public partial class CreateTestViewController : Form
    {
        private CreateTestDelegate createDelegate;
        private DataBaseModel curentBase;
        OleDbConnection connection;
        private string connectionBase;

        public CreateTestViewController(CreateTestDelegate _createDelegate)
        {
            InitializeComponent();
            createDelegate = _createDelegate;
            curentBase = DataBaseModel.getInstance();
        }


        #region - Handlers
        private void createTestButton_Click(object sender, EventArgs e)
        {
            string testName = testNameTextBox.Text;
            if (testName.Length > 2)
            {
                checkBase();
                createTest(testName);
                createDelegate.showPresentTestController(testName);
            }
        }

        private void createTest(string testName)
        {
            curentBase.createTest(testName);
        }
        #endregion

        #region Utils
        private void checkBase()
        {
            string path = Environment.CurrentDirectory + @"\inputFile\compare.accdb";
            if (!File.Exists(path))
            {
                var source = Path.Combine(Environment.CurrentDirectory + @"\cache\", "compare.accdb");
                var dectination = Path.Combine(Environment.CurrentDirectory + @"\inputFile\", "compare.accdb");
                File.Copy(source, dectination);
            } 
        }

        #endregion
    }

}
