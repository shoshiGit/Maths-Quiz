using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;


namespace GUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Students newS = null;
            Console.Write("Enter usename: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.WriteLine();

            try
            {
                newS = Class1.Login(username, password);
                if (newS != null)
                {
                    int mark = 0;
                    Console.WriteLine("Hello " + username + "! Lets Begin");
                    try
                    {
                        foreach (Question_Ans1 q in Class1.Question1())
                        {
                            Console.WriteLine(q.Question);
                            string ans = Console.ReadLine();
                            int ans2 = 0;
                            int.TryParse(ans, out ans2);
                            if (ans2 == q.Answer)
                            {
                                mark += q.Percentage.HasValue ? q.Percentage.Value : 0;
                            }
                        }
                        foreach (Multiple_Choice_Q mq in Class1.multiple_Choice_Qs())
                        {
                            Console.WriteLine(mq.Question);
                            List<Multiple_Choice_A> americanAnswers = mq.Multiple_Choice_A.OrderBy(x => Guid.NewGuid()).ToList();
                            for (int i = 0; i < americanAnswers.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + americanAnswers[i].Answer);
                            }

                            string ans = Console.ReadLine();
                            int userAns;
                            int.TryParse(ans, out userAns);

                            if (userAns >= 1 && userAns <= americanAnswers.Count)
                            {
                                if (americanAnswers[userAns - 1].Answer == userAns)
                                {
                                    mark += mq.Percent.HasValue ? mq.Percent.Value : 0;
                                }

                            }
                            Console.WriteLine();

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("Your final mark is " + mark);
                    LogHistory.TestHistory(newS.Student_Id, mark, DateTime.Now);
                }
                else
                {
                    Console.WriteLine(username + "no such user");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
