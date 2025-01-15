using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TwoSum(new int[] { 2, 7, 11, 9 }, 9));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public string TwoSum(int[] nums, int target)
    {
        int index1 = -1;
        int index2 = -1;
        for (int i = 0, j = 1; i < nums.Length; i++, j++)
        {
            if (nums[i] + nums[j] == target)
            {
                index1 = i;
                index2 = j;
                break;
            }
        }
        return "[" + index1 + " , " + index2 + "]";
    }
}
// public class Solution
// {
//     public int[] TwoSum(int[] nums, int target)
//     {
//         int[] result = new int[2];
//         for (int i = 0, j = 1; i < nums.Length; i++, j++)
//         {
//             if (nums[i] + nums[j] == target)
//             {
//                 result[0] = i;
//                 result[1] = j;
//                 break;
//             }
//         }
//         return result;
//     }
//     public static void Main()
//     {
//         int[] nums = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
//         Console.WriteLine("[" + nums[0] + " , " + nums[1] + "]");
//         int[] nums1 = TwoSum(new int[] { 3, 2, 4 }, 6);
//         Console.WriteLine("[" + nums1[0] + " , " + nums1[1] + "]");
//         int[] nums2 = TwoSum(new int[] { 3, 3 }, 6);
//         Console.WriteLine("[" + nums2[0] + " , " + nums2[1] + "]");
//     }
// }
