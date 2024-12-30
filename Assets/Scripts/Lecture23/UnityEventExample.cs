using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Lecture23
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent<int, string> unityEvent;
        void OnEnable()
        {
            unityEvent.AddListener(WasfiyehListener.EventListener);
        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                unityEvent.Invoke(1, "Tasneem");
            }

        }

        public void doXYZ(int i, string a)
        {
            Debug.Log("Mlukhieh");
        }
    }
}
