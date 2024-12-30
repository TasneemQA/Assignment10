using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace Lecture23
{
    public class ButtonClickHandler : MonoBehaviour
    {
        [SerializeField]
        private UnityEvent onButtonClick;
        void OnEnable()
        {
            onButtonClick.AddListener(Method1.message1);
        }
        void Start()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onButtonClick.Invoke();
            }
        }
    }
}