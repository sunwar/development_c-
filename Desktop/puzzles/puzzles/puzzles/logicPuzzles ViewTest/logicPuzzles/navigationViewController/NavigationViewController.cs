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
    class NavigationViewController : OpenTaskDelegate, 
                                     OpenTestDelegate, 
                                     PresentTaskDelegate,
                                     PresentTestDelegate,
                                     RootControllerDelegate
    {
        OpenTestViewController openTestViewController;
        OpenTaskViewController openTaskViewController;
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
            openTaskViewController = new OpenTaskViewController(navigationController);
            openTestViewController = new OpenTestViewController(navigationController);
            presentTaskViewController = new PresentTaskViewController(navigationController);
            presentTestViewController = new PresentTestViewController(navigationController);
        }


        #region  PresentTaskDelegate

        public void showPresentTaskController(TaskSetup taskSetup)
        {
            presentTaskViewController = new PresentTaskViewController(this);
            presentTaskViewController.setupTask(taskSetup);  
            presentTaskViewController.FindForm().Text = taskSetup.nameTask;
            presentTaskViewController.ShowDialog();
        }

        #endregion

        #region OpenTestDelegate

        void OpenTestDelegate.showPresentTestController(string nameTest)
        {
            presentTestViewController = new PresentTestViewController(this);
            presentTestViewController.NameTest = nameTest;
            presentTestViewController.FindForm().Text = nameTest;
            presentTestViewController.ShowDialog();
        }

        #endregion

        #region  PresentTaskDelegate

      
        #endregion

        #region PresentTestDelegate

        public void showOpenTask(string nameTest)
        {
            openTaskViewController = new OpenTaskViewController(this);
            openTaskViewController.selectTask(nameTest);
            openTaskViewController.ShowDialog();
        }

        #endregion

        #region  RootControllerDelegate

        public void showCreateController()
        {
            openTestViewController.selectTest();
            openTestViewController.ShowDialog();
        }

        #endregion

        #region - Utils

       

        #endregion


        #region PresentTaskDelegate

        public void showPresentTask()
        {
            
        }

        #endregion
    }
}
