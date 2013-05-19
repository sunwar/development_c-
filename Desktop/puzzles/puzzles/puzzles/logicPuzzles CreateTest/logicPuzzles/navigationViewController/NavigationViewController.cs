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
            presentTaskViewController.setupTask(taskSetup);
            closeForm(createTaskViewController.FindForm());
            presentTaskViewController.FindForm().Text = taskSetup.nameTask;
            presentTaskViewController.ShowDialog();
        }

        #endregion

        #region CreateTestDelegate

        void CreateTestDelegate.showPresentTestController(string nameTest)
        {
            closeForm(createTestViewController.FindForm());
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
            closeForm(presentController.FindForm());
        }

        #endregion

        #region PresentTestDelegate

        public void showCreateTask()
        {
            closeForm(presentTestViewController.FindForm());
            createTaskViewController.ShowDialog(); 
        }

        #endregion

        #region  RootControllerDelegate

        public void showCreateController()
        {
            createTestViewController.ShowDialog();
        }

        #endregion

        #region - Utils

        private void closeForm(Form form)
        {
            form.Visible = false;
            form.Close();
        }

        #endregion



      
    }
}
