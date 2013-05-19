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
                                     RootControllerDelegate
    {
        CreateTestViewController    createTestViewController;
        CreateTaskViewController    createTaskViewController;
        PresentTaskViewController   presentTaskViewController;
        PresentTestViewController   presentTestViewController;
        ChangeTestViewController    changeTestViewContrroller;
        ChangeTaskViewController    changeTaskViewController;
    
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
            createTestViewController.FindForm().Close();
            presentTaskViewController = new PresentTaskViewController(this);
            presentTaskViewController.setupTask(taskSetup);
            presentTaskViewController.FindForm().Text = taskSetup.nameTask;
            presentTaskViewController.ShowDialog();
        }

        #endregion

        #region CreateTestDelegate

        void CreateTestDelegate.showPresentTestController(string nameTest)
        {
            presentTestViewController = new PresentTestViewController(this);
            presentTestViewController.FindForm().Text = nameTest;
            presentTestViewController.ShowDialog();
        }

        #endregion

        #region  PresentTaskDelegate

        public void showPresentTask()
        {
            
        }

        public void bachController()
        {
            presentTaskViewController.FindForm().Close();
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
            presentTestViewController.NameTest = testName;
            presentTestViewController.FindForm().Text = testName;
            presentTestViewController.ShowDialog();
        }
        
        #endregion


        #region - ChangeTaskDelegate

        public void showPresentTaskController()
        {
            
        }

        #endregion

        #region - Utils



        #endregion



       
    }
}
