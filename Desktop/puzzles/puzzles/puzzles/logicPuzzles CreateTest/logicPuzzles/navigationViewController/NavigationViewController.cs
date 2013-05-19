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
    class NavigationViewController : CreateTaskDelegate, 
                                     CreateTestDelegate, 
                                     PresentTaskDelegate,
                                     PresentTestDelegate,
                                     ChangeTestDelegate,
                                     ChangeTaskDekegate,
                                     PresentChangeTaskDelegate,
                                     RootControllerDelegate
    {
        CreateTestViewController        createTestViewController;
        CreateTaskViewController        createTaskViewController;
        PresentNewTaskViewController    presentNewTaskViewController;
        PresentTestViewController       presentTestViewController;
        ChangeTestViewController        changeTestViewContrroller;
        ChangeTaskViewController        changeTaskViewController;
        PresentChangeTaskViewController presentChangeTaskController;
    
        private NavigationViewController()
        {
        }

        private static NavigationViewController navigationController;
        public static NavigationViewController getInstance()
        {
            if (navigationController == null)
            {
                navigationController = new NavigationViewController();
            }
            return navigationController;
        }

       
        #region  CreateTaskDelegate

        public void showPresentTaskController(TaskSetup taskSetup)
        {
            if(createTestViewController != null)
            createTestViewController.FindForm().Close();
            presentNewTaskViewController = new PresentNewTaskViewController(this);
            presentNewTaskViewController.setupTask(taskSetup);
            presentNewTaskViewController.FindForm().Text = taskSetup.nameTask;
            presentNewTaskViewController.ShowDialog();
        }

        #endregion

        #region CreateTestDelegate

        void CreateTestDelegate.showPresentTestController(string nameTest)
        {
            presentTestViewController = new PresentTestViewController(this);
            presentTestViewController.setupTask(false);
            presentTestViewController.FindForm().Text = nameTest;
            presentTestViewController.ShowDialog();
        }

        #endregion

        #region  PresentTaskDelegate

        public void showPresentTask()
        {
            
        }

        public void backController()
        {
            presentNewTaskViewController.FindForm().Close();
            createTaskViewController.FindForm().Close();
        }

        #endregion

        #region PresentTestDelegate

        public void showCreateTask()
        {
            createTaskViewController = new CreateTaskViewController(this);
            createTaskViewController.ShowDialog(); 
        }

        public void showChangeTask(string nameTest)
        {
            changeTaskViewController = new ChangeTaskViewController(this);
            changeTaskViewController.NameTest = nameTest;
            changeTaskViewController.selectTask(nameTest);
            changeTaskViewController.ShowDialog();
        }

        #endregion

        #region  RootControllerDelegate

        public void showCreateController()
        {
            createTestViewController = new CreateTestViewController(this);
            createTestViewController.ShowDialog();
        }

        public void showChangeTestController()
        {
            changeTestViewContrroller = new ChangeTestViewController(this);
            changeTestViewContrroller.openTest();
            changeTestViewContrroller.ShowDialog();
        }

        #endregion

        #region ChangeTestDelegate

        void ChangeTestDelegate.showPresentTestController(string testName)
        {
            presentTestViewController = new PresentTestViewController(this);
            presentTestViewController.setupTask(true);
            presentTestViewController.NameTest = testName;
            presentTestViewController.FindForm().Text = testName;
            presentTestViewController.ShowDialog();
        }
        
        #endregion


        #region - ChangeTaskDelegate

        public void showPresentChangeTaskController(TaskSetup taskSetup)
        {
            presentChangeTaskController = new PresentChangeTaskViewController(this);
            presentChangeTaskController.setupTask(taskSetup);
            presentChangeTaskController.FindForm().Text = taskSetup.nameTask;
            presentChangeTaskController.ShowDialog();
        }

        #endregion

        #region - PresentChangeTaskDelegate

        public void showPresentChangeTask()
        {

        }

        public void backChangeController()
        {
            presentChangeTaskController.FindForm().Close();
        }

        #endregion

        #region - Utils



        #endregion



       
    }
}
