using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SendMail
{
    class MyTimer
    {
        Paths paths = new Paths();
        public void StartTimer(int dueTime)
        {
            System.Threading.Timer t = new System.Threading.Timer(new TimerCallback(TimerProc));
            t.Change(dueTime, 5000);
        }

        private void TimerProc(object state)
        {
            // The state object is the Timer object.
            //System.Threading.Timer t = (System.Threading.Timer)state;
            //t.Dispose();
            //MessageBox.Show(paths.NoEmptyShow());
            paths.NoEmptyShow();

        }
    }
}
