using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int health = 100;
            object boxedHealth = health;
            int unboxedHealth = (int)boxedHealth;
            unboxedHealth = 50;
            Debug.Log("The original value of health: " + health);
            Debug.Log("The boxed value: " + boxedHealth);
            Debug.Log("The unboxed and modified value: " + unboxedHealth);

        }

        // Update is called once per frame
        void Update()
        {
        }

    }
}
