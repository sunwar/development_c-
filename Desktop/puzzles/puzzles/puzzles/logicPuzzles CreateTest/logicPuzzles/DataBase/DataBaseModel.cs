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
        private pic[] _containerPics;
        private links[] _containerLinks;
        private string[] _containerNamePics;
    
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
            _containerNamePics = containerNamePics;
        }

         public void createTest(String testName)
         {
             _test = new test();
             _test.tname = testName;
             _test.nid = getTestId();
         }

         public void initContainers(int countObject)
         {
             _containerLinks = new links[countObject];
             _containerPics = new pic[countObject];
             for (int i = 0; i < countObject; i++)
             {
                 _containerLinks[i] = new links();
                 _containerPics[i] = new pic();
             }
         }

         public void createTask(int countObject, string nameTask)
         {
             initContainers(countObject);
             _task = new task();
             _task.ntest = _test.nid;
             _task.tname = nameTask;
             _task.nid = getTaskId();
         }

         public void loadPic(string path, int indexPic)
         {
             //Bitmap curentPic = new Bitmap(path);
             byte[] bytes = System.IO.File.ReadAllBytes(path);
             _containerPics[indexPic - 1].opic = bytes;
         }

         public void linksPic()
         {
             for (int i = 0; i < _containerPics.Length; i++)
             {
                 _containerPics[i].nid = getPicId() + i;
                 _containerLinks[i].npic = _containerPics[i].nid;
                 _containerLinks[i].tname = _containerNamePics[i];
                 _containerLinks[i].nid = getLinkId() + i;
                 _containerLinks[i].ntask = _task.nid;
             }
         }

         public void saveTask()
         {
             context.test.InsertOnSubmit(_test);
             context.task.InsertOnSubmit(_task);
             context.SubmitChanges();
             for (int i = 0; i < _containerPics.Length; i++)
             {
                 context.pic.InsertOnSubmit(_containerPics[i]);
                 context.SubmitChanges();
             }

             for (int i = 0; i < _containerPics.Length; i++)
             {
                 context.links.InsertOnSubmit(_containerLinks[i]);
                 context.SubmitChanges();
             } 
         }
       
    }
}
