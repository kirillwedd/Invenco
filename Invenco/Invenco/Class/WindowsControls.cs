using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Invenco.Class
{
    static class WindowsControls 
    {
             
        public static void DeploymentMT(Window window)
        {
            

            if (window.WindowState == WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
            }
            else
            {
                window.WindowState = WindowState.Maximized;
            }

        }
        public static void Roll_Up_Mt(Window window)
        {
            window.WindowState = WindowState.Minimized;
        }

    }
}
