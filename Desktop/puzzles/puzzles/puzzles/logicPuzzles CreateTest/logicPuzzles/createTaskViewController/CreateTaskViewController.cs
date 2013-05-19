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
    public interface CreateTaskDelegate
    {
      void showPresentTaskController(TaskSetup taskSetup);
    }

    public partial class CreateTaskViewController : Form
    {
        private CreateTaskDelegate createTaskDelegate;
        private DataBaseModel curentBase;
        
        private int countPictures;
        private int counPage;
        private wraper curentWraper;
        private const string HORIZONTAL = "Горизонтальный";
        private const string VERTICAL = "Вертикальный";

        public CreateTaskViewController(CreateTaskDelegate _createTaskDelegate)
        {
            InitializeComponent();
            createTaskDelegate = _createTaskDelegate;
            setup();

        }

        #region - Handlers
        private void createTaskButton_Click(object sender, EventArgs e)
        {
            if (countPictures != 0 && taskTextBox.Text.Length != 0 && counPage != 0)
            {
                TaskSetup taskSetup = new TaskSetup();
                taskSetup.countPictures = countPictures;
                taskSetup.nameTask = taskTextBox.Text;
                taskSetup.wraperControl = curentWraper;
                taskSetup.counPage = counPage;
                curentBase.createTask(countPictures, taskTextBox.Text);
                createTaskDelegate.showPresentTaskController(taskSetup);
            }
            else
            {
                MessageBox.Show("Задайте все необходимые параметры");
            }
        }

        private void countPageBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox curentComboBox = (ComboBox)sender;
            counPage = Int32.Parse(curentComboBox.SelectedItem.ToString());
        }

        private void countPicCheckedChanged(object sender, EventArgs e)
        {
            RadioButton curentRadioButton = (RadioButton)sender;
            countPictures = Int32.Parse(curentRadioButton.Text);
        }

        private void wraperCheckedChanged(object sender, EventArgs e)
        {
            RadioButton curentRadioButton = (RadioButton)sender;
            if (curentRadioButton.Text.Equals(HORIZONTAL))
            {
                curentWraper = wraper.Horizontal;
            }
            else if (curentRadioButton.Text.Equals(VERTICAL))
            {
                curentWraper = wraper.Vertical;
            }

        }

        #endregion

      
        #region - Utils
        private void setup()
        {
            countPictures = 0;
            countPictures = 2;
            curentWraper = wraper.Horizontal;
            curentBase = DataBaseModel.getInstance();
        }

        #endregion

       
    }
}
