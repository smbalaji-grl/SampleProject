using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_SET
{
    internal class UserInput
    {
        private List<DataSet> dataSets = new List<DataSet>();
        public void getUserData() //get data from user & set in the list
        {
            string answer;
            int i = 0, dis, spd;
            while (i < 10)
            {
                Console.WriteLine("Enter Distance in km:");
                dis = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter time in minutes:");
                spd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("do you want to add more input:reply with Y or N");
                answer = Console.ReadLine().ToUpper();
                dataSets.Add(new DataSet(dis, spd));
                i++;
                if (answer == "N")
                {
                    break;
                }
            }
        }
        public List<DataSet> getUserDataList()
        {
            return dataSets;

        }

    }
}
