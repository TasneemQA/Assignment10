using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            int a = 1;
            Debug.Log("Before Modifying: " + "a = " + a);
            Modify(a);
            Debug.Log("After Modifying(call by value): " + "a = " + a);
            int b = 1;
            Debug.Log("Before Modifying: " + "b = " + b);
            Modify(ref b);
            Debug.Log("After Modifying(call by reference): " + "b = " + b);
            int c;
            Modify1(out c);
            Debug.Log("After Modifying using out): c = " + c);
        }
        void Modify(int num)
        {
            num += 10;
        }
        void Modify(ref int num)
        {
            num += 10;
        }
        void Modify1(out int num)
        {
            num = 10;
        }
    }
}