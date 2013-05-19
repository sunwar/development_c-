using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Data.Linq;
using System.Xml.Linq;
using  logicPuzzles.DataBase;

namespace logicPuzzles
{
    class DataBaseModel
    {
        public static string _connectString;
        private OleDbConnection connection;
        private static DataBaseModel objectBase;
        private DataClasses1DataContext context;

        private pic _pic;
        private links _links;
        private task _task;
        private test _test;
        private comp _comp;

        private List<pic> _containerPics;
        private List<links> _containerLinks;
        private List<string> _containerNamePics;

       // private pic[] _containerPics;
       // private links[] _containerLinks;
      //  private string[] _containerNamePics;
    
        public static DataBaseModel getInstance()
        {
            if (objectBase == null)
            {
                objectBase = new DataBaseModel(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\inputFile\compare.accdb");
            }
            return objectBase;
        }

         private DataBaseModel(string connectString)
        {
            _connectString = connectString;
            connection = new OleDbConnection(_connectString);
            context = new DataClasses1DataContext(connection);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Соединение не установлено!");
            }
        }

         public DataClasses1DataContext getContext()
         {
             return context;
         }

         private int getTestId()
         {
             System.Collections.IEnumerator enumerator = context.test.GetEnumerator();
             int maxId = 0;
             while (enumerator.MoveNext())
             {
                 logicPuzzles.DataBase.test testObjectModel = (logicPuzzles.DataBase.test)enumerator.Current;
                 if (testObjectModel.nid > maxId)
                 {
                     maxId = testObjectModel.nid;
                 }
             }
             int newId = ++maxId;
             return newId;
         }

         private int getPicId()
         {
             System.Collections.IEnumerator enumerator = context.pic.GetEnumerator();
             int maxId = 0;
             while (enumerator.MoveNext())
             {
                 logicPuzzles.DataBase.pic picObjectModel = (logicPuzzles.DataBase.pic)enumerator.Current;
                 if (picObjectModel.nid > maxId)
                 {
                     maxId = picObjectModel.nid;
                 }
             }
             int newId = ++maxId;
             return newId;
         }

         private int getTaskId()
         {
             System.Collections.IEnumerator enumerator = context.task.GetEnumerator();
             int maxId = 0;
             while (enumerator.MoveNext())
             {
                 logicPuzzles.DataBase.task taskObjectModel = (logicPuzzles.DataBase.task)enumerator.Current;
                 if (taskObjectModel.nid > maxId)
                 {
                     maxId = taskObjectModel.nid;
                 }
             }
             int newId = ++maxId;
             return newId;
         }

         private int getLinkId()
         {
             System.Collections.IEnumerator enumerator = context.links.GetEnumerator();
             int maxId = 0;
             while (enumerator.MoveNext())
             {
                 logicPuzzles.DataBase.links linksObjectModel = (logicPuzzles.DataBase.links)enumerator.Current;
                 if (linksObjectModel.nid > maxId)
                 {
                     maxId = linksObjectModel.nid;
                 }
             }
             int newId = ++maxId;
             return newId;
         }

        public void setNamePics(string[] containerNamePics )
        {
            for (int i = 0; i < containerNamePics.Length; i++)
            {
                _containerNamePics.Add(containerNamePics[i]);
            }
        }

         public void createTest(String testName)
         {
             _test = new test();
             _test.tname = testName;
             _test.nid = getTestId();
              context.test.InsertOnSubmit(_test);
         }

         public void deleteTest(string testName)
         {
             System.Collections.IEnumerator enumeratorTest = context.test.GetEnumerator();
             System.Collections.IEnumerator enumeratorTask = context.task.GetEnumerator();
             System.Collections.IEnumerator enumeratorLinks = context.links.GetEnumerator();
            
             while (enumeratorTask.MoveNext())
             {
                 task curentTask = (task)enumeratorTask.Current;
                 if (curentTask.test.tname.CompareTo(testName) == 0)
                 {
                     while (enumeratorLinks.MoveNext())
                     {
                         links curentLinks = (links)enumeratorLinks.Current;
                         if (curentLinks.task.tname.CompareTo(curentTask.tname) == 0)
                         {
                             context.links.DeleteOnSubmit(curentLinks);
                         }
                     }
                     context.task.DeleteOnSubmit(curentTask);
                 }
             }

             while (enumeratorTest.MoveNext())
             {
                 test curentTest = (test)enumeratorTest.Current;
                  if (curentTest.tname.CompareTo(testName) == 0)
                  {
                      context.test.DeleteOnSubmit(curentTest);
                  }
             }
             context.SubmitChanges();
         }

         public void deleteTask(string nameTask, string nameTest)
         {
             System.Collections.IEnumerator enumeratorTask = context.task.GetEnumerator();
             System.Collections.IEnumerator enumeratorLinks = context.links.GetEnumerator();

             try
             {

                 while (enumeratorTask.MoveNext())
                 {
                     task curentTask = (task)enumeratorTask.Current;
                     if (curentTask.test.tname.CompareTo(_test.tname) == 0)
                     {
                         while (enumeratorLinks.MoveNext())
                         {
                             links curentLinks = (links)enumeratorLinks.Current;
                             if (curentLinks.task.tname.CompareTo(curentTask.tname) == 0)
                             {
                                 context.links.DeleteOnSubmit(curentLinks);
                                 context.SubmitChanges();
                             }
                         }
                         context.task.DeleteOnSubmit(curentTask);
                         context.SubmitChanges();
                     }
                 }
             }
             catch (Exception)
             { 
             
             }
             
         }

