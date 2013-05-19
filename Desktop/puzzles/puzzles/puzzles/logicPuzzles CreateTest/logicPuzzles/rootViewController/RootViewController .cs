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
        public RootViewController(RootControllerDelegate _rootDelegate)
        {
            InitializeComponent();
            rootDelegate = _rootDelegate;
        }

        private void создатьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rootDelegate.showCreateController();
        }

    }

    /*
    public partial class RootViewController : Form
    {
        
        Form setupTest;
        CreateTaskViewController createTask;

        private List<object> listItemTask;
        private int countImage;
       
        private DataBaseModel curentBase;
        private DataClasses1DataContext context;

        public RootViewController()
        {
            InitializeComponent();
            listItemTask = new List<object>();
            OleDbConnection connection = new OleDbConnection(Properties.Resources.testConnection);
            connection.Open();
            context = new DataClasses1DataContext(connection);
            curentBase = DataBaseModel.getInstance(Properties.Resources.testConnection);
            curentBase.createTest("test");
            curentBase.createTask(4, "task1");
        }

        private void создатьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setupTest = new Form();
            TextBox nameTest = new TextBox();
            Button createTestButton = new Button();
         
            createTestButton.Click += new EventHandler(createTestButton_Click);
            createTestButton.Text = "Создать тест!";
            GroupBox groupBoxRadio = new GroupBox();
            groupBoxRadio.SetBounds(30, 30, 200, 200);
            nameTest.SetBounds(30, 10, 200, 200);
            createTestButton.SetBounds(30, 230, 200, 30);
            for (int i = 1; i < 5; i++)
            {
                RadioButton curentRadioBtn = new RadioButton();
                curentRadioBtn.Text = (2 * i).ToString();
                curentRadioBtn.Location = new Point(20 , 35 * i );
                curentRadioBtn.CheckedChanged += new EventHandler(curentRadioBtn_CheckedChanged);
                groupBoxRadio.Controls.Add(curentRadioBtn);
            }
            setupTest.Controls.Add(nameTest);
            setupTest.Controls.Add(groupBoxRadio);
            setupTest.Controls.Add(createTestButton);
            setupTest.ShowDialog();
        }

        void curentRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            countImage = Int32.Parse( ((RadioButton)sender).Text);  
        }

        void createTestButton_Click(object sender, EventArgs e)
        {
            Form setupTest = (Form)(((Button)sender).Parent);
            setupTest.Close();
            createTask = new CreateTaskViewController();
            for (int i = 1; i <= countImage; i++)
            {
                PictureBox curentPicturesBox = new PictureBox();
                curentPicturesBox.SizeMode = PictureBoxSizeMode.StretchImage;
                curentPicturesBox.Click += new EventHandler(curentPicturesBox_Click);
                TextBox curentTextbox = new TextBox();
                curentTextbox.MouseMove += new MouseEventHandler(curentTextbox_MouseMove);
                curentPicturesBox.SetBounds(100 * i, 10, 80, 300);
                curentTextbox.SetBounds(100 * i, 320, 80, 20);
                itemTask item = new itemTask(curentTextbox, curentPicturesBox);
                listItemTask.Add(item);
                Button createTaskButton = new Button();
                createTaskButton.Text = "Сохранить задание!";
                createTaskButton.Click += new EventHandler(createTaskButton_Click);
                createTaskButton.SetBounds(100, 360,( 1 + countImage) * curentPicturesBox.Bounds.Width, 30);
                createTask.Controls.Add(curentPicturesBox);
                createTask.Controls.Add(curentTextbox);
                createTask.Controls.Add(createTaskButton);
            }
            createTask.ShowDialog();
        }

        void createTaskButton_Click(object sender, EventArgs e)
        {
           // string[] array = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            //curentBase.loadPic(path, numerPic);
          //  curentBase.setNamePics(array);
          //  curentBase.linksPic();
          //  curentBase.saveTask();

            for (int i = 0; i < listItemTask.Count; i++)
            {
                //itemTask item =;
            }
        }

        void curentTextbox_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox curentTextBox = (TextBox)sender;
            this.Cursor = new Cursor(Cursor.Current.Handle);
            //curentTextBox.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        }

        void curentPicturesBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox curentImage = (PictureBox)sender;
                curentImage.Image = new Bitmap(openDialog.FileName);
            }
        }

        private void загрузитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
     * */
    }

