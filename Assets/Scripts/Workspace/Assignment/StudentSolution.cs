using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.Experimental.GraphView;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...
            // ...
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }   
            if (index == -1)
            {
                Console.WriteLine("Find not Found!");
            }

            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...
            // ...
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == target)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (row != -1 && col != -1)
                {
                    break;
                }
            }

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            // Your code here ...
            // ...
            int left = 0;
            int right = array.Length;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (index == -1)
            {
              Console.WriteLine("Find not Found!");
            }

            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int arrayLength = array.Length;
            int firstIndex = -1; 
            int lastIndex = arrayLength - 1;
            int nullIndex = -1;

            for (int i = 0; i < arrayLength; i++) // first index
            {
                if (array[i] == target)
                {
                    firstIndex = i;
                    break;
                }
                
            }
            for (int i = arrayLength - 1; i >= 0; i--) // last index
            {
                if (array[i] == target)
                {
                    lastIndex = i;
                    break;
                }
               

            }
            if (firstIndex == -1 && lastIndex == arrayLength - 1)
            {
                return new[] { nullIndex };
            }

            return new[] { firstIndex, lastIndex };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return -1;

            bool found = false;   // บอกว่าเจอค่าที่เข้าเงื่อนไขแล้วหรือยัง
            int max = -1;         // ค่าที่มากที่สุดที่ < target (ใช้จริงเมื่อ found == true)

            foreach (int value in array)
            {
                if (value < target && (!found || value > max))
                {
                    max = value;
                    found = true;
                }
            }

            return found ? max : -1;


        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            if (array == null || array.Length == 0 || min > max)
                return new int[0];

            List<int> result = new List<int>();

            foreach (int value in array)
            {
                if (value >= min && value <= max)
                    result.Add(value);
            }

            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
