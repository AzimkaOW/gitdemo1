using System;

namespace _9Unit
{
    class program 
    {
        static void Main(string[] args)
        {
            //Customer a = new Customer();
            //a.ContactPhone = "12341234";
            //a.Revenue = "10000";
            //a.Name = "Jake";
            //Console.WriteLine(a.CustomerRecord());
        }
        public class Customer
        {
            public string Name = null;
            public string Revenue = null;
            public string ContactPhone = null;
            public string CustomerRecord()
            {
                string str = "CustomerRecord:";
                if (Name != null)
                {
                    str = str + " " + Name;
                    if (Revenue != null || ContactPhone != null)
                    {
                        str = str + ",";
                    }
                }
                if (Revenue != null)
                {
                    str = str + " " + Revenue;
                    if (ContactPhone != null)
                    {
                        str = str + ",";
                    }
                }
                if (ContactPhone != null)
                {
                    str = str + " " +ContactPhone;
                }

                return str;
            }
            public void FormattingRecord()
            {
                Name = null;
                Revenue = null;
                ContactPhone = null;
            }
        }
    
    }
}
