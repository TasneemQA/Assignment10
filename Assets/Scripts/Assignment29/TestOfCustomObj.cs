using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestOfCustomObj : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            CustomObject object1 = new CustomObject(2020, "Tasneem");
            print(object1);
            CustomObject object2 = new CustomObject(2021, "Razan");
            print("Are object1 and object2 equal? " + (object1 == object2));
            print("Are object1 and object2 not equal? " + (object1 != object2));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