         public void openTestChange(string testName)
         {
             System.Collections.IEnumerator enumeratorTest = context.test.GetEnumerator();
             
             
             while (enumeratorTest.MoveNext())
             {
                 test curentTest = (test)enumeratorTest.Current;
                 if (curentTest.tname.CompareTo(testName) == 0)
                 {
                     _test = curentTest;
                 }
             }
         }

         public void changeTask()
         {
             System.Collections.IEnumerator enumeratorLinks = context.links.GetEnumerator();
             if (_task.test.tname.CompareTo(_test.tname) == 0)
             {
                 while (enumeratorLinks.MoveNext())
                 {
                     links curentLinks = (links)enumeratorLinks.Current;
                     if (curentLinks.task.tname.CompareTo(_task.tname) == 0)
                     {
                         context.links.DeleteOnSubmit(curentLinks);
                         context.SubmitChanges();
                     }
                 }
             }

             for (int i = 0; i < _containerPics.Count; i++)
             {
                 _containerPics.ToArray()[i].nid = getPicId() + i;
                 _containerLinks.ToArray()[i].npic = _containerPics[i].nid;
                 _containerLinks.ToArray()[i].tname = _containerNamePics[i];
                 _containerLinks.ToArray()[i].nid = getLinkId() + i;
                 _containerLinks.ToArray()[i].ntask = _task.nid;
             }

             for (int i = 0; i < _containerPics.Count; i++)
             {
                 context.pic.InsertOnSubmit(_containerPics.ToArray()[i]);
                 context.SubmitChanges();
             }

             for (int i = 0; i < _containerPics.Count; i++)
             {
                 context.links.InsertOnSubmit(_containerLinks.ToArray()[i]);
                 context.SubmitChanges();
             }
         
         }

         public void openTaskChange(string taskName)
         {
             System.Collections.IEnumerator enumeratorTask = context.task.GetEnumerator();
             System.Collections.IEnumerator enumeratorLinks = context.links.GetEnumerator();
             List<links> listLinks = new List<links>();
             while (enumeratorTask.MoveNext())
             {
                 task curentTask = (task)enumeratorTask.Current;
                 if (curentTask.tname.CompareTo(taskName) == 0)
                 {
                     _task = curentTask;
                     while (enumeratorLinks.MoveNext())
                     {
                         links curentLinks = (links)enumeratorLinks.Current;
                         if (curentLinks.task.tname.CompareTo(curentTask.tname) == 0)
                         {
                             listLinks.Add(curentLinks);
                         }
                     }
                 }
             }
             initContainers(listLinks.Count / 2);
         }

         public void initContainers(int countObject)
         {
             _containerLinks = new List<links>(countObject);
             _containerPics = new List<pic>(countObject);
             _containerNamePics = new List<string>(countObject);
             for (int i = 0; i < countObject; i++)
             {
                 _containerLinks.Add (new links());
                 _containerPics.Add( new pic());
             }
         }

        
         public void createTask(int countObject, string nameTask)
         {
             initContainers(countObject);
             _task = new task();
             _task.ntest = _test.nid;
             _task.tname = nameTask;
             _task.nid = getTaskId();
              context.task.InsertOnSubmit(_task);
         }

         public void loadPic(string path, int indexPic)
         {
             //Bitmap curentPic = new Bitmap(path);
             byte[] bytes = System.IO.File.ReadAllBytes(path);
             _containerPics.ToArray()[indexPic].opic = bytes;
         }

         public void loadPicturesBox(PictureBox pic, int indexPic)
         {
            Bitmap bitmap = new Bitmap(pic.Image);
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            pic.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] arrayBytesPic = memoryStream.ToArray();
             if(indexPic<=_containerPics.Count)
            _containerPics.ToArray()[indexPic].opic = arrayBytesPic; 
         }

         public void linksPic()
         {
             for (int i = 0; i < _containerPics.Count; i++)
             {
                 _containerPics.ToArray()[i].nid = getPicId() + i;
                 _containerLinks.ToArray()[i].npic = _containerPics[i].nid;
                 _containerLinks.ToArray()[i].tname = _containerNamePics[i];
                 _containerLinks.ToArray()[i].nid = getLinkId() + i;
                 _containerLinks.ToArray()[i].ntask = _task.nid;
             }
         }

         public void saveTask()
         {
             try
             {      
                 context.SubmitChanges();
                 for (int i = 0; i < _containerPics.Count; i++)
                 {
                     context.pic.InsertOnSubmit(_containerPics.ToArray()[i]);
                     context.SubmitChanges();
                 }

                 for (int i = 0; i < _containerPics.Count; i++)
                 {
                     context.links.InsertOnSubmit(_containerLinks.ToArray()[i]);
                     context.SubmitChanges();
                 }
                 
             }
             catch (Exception)
             {
                
             }
         }

       
    }
}
