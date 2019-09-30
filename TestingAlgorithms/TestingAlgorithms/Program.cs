using System;

namespace TestingAlgorithms
{
    /// <Sources>
    /// Selection Sort Resources
        //https://stackoverflow.com/questions/40074840/reading-a-csv-file-into-a-array
        //https://www.youtube.com/watch?v=YPGzfDN8-SA&t=720s


        //Bubble Sort Resources
        //https://www.youtube.com/watch?v=pL46lCCnUUI
        //https://www.youtube.com/watch?v=YPGzfDN8-SA&t=720s
        //https://www.youtube.com/watch?v=UvBu9wKgBvE&t=693s

    /// </Sources>
    public class Program
    {
        static void Main(string[] args)
        {
            DataGenerator test = new DataGenerator();

            //Uncomment when testing if doubles are being sorted using Selection Sort
            Sort s = new Sort();
            s.SSDouble(test.myDoubles);

            //Uncomment when testing if doubles are being sorted using Bubble Sort
            //Sort b = new Sort();
            //b.BubbleSortDoubles(test.myDoubles);

            //Uncomment when testing if Guids are being sorted using Bubble Sort
            //Sort c = new Sort();
            //c.GuidBubbleSort(test.myGuids);

            //Uncomment when testing if Guids are being sorted using Selection Sort
            //Sort d = new Sort();
            //d.GuidSelectionSort(test.myGuids);

            Console.ReadKey();
        }
    }
}
