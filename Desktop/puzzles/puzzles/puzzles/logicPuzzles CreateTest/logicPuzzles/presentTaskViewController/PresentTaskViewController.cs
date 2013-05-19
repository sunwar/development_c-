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
    public  interface PresentTaskDelegate
    {
        void showPresentTask();
        void bachController(PresentTaskViewController presentController);
    }

    public partial class PresentTaskViewController : Form
    {
        private PresentTaskDelegate presentTaskDelegate;
        DataBaseModel dataBase;

        private const int MAX_COUNT_PICTURES = 8;
        private const int COUNT_LINE_PICTURES = 2;
        private int curentPage;
        private int countPage;
        private int countPictures;
        private int indexPic;

        private double widthPic;
        private double heightPic ;
        private double widthLabel ;
        private double heightLabel ;

        private Dictionary<string,Panel> dictImage;
        private List<Puzzle> listPuzzle;

        private TextBox curentNamePic;
        private Label curentLabel;


        public PresentTaskViewController(PresentTaskDelegate _presentTaskDelegate)
        {
            InitializeComponent();
            presentTaskDelegate = _presentTaskDelegate;
            setup();
        }


        #region - Handlers
        void curentPictures_Click(object sender, EventArgs e)
        {
            PictureBox curentPictures = (PictureBox)sender;
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                curentPictures.Image = new Bitmap(openDialog.FileName);
                dataBase.loadPic(openDialog.FileName, Int32.Parse(curentPictures.Tag.ToString()));
            }
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            if (curentPage < countPage)
            {
                curentPage++;
                updatePageLabel(curentPage);
                changeContent(curentPage);
            }
        }

        private void backPageButton_Click(object sender, EventArgs e)
        {
            if (curentPage > 1)
            {
                curentPage--;
                updatePageLabel(curentPage);
                changeContent(curentPage);
            }
        }

        void nameImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Label curentNameLabel = (Label)sender;
            TextBox nameTextBox = new TextBox();
            nameTextBox.Bounds = curentNameLabel.DisplayRectangle;
            curentNameLabel.Controls.Add(nameTextBox);
            nameTextBox.LostFocus += new EventHandler(nameTextBox_LostFocus);
            nameTextBox.DoubleClick += new EventHandler(nameTextBox_Click);
            curentNamePic = nameTextBox;
        }

        void nameTextBox_LostFocus(object sender, EventArgs e)
        {
            setNamePic((TextBox)sender);
        }

        void nameTextBox_Click(object sender, EventArgs e)
        {
            setNamePic(curentNamePic);
        }

        void Control_MouseMove(object sender, MouseEventArgs e)
        {
            this.OnMouseMove(e);
        }

        void nameImage_MouseDown(object sender, MouseEventArgs e)
        {
            curentLabel = (Label)sender;   
        }

        void nameImage_MouseUp(object sender, MouseEventArgs e)
        {
            curentLabel = null;
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            List<string> listName = new List<string>();
            for (int i = 0; i < listPuzzle.Count; i++)
            {
                Puzzle puzzle = listPuzzle.ToArray()[i];
                listName.Add(puzzle.namePuzzle.Text);
            }
            dataBase.setNamePics(listName.ToArray());
            dataBase.linksPic();
            dataBase.saveTask();
            presentTaskDelegate.bachController(this);
        }

        #endregion

        #region - Utils
        public void setupTask(TaskSetup taskSetup)
        {
            countPictures = taskSetup.countPictures;
            countPage = taskSetup.counPage;
            picturesPanel.Controls.Clear();

            for (int i = 1; i <= countPage; i++)
            {
                Panel curentImagePanel = new Panel();
                curentImagePanel.MouseMove += new MouseEventHandler(Control_MouseMove);
                curentImagePanel.Bounds = picturesPanel.DisplayRectangle;

                Panel curentTextPanel = new Panel();
                curentTextPanel.MouseMove += new MouseEventHandler(Control_MouseMove);
                curentTextPanel.Bounds = namePicturesPanel.DisplayRectangle;

                for (int j = 0; j < countPictures; j++)
                {
                    PictureBox curentPictures = new PictureBox();
                    indexPic++;
                    curentPictures.Tag = indexPic;
                    setupPicturesBox(curentPictures);
                    addedControlToContainer(ref curentImagePanel, j, curentPictures);
                    Puzzle puzzle = new Puzzle();
                    puzzle.imagePuzzle = curentPictures;

                    Label curentLabel = new Label();
                    puzzle.namePuzzle = curentLabel;
                    setupLabel(curentLabel,j);
                    addedControlToContainer(ref curentImagePanel, j, curentLabel);

                    listPuzzle.Add(puzzle);
                }

                if (dictImage.ContainsKey(i.ToString()) == false)
                {
                    dictImage.Add(i.ToString(), curentImagePanel);
                }
            }

            if (countPage > 1)
            {
                navigationPanel.Visible = true;
                pageLabel.Text = curentPage.ToString() + '/' + countPage.ToString();
            }

            Panel startImagePanel = null;
            dictImage.TryGetValue("1", out startImagePanel);

            if (startImagePanel != null )
            { 
                picturesPanel.Controls.Add(startImagePanel);
                picturesPanel.Refresh();
            }
        }

        private void setup()
        {
            navigationPanel.Visible = false;
            dictImage = new Dictionary<string, Panel>();
            listPuzzle = new List<Puzzle>();
            curentPage = 1;
            dataBase = DataBaseModel.getInstance();
        }

        private void changeContent(int page)
        {
            Panel nextImagePanel = null;
            picturesPanel.Controls.Clear();
            dictImage.TryGetValue(page.ToString(), out nextImagePanel);

            if (nextImagePanel != null )
            {
                picturesPanel.Controls.Add(nextImagePanel);
                this.FindForm().Refresh();
            }
        }

        private void updatePageLabel(int page)
        {
            pageLabel.Text = page.ToString() + '/' + countPage.ToString();
        }

        private void addedControlToContainer(ref Panel container, int indexControl, Control control)
        {
            Rectangle containerlBounds = container.Bounds;

            double oneProcentHeight = containerlBounds.Height / 100;
            double oneProcentWidth = containerlBounds.Width / 100;
            double widtIndention = oneProcentWidth * 5;
            double heightIndention = oneProcentHeight * 10;
            double topPading = oneProcentHeight * 40;

            if (countPictures <= MAX_COUNT_PICTURES / COUNT_LINE_PICTURES)
            {
                if (control.GetType() == typeof(Label))
                {
                    heightLabel = heightIndention;
                    widthLabel = widthPic;
                }
                else
                {
                   widthPic = (containerlBounds.Width - (widtIndention * countPictures) ) / countPictures;
                   heightPic = (containerlBounds.Height - heightIndention - topPading);
                }
            }
            else
            {
                if (control.GetType() == typeof(Label))
                {
                    heightLabel = heightIndention;
                    widthLabel = widthPic;
                }
                else
                {
                    widthPic = (containerlBounds.Width - (widtIndention * (MAX_COUNT_PICTURES / COUNT_LINE_PICTURES))) / (MAX_COUNT_PICTURES / COUNT_LINE_PICTURES);
                    heightPic = (containerlBounds.Height - heightIndention - topPading) / COUNT_LINE_PICTURES;
                }
            }

            Rectangle controlBounds = control.Bounds;
            if (indexControl >= MAX_COUNT_PICTURES / COUNT_LINE_PICTURES)
            {
                if (control.GetType() == typeof(Label))
                {
                    controlBounds.Y = (int)(containerlBounds.Y + (heightIndention  + widthPic) * COUNT_LINE_PICTURES);
                }
                else
                {
                    controlBounds.Y = (int)(heightPic + heightIndention); 
                }
                controlBounds.X = (int)((indexControl - MAX_COUNT_PICTURES / COUNT_LINE_PICTURES) * (widthPic + widtIndention));
            }
            else
            {
                if (control.GetType() == typeof(Label))
                {
                    controlBounds.Y = (int)(containerlBounds.Y + heightPic);
                }
                else
                {
                    controlBounds.Y = containerlBounds.X;  
                }
                controlBounds.X = (int)(indexControl * (widthPic + widtIndention));
            }

            if (control.GetType() == typeof(Label))
            {
                controlBounds.Width = (int)widthLabel;
                controlBounds.Height = (int)heightLabel;
            }
            else
            {
                controlBounds.Width = (int)widthPic;
                controlBounds.Height = (int)heightPic;
            }

           
            control.Bounds = controlBounds;
            container.Controls.Add(control);
        }

        private void setNamePic(TextBox nameTextBox)
        {
            if (nameTextBox != null && nameTextBox.Parent != null)
            {
                Label curentNameLabel = (Label)nameTextBox.Parent;
                if (nameTextBox.Text.Length > 2)
                {
                    curentNameLabel.Text = nameTextBox.Text;
                }
                curentNameLabel.Controls.Remove(nameTextBox);
                curentNameLabel.Refresh();
            }
        }

        private void setupLabel(Label curentLabel , int numLabel)
        {
            curentLabel.BringToFront();
            curentLabel.BackColor = Color.White;
            curentLabel.MouseDoubleClick += new MouseEventHandler(nameImage_MouseDoubleClick);
            curentLabel.MouseDown += new MouseEventHandler(nameImage_MouseDown);
            curentLabel.MouseUp += new MouseEventHandler(nameImage_MouseUp);
            curentLabel.Text = "Изображение " + numLabel.ToString();
            curentLabel.ImageAlign = ContentAlignment.BottomCenter;
        }

        private void setupPicturesBox(PictureBox curentPictures)
        {
            curentPictures.MouseMove += new MouseEventHandler(Control_MouseMove);
            curentPictures.BackColor = Color.Red;
            curentPictures.Click += new EventHandler(curentPictures_Click);
            curentPictures.SizeMode = PictureBoxSizeMode.StretchImage;
        }
 
        #endregion  

        
    }
   
}
