using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Recuperacion
{
    class SystemSupportMail: MasterMailServer
    {
        public SystemSupportMail() 
        {
            senderMail = "yoangel1221@gmail.com";
            password = "zrbhfhzyltdtodkb";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }

        
    }
}
