using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestOfUtilities : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            print("the sum of [1,2,3,4,5,6,7,8,9] is: " + Utilities.Add(1, 2, 3, 4, 5, 6, 7, 8, 9));
            print("Tasneem".RepeatString(5));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}