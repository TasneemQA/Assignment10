using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    public GameObject capsule;
    float counter = 0;
    void Start()
    {
        //there is many ways to find the game object without making by ourselves
        capsule = GameObject.Find("Capsule");//first way
        //capsule = GameObject.FindGameObjectWithTag("Abu Lutfi"); // second way


    }
    void Update()
    {
        if (capsule != null)
        {
            counter = Mathf.Floor(Time.time);
            if (counter % 2f == 0)
            {
                capsule.SetActive(true);
            }
            else
            {
                capsule.SetActive(false);
            }
            if (Time.time > 10)
            {
                Destroy(capsule);
            }
        }
    }
}
