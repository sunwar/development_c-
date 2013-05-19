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
                                     RootControllerDelegate
    {
        CreateTestViewController createTestViewController;
        CreateTaskViewController createTaskViewController;
        PresentTaskViewController presentTaskViewController;
        PresentTestViewController presentTestViewController;
    
        private NavigationViewController()
        {
        }

        private static NavigationViewController navigationController;
        public static NavigationViewController getInstance()
        {
            if (navigationController == null)
            {
                navigationController = new NavigationViewController();
                navigationController.init();
            }
            return navigationController;
        }

        private void init()
        {
            createTaskViewController = new CreateTaskViewController(navigationController);
            createTestViewController = new CreateTestViewController(navigationController);
            presentTaskViewController = new PresentTaskViewController(navigationController);
            presentTestViewController = new PresentTestViewController(navigationController);
        }


        #region  CreateTaskDelegate

        public void showPresentTaskController(TaskSetup taskSetup)
        {
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

        public void bachController(PresentTaskViewController presentController)
        {
            
        }

        #endregion

        #region PresentTestDelegate

        public void showCreateTask()
        {
            createTaskViewController = new CreateTaskViewController(this);
            createTaskViewController.ShowDialog(); 
        }

        #endregion

        #region  RootControllerDelegate

        public void showCreateController()
        {
            createTestViewController = new CreateTestViewController(this);
            createTestViewController.ShowDialog();
        }

        #endregion

        #region - Utils

  

        #endregion



      
    }
}
