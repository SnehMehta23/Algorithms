using System;
using System.Collections.Generic;
using System.Text;

namespace TestingAlgorithms
{
    public class Sort
    {
        public void SSDouble(List<double> myDoubles)
        {
            double tempVariable = 0;

            for (int i = 0; i < myDoubles.Count; i++)
            {
                for (int n = i + 1; n < myDoubles.Count; n++)
                {
                    if (myDoubles[n] < myDoubles[i])
                    {
                        tempVariable = myDoubles[i];
                        myDoubles[i] = myDoubles[n];
                        myDoubles[n] = tempVariable;
                    }
                }
                Console.WriteLine(myDoubles[i]);
            }
            Console.ReadKey();
        }

        public void BubbleSortDoubles(List<double> myDoubles)
        {
            double temp = 0;

            for (int i = 0; i < myDoubles.Count; i++)
            {
                for (int j = i + 1; j < myDoubles.Count; j++)
                {
                    if (myDoubles[j] < myDoubles[i])
                    {
                        temp = myDoubles[j];
                        myDoubles[j] = myDoubles[i];
                        myDoubles[i] = temp;
                    }
                }
                Console.WriteLine(myDoubles[i]);
            }
            Console.ReadKey();
        }

        public void GuidBubbleSort(List<Guid> listGuids)
        {
            Guid temp;

            for (int i = 0; i < listGuids.Count; i++)
            {
                for (int j = i + 1; j < listGuids.Count; j++)
                {
                    if (listGuids[i].CompareTo(listGuids[j]) > 0)
                    {
                        temp = listGuids[j];
                        listGuids[j] = listGuids[i];
                        listGuids[i] = temp;
                    }
                }
                Console.WriteLine(listGuids[i]);
            }
            Console.ReadKey();
        }

        public void GuidSelectionSort(List<Guid> listGuids)
        {
            Guid temp;

            for (int i = 0; i < listGuids.Count; i++)
            {
                for (int j = i + 1; j < listGuids.Count; j++)
                {
                    if (listGuids[i].CompareTo(listGuids[j]) > 0)
                    {
                        temp = listGuids[i];
                        listGuids[i] = listGuids[j];
                        listGuids[j] = temp;
                    }
                }
                Console.WriteLine(listGuids[i]);
            }
            Console.ReadKey();
        }

    }
}

