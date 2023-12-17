using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms_TreeBuild
{
    public class DataSort
    {
        public string path = ($"{Directory.GetCurrentDirectory()}\\Files\\scores.txt");
        public string? FilePath;

        public int[] SetUpBubbleSort(int[] nums)
        {

            int ArrayLength = nums.Length;

            for (int i = 0; i < ArrayLength - 1; i++)
            {
                for (int z = 0; z < ArrayLength - i - 1; z++)
                {
                    if (nums[z] > nums[z + 1])
                    {
                        int temp = nums[z];
                        nums[z] = nums[z + 1];
                        nums[z + 1] = temp;
                    }
                }
            }
            return nums;

        }

        public int[] ReadDataFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] dataArray = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                dataArray[i] = int.Parse(lines[i]);
            }

            return SetUpBubbleSort(dataArray);
        }

        public string[] ConvertIntArrayToStringArray(int[] intArray)
        {
            // Use LINQ to convert each int to string
            // Alternatively, you can use a loop to convert each element
            return Array.ConvertAll(intArray, x => x.ToString());
        }


    }
}
