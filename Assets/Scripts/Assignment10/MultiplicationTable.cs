using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log(i + " x " + j + " = " + Multiply(i, j));
            }

        }

    }
    int Multiply(int number1, int number2)
    {
        int product = number1 * number2;
        return product;
    }

}