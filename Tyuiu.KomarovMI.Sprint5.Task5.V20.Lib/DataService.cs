using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovMI.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {

            
            double res = 0;
            using(StreamReader reader=new StreamReader(path))
            {

                string line;

               
                int sum = 0; 
                int count = 0; 
                double sumDouble = 0; 
                int countDouble = 0; 
                while ((line=reader.ReadLine()) != null)
                {
                    string[] lines = File.ReadAllLines(line);
                                 
                        if (int.TryParse(line, out int number)) 
                        {
                            if (number >= -10 && number <= 10) 
                            {
                                sum += number;
                                count++;
                            }
                        }
                        else if (double.TryParse(line, out double doubleNumber)) 
                        {
                            if (doubleNumber >= -10 && doubleNumber <= 10) 
                            {
                                sumDouble += doubleNumber;
                                countDouble++;
                            }
                        }
                     
                    

                    if (count > 0)
                    {
                        res = (double)sum / count;
                    }


                }

            }

            return res;
            
        }
    }
}
