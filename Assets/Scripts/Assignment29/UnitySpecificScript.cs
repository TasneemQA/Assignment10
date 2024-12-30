using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UnitySpecificScript : MonoBehaviour
{
    void OnEnable()
    {
        print("GameObject Enabled");
    }
    void Start()
    {
        print("Game started!");
        //Finding Objects
        GameObject targetObject = GameObject.Find("TargetObject");
        if (targetObject != null)
        {
            print("Found object by name: " + targetObject.name);
        }
        else
        {
            print("No Target Object found");
        }
        GameObject jokerObject = GameObject.FindGameObjectWithTag("Joker");
        if (jokerObject != null)
        {
            print("Found object by tag: " + jokerObject.name);
        }
        else
        {
            print("No joker Object found");
        }
        Light lightObject = GameObject.FindObjectOfType<Light>();
        if (lightObject != null)
        {
            print("Found object of type Light: " + lightObject.name);
        }
        else
        {
            print("No light Object found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
            {
                targetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
    }

    void OnDisable()
    {
        print("GameObject Disabled");
    }
}
