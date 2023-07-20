using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace WindowsServices
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        ServiceProcessInstaller processInstaller;
        ServiceInstaller serviceInstaller;
        public Installer1()
        {
            processInstaller = new ServiceProcessInstaller();
            processInstaller.Account = ServiceAccount.LocalService;

            serviceInstaller = new ServiceInstaller();
            serviceInstaller.ServiceName = "[===== TEST SERVICE ======]";
            serviceInstaller.Description = "My First NT (Windows) Service!";
            serviceInstaller.StartType = ServiceStartMode.Automatic;

            base.Installers.Add(processInstaller);
            base.Installers.Add(serviceInstaller);
            //InitializeComponent();
        }
    }
}
