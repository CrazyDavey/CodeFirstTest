using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTest.EF;

namespace CodeFirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int emailTypeID = AddEmailType();
            Console.WriteLine(emailTypeID);
            Console.ReadLine();
        }

        private static int AddEmailType()
        {
            using (var context = new CFREEntities())
            {
                try
                {

                    var emailType = new EmailType() {Type = "Personal"};
                    context.EmailTypes.Add(emailType);
                    context.SaveChanges();
                    return emailType.EmailTypeID;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                    return 0;
                }
            }
        }
    }
}
