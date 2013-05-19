using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using logicPuzzles.DataBase;


namespace logicPuzzles
{
    public interface OpenTaskDelegate
    {
      void showPresentTaskController(TaskSetup taskSetup);
    }

    public partial class OpenTaskViewController : Form
    {
        private OpenTaskDelegate createTaskDelegate;
       
        public OpenTaskViewController(OpenTaskDelegate _createTaskDelegate)
        {
            InitializeComponent();
            createTaskDelegate = _createTaskDelegate;
            setup();
        }

        public void selectTask(string nameTest)
        {
            taskComboBox.Items.Clear();
            DataBaseModel curentBase = DataBaseModel.getInstance();
            System.Collections.IEnumerator enumerator = curentBase.getContext().task.GetEnumerator();
            while (enumerator.MoveNext())
            {
                task curentTast = (task)enumerator.Current;
                string curentTestName = curentTast.test.tname;
                if (curentTestName.CompareTo(nameTest) == 0)
                {
                    taskComboBox.Items.Add(curentTast.tname);
                }
            }
        }

        #region - Handlers
        private void openTaskButton_Click(object sender, EventArgs e)
        {
            string taskName = taskComboBox.Text;
            if (taskName.Length > 2)
            {
                loadTask(taskName);
            }
        }
        #endregion

      
        #region - Utils
        private void setup()
        {
            
        }

        private void loadTask(string nameTask)
        {
            DataBaseModel curentBase = DataBaseModel.getInstance();
            List<links> listLinks = new List<links>();
            System.Collections.IEnumerator enumerator = curentBase.getContext().links.GetEnumerator();
            while (enumerator.MoveNext())
            {
                links curentLinks = (links)enumerator.Current;
                task curentTask = curentLinks.task;
                string curentTestName = curentTask.tname;
                if (curentTestName.CompareTo(nameTask) == 0)
                {
                    listLinks.Add(curentLinks);
                }
            }

            if (listLinks.Count == 0) return;
           
            TaskSetup taskSetup = new TaskSetup();
            taskSetup.counPage = 1;
            taskSetup.listPuzzleBox = new List<PuzzleBox>();

            for (int i = 0; i < listLinks.Count; i++)
            {
                links curentLinks = listLinks.ToArray()[i];
                pic curentPic = curentLinks.pic;
               
                if (curentPic.opic == null)
                    continue;

                System.IO.MemoryStream memory = new System.IO.MemoryStream(curentPic.opic);
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(memory);
                Image image = Image.FromStream(writer.BaseStream);
                PictureBox picBox = new PictureBox();
                picBox.Image = image;

                PuzzleBox puzzleBox = new PuzzleBox();
                puzzleBox.pictures = picBox;
                puzzleBox.namePic = curentLinks.tname;
                taskSetup.listPuzzleBox.Add(puzzleBox);
            }
            taskSetup.countPictures = taskSetup.listPuzzleBox.Count;
            createTaskDelegate.showPresentTaskController(taskSetup);
        }

        #endregion



       
    }
}
