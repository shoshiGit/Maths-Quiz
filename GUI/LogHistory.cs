using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace GUI
{
     internal class LogHistory
    {
       public static void TestHistory(int userId,int mark, DateTime testDate)
        {
            try
            {
                using(var db = new Entities1())
                {
                    MyHistory history = new MyHistory
                    {
                        UserId = userId,
                        Mark = mark,
                        TestDate = testDate
                    };
                    db.MyHistory.Add(history);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
