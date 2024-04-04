using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class1
    {
        public static List<Question_Ans1> Question1()
        {
            try
            {
                using (Entities1 db = new Entities1())
                {
                    var lst = db.Question_Ans1.Where(x => x.Percentage == 6).OrderBy(x => Guid.NewGuid()).Take(5).ToList();
                    var lst2 = db.Question_Ans1.Where(x => x.Percentage == 10).OrderBy(x => Guid.NewGuid()).Take(4).ToList();
                    lst.AddRange(lst2);
                    return lst.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Multiple_Choice_Q> multiple_Choice_Qs()
        {
            try
            {
                using (Entities1 db = new Entities1())
                {
                    var lst = db.Multiple_Choice_Q.Include("Multiple_Choice_A").Where(x => x.Percent == 5).OrderBy(x => Guid.NewGuid()).Take(6);

                    return lst.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Students Login(string username, string password)
        {
            try
            {
                using (Entities1 db = new Entities1())
                {
                    var user = db.Students.FirstOrDefault(u => u.Student_name == username && u.Password == password);

                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
