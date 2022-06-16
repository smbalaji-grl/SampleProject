using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DATA_SET
{
    internal class ShowResults
    {
        private Measure m1;
        public ShowResults(Measure m)
        {
            this.m1 = m;
        }
        public void method1()
        {
            try //To handle file read/write exceptions
            {
                string workingDir = Environment.CurrentDirectory; // To get Current Working Directory
                string outputFileLoc = Directory.GetParent(workingDir).Parent.Parent.FullName + @"\output.csv"; //To navigate to the output file path

                List<DataSet> data = this.m1.getUserInputs().getUserDataList();
                StringBuilder sb = new StringBuilder();
                List<double> speed = this.m1.getSpeedList();
                int i = 0;
                foreach (DataSet ds in data)
                {
                    sb.Append(ds.getDistance().ToString() + "km" + "," + ds.getTime().ToString() + "min" + "," + speed[i] + "km/hr" + "\n");
                    i++;
                }
                string info = sb.ToString();
                File.WriteAllText(outputFileLoc, "Distance" + "," + "Time" + "," + "Speed" + "\n" + info);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
