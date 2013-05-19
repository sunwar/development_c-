using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace logicPuzzles
{
    public  interface PresentTaskDelegate
    {
        void showPresentTask();
    }

    public partial class PresentTaskViewController : Form
    {
        private const int MAX_COUNT_PICTURES = 8;
        private const int COUNT_LINE_PICTURES = 2;
        private const int INCREASE_PICTURES = 20;
        
        private int curentPage;
        private int countPage;
        private int countPictures;
        private int picTag;

        private Dictionary<string,Panel> dictImage;
        private List<Puzzle> listPuzzle;
        private List<PuzzleBox> listPuzzleBox;
        private List<PuzzleBox> selectListPuzzleBox;
        private PictureBox selectPic;

        private PresentTaskDelegate presentTaskDelegate;
        private TextBox curentNamePic;
        private Label curentMoveLabel;

        private MousePosition mousePosition;

        public PresentTaskViewController(PresentTaskDelegate _presentTaskDelegate)
        {
            InitializeComponent();
            presentTaskDelegate = _presentTaskDelegate;
            setup();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (curentMoveLabel != null)
            {
                if (mousePosition == null)
                {
                    mousePosition = new MousePosition();
                    mousePosition.X = e.Location.X;
                    mousePosition.Y = e.Location.Y;
                }

                Point startMovePoint = new Point(mousePosition.X , mousePosition.Y);
                Point newPointControl = new Point();
                newPointControl.X = e.X - startMovePoint.X;
                newPointControl.Y = e.Y - startMovePoint.Y;
                Point controlLocation = curentMoveLabel.Location;
                controlLocation.X += newPointControl.X;
                controlLocation.Y += newPointControl.Y;
                curentMoveLabel.Location = controlLocation;
            }
        }


        #region - Handlers
       
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
            curentMoveLabel = (Label)sender;
           
        }

        void nameImage_MouseUp(object sender, MouseEventArgs e)
        {
            curentMoveLabel = null;
            mousePosition = null;

            Label curentLabel = (Label)sender;
            PictureBox curentPic = isCheckAreaEntering(curentLabel);
            if (curentPic != null)
            {
                Rectangle rectLabel = curentLabel.Bounds;
                Rectangle rectPic = curentPic.Bounds;
                rectLabel.X = rectPic.X + 1;
                rectLabel.Y = rectPic.Y + rectPic.Height + 1;
                curentLabel.Bounds = rectLabel;
                PuzzleBox puzzleBox = new PuzzleBox();
                puzzleBox.namePic = curentLabel.Text;
                puzzleBox.pictures = curentPic;
                puzzleBox.tag = curentPic.Tag;
                addedPuzzleToLis(puzzleBox);
            }
        }

        void nameImage_Move(object sender, EventArgs e)
        {
          PictureBox pic = isCheckAreaEntering((Label)sender);
          if (pic != null)
          {
              checkPictures(pic);
              selectPic = pic;
          }
          else
          {
              if (selectPic != null)
              {
                  reducePic(selectPic);
                  selectPic = null;
              }
          }
        }

        private void validateTaskButton_Click(object sender, EventArgs e)
        {
            string message;
            if (isValidateSelect())
            {
                message = "Тест успешно пройден!";
            }
            else
            {
                message = "Тест не пройден!";
            }
            MessageBox.Show(message);

        }

        #endregion

        #region - Utils
        public void setupTask(TaskSetup taskSetup)
        {

            countPictures = taskSetup.countPictures;
            countPage = taskSetup.counPage;
            listPuzzleBox = taskSetup.listPuzzleBox;

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
                    Label curentLabel = new Label();
                    setupLabel(curentLabel,j);
   
                    curentLabel.Text = listPuzzleBox.ToArray()[j].namePic;
                    addedControlToContainer(ref curentImagePanel, j, curentLabel);
                }

                for (int j = 0; j < countPictures; j++)
                {
                    picTag++;
                    PictureBox curentPictures = listPuzzleBox.ToArray()[j].pictures;
                    curentPictures.Tag = picTag;
                    listPuzzleBox.ToArray()[j].tag = picTag;

                    setupPicturesBox(curentPictures);
                    addedControlToContainer(ref curentImagePanel, j, curentPictures);
                    Puzzle puzzle = new Puzzle();
                    puzzle.imagePuzzle = curentPictures;
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
            selectListPuzzleBox = new List<PuzzleBox>();
            curentPage = 1;
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
            double oneProcentWidth = 0;
            double oneProcentHeight = 0;
            double widtIndention = 0;
            double heightIndention = 0;
            double topPading = 0; 
            double widthCurentControl = 0;
            double heightCurentControl = 0;
            double containerWidth = 0;
            double containerHeight = 0;
            int containerX = 0;
            int containerY = 0;

            if (control.GetType() == typeof(PictureBox))
            {
                 containerWidth = containerlBounds.Width;
                 containerHeight = containerlBounds.Height;
                 containerX = containerlBounds.X;
                 containerY = containerlBounds.Y;
                 oneProcentHeight = containerHeight / 100;
                 topPading = oneProcentHeight * 40;
            }
            else if (control.GetType() == typeof(Label))
            {
                containerWidth = containerlBounds.Width;
                containerHeight = containerlBounds.Height / 3;
                containerX = containerlBounds.X;
                oneProcentHeight = containerHeight / 100;
            }
            oneProcentWidth = containerWidth / 100;
            widtIndention = oneProcentWidth * 5;
            heightIndention = oneProcentHeight * 10;

            if (countPictures <= MAX_COUNT_PICTURES / COUNT_LINE_PICTURES)
            {
                widthCurentControl = (containerWidth - (widtIndention * countPictures)) / countPictures;
                if (control.GetType() == typeof(Label))
                {
                   heightCurentControl = heightIndention;
                }
                else
                {
                   heightCurentControl = (containerHeight - heightIndention - topPading);
                }
            }
            else
            {
                widthCurentControl = (containerWidth - (widtIndention * (MAX_COUNT_PICTURES / COUNT_LINE_PICTURES))) / (MAX_COUNT_PICTURES / COUNT_LINE_PICTURES);
                if (control.GetType() == typeof(Label))
                {
                    heightCurentControl = heightIndention;
                }
                else
                {
                    heightCurentControl = (containerHeight - heightIndention - topPading) / COUNT_LINE_PICTURES;
                }
            }

            Rectangle controlBounds = control.Bounds;
            if (indexControl >= MAX_COUNT_PICTURES / COUNT_LINE_PICTURES)
            {
                if (control.GetType() == typeof(Label))
                {
                    controlBounds.Y = (containerlBounds.Height - ((int)containerlBounds.Height / 3))+ (int)(heightCurentControl + heightIndention);
                }
                else
                {
                    controlBounds.Y = (int)(heightCurentControl + heightIndention);
                }
                controlBounds.X = (int)((indexControl - MAX_COUNT_PICTURES / COUNT_LINE_PICTURES) * (widthCurentControl + widtIndention));
            }
            else
            {
                if (control.GetType() == typeof(Label))
                {
                    controlBounds.Y = (containerlBounds.Height - ((int)containerlBounds.Height / 3));
                }
                else
                {
                    controlBounds.Y = containerX;
                }
                controlBounds.X = (int)(indexControl * (widthCurentControl + widtIndention));
            }
            controlBounds.Width = (int)widthCurentControl;
            controlBounds.Height = (int)heightCurentControl;
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
                    curentNameLabel.Controls.Remove(nameTextBox);
                    curentNameLabel.Refresh();
                }
            }
        }

        private void setupLabel(Label curentLabel , int numLabel)
        {
            curentLabel.BringToFront();
            curentLabel.BackColor = Color.White;
            curentLabel.MouseMove += new MouseEventHandler(Control_MouseMove);
            curentLabel.MouseDown += new MouseEventHandler(nameImage_MouseDown);
            curentLabel.MouseUp += new MouseEventHandler(nameImage_MouseUp);
            curentLabel.Move += new EventHandler(nameImage_Move);
            curentLabel.ImageAlign = ContentAlignment.BottomCenter;
        }

        private void setupPicturesBox(PictureBox curentPictures)
        {
            curentPictures.MouseMove += new MouseEventHandler(Control_MouseMove);
            curentPictures.BackColor = Color.Red;
            curentPictures.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private PictureBox isCheckAreaEntering(Label curentLabel)
        {
            for (int i = 0; i < listPuzzleBox.Count; i++)
            {
                PuzzleBox puzzleBox = listPuzzleBox.ToArray()[i];
                PictureBox imagePuzzle = puzzleBox.pictures;
                Rectangle rectPic = imagePuzzle.Bounds;
                Rectangle rectLabel = curentLabel.Bounds;
                double areaX = rectPic.X + rectPic.Width;
                double areaY = rectPic.Y + rectPic.Height;
                if ((rectLabel.Y <= areaY && rectLabel.Y >= rectPic.Y) && (rectLabel.X <= areaX && rectLabel.X >= rectPic.X))
                {
                    return imagePuzzle;
                }
            }
            return null;
        }

        private void increasePic(PictureBox pic)
        {
            Rectangle rectNewPic = pic.Bounds;
            rectNewPic.Height += INCREASE_PICTURES;
            rectNewPic.Width += INCREASE_PICTURES;
            pic.Bounds = rectNewPic;
        }

        private void reducePic(PictureBox pic)
        {
            Rectangle rectNewPic = pic.Bounds;
            rectNewPic.Height -= INCREASE_PICTURES;
            rectNewPic.Width -= INCREASE_PICTURES;
            pic.Bounds = rectNewPic;
        }

        private void checkPictures(PictureBox images)
        {
            if (selectPic == null)
            {
                increasePic(images);
            }
            else
            {
                if (selectPic.Tag.ToString().CompareTo(images.Tag.ToString()) == 0)
                {
                    return;
                }
                else
                {
                    reducePic(selectPic);
                    increasePic(images);
                }
            }
        }

        private bool isValidateSelect()
        {
            if (selectListPuzzleBox.Count != listPuzzleBox.Count)
            {
                return false;
            }

            for (int i = 0; i < listPuzzleBox.Count; i++)
            {
                PuzzleBox puzleBox = listPuzzleBox.ToArray()[i];
                for (int j = 0; j < selectListPuzzleBox.Count; j++)
                {
                    PuzzleBox selectPuzzleBox = selectListPuzzleBox.ToArray()[j];
                    if (puzleBox.pictures.Tag.ToString().CompareTo(selectPuzzleBox.pictures.Tag.ToString()) == 0)
                    {
                        if (selectPuzzleBox.namePic.CompareTo(puzleBox.namePic) == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void addedPuzzleToLis(PuzzleBox puzleBox)
        {
            for (int i = 0; i < selectListPuzzleBox.Count; i++)
            {
                PuzzleBox selectPuzzleBox = selectListPuzzleBox.ToArray()[i];
                if (puzleBox.pictures.Tag.ToString().CompareTo(selectPuzzleBox.pictures.Tag.ToString()) == 0)
                {
                    selectPuzzleBox.namePic = puzleBox.namePic;
                    selectPuzzleBox.pictures = puzleBox.pictures;
                    selectPuzzleBox.tag = puzleBox.tag;
                    return;
                }
            }
            selectListPuzzleBox.Add(puzleBox);
        }

        private void clearForm()
        {
            
        }
 
        #endregion  

        
    }
   
}
