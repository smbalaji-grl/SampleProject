using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_SET
{
    internal class Measure
    {
        private List<double> speedInLists=new List<double>(); 
        private UserInput Inputs;
        public Measure(UserInput u1)
        {
            this.Inputs = u1;
        }
        public void measureSpeed()   // calculate the speed
        {
            double a;
            List<DataSet> d1 = this.Inputs.getUserDataList();

            
            foreach (DataSet d in d1)
            {
                a = d.getDistance()/(d.getTime()/60);
                speedInLists.Add(a);
            }
        }
        public List<double> getSpeedList()
        {
            return speedInLists;

        }
        public UserInput getUserInputs()
        {
            return this.Inputs;
        }


    }
}
