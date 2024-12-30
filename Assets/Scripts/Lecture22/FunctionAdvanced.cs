using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionAdvanced : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(addNums(11, 5));
        print(doubleNum(2));
        PrintNum(7);
    }

    // Update is called once per frame
    void Update()
    {

    }
    int addNums(int a, int b) => a + b;
    int doubleNum(int a) => a * 2;
    void PrintNum(int a) => print(a);

}
