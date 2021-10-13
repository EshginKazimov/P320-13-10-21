using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Message
    {
        public string Subject { get; set; }

        public string Text { get; set; }

        protected internal string Attachment { get; set; }

        private protected string Test { get; set; }

        protected int Demo { get; set; }
    }

    public class Sms : Message
    {
        public Sms()
        {
            Attachment = "";
            Test = "";
            Demo = 0;
        }
    }

    public class Test2
    {
        public Test2()
        {
            Message m1 = new Message();
            m1.Attachment = "";
            m1.Test = "";
            m1.Demo = 0;
        }
    }
}
