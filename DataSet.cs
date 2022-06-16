using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_SET
{
    internal class DataSet
    {
        private double distance;
        private double time;

        public DataSet(double d1, double t1)
        {
            distance = d1;
            time = t1;
        }
        public double getDistance() 
        {
            return distance;
        }
        public double getTime()
        {
            return time;
        }
    }
}
