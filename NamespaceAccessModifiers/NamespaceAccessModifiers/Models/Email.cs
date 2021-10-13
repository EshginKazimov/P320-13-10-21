using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceAccessModifiers.Models
{
    public class Email : Message
    {
        public Email()
        {
            Subject = "";
            Text = "";
            Attachment = "";
            //Test = "";
            Demo = 0;
        }
    }
}
