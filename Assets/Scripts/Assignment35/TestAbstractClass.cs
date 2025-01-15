using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var derivedClassExample = new DerivedClassExample();
            derivedClassExample.PerformAction();
            derivedClassExample.PrintInfo();
        }
    }

}
