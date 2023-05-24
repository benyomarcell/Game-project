using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Read the file
            string[] names = new string[12];
            string[] descriptions = new string[12];
            int[] armorValues = new int[12];
            int[] toughnessValues = new int[12];

            using (StreamReader reader = new StreamReader("ITárgyak.csv"))
            {
                // Skip the header lines
                reader.ReadLine();
                reader.ReadLine();

                // Read the remaining lines (names)
                int i = 0;
                while (i < 12)
                {
                    string line = reader.ReadLine();

                    // Check if line is null
                    if (line == null)
                    {
                        break;
                    }

                    string[] parts = line.Split('\t');

                    names[i] = parts[0];

                    if (parts.Length >= 2)
                    {
                        descriptions[i] = parts[1];
                    }
                    

                    if (parts.Length >= 3 && int.TryParse(parts[2], out int armorValue))
                    {
                        armorValues[i] = armorValue;
                    }
                  

                    if (parts.Length >= 4 && int.TryParse(parts[3], out int toughnessValue))
                    {
                        toughnessValues[i] = toughnessValue;
                    }
                    

                    i++;
                }
            }

            // Print the data
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(names[i] + ": " + descriptions[i] + " (" + armorValues[i] + ", " + toughnessValues[i] + ")");
            }




            Console.ReadKey();
        }
    }
}
