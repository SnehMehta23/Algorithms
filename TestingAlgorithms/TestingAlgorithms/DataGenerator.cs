using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestingAlgorithms
{
    public class DataGenerator
    {
        public List<Guid> myGuids;
        public List<double> myDoubles;

        public DataGenerator()
        {
            //Creates an empty list of Guid type
            myGuids = new List<Guid>();
            // Creates an empty lsit of Double type
            myDoubles = new List<double>();

            Random random = new Random();
            

            // Generates 1 million of each type (double and guid)
            for (int i = 0; i < 1000000; i++)
            {
                // Gets a random Guid
                myGuids.Add(Guid.NewGuid());

            }

            for (int i = 0; i < myGuids.Count; i++)
            {
                myDoubles.Add(random.NextDouble());
            }

            //Create txt document--------------------------------------------------------------
            string filePath = Directory.GetCurrentDirectory();
            // takes the current directory that the project is in, and creates a txt file
            filePath += @"\DataText.txt";

            StreamWriter sw = new StreamWriter(filePath);

            for (int i = 0; i < myGuids.Count; i++)
            {
                sw.Write("{0}. {1}, {2}\n", i, myGuids[i], myDoubles[i]);
            }
        }
    }
}
