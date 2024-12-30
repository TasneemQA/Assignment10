using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**1. Lifecycle Methods
1. Use the OnEnable() method to print() "GameObject Enabled" when the
GameObject is enabled in the scene.
2. Use the OnDisable() method to print() "GameObject Disabled" when the
GameObject is disabled in the scene.
3. Use the Start() method to print() "Game started!" when the game begins
(Play Mode).
2. GameObject Interaction
1. Use SetActive() to deactivate another GameObject when the "D" key is pressed
2. print() "TargetObject deactivated!" to confirm that the object has been
deactivated.
3. Finding Objects
1. Use GameObject.Find() to locate "TargetObject" by its name.
print() the name of the object if found, or print() "No TargetObject found."
if it doesn’t exist.
2. Use GameObject.FindGameObjectWithTag() to locate the "Joker" object by its
tag.
print() the name of the object if found, or log "No Joker object found." if it
doesn’t exist.
3. Use GameObject.FindObjectOfType<>() to locate an object of type Light.
print() the name of the object if found, or log "No Light object found." if it
doesn’t exist.
Expected Unity Console Output
GameObject Enabled
Game started!
Found object by name: TargetObject
Found object by tag: Joker
Found object of type Light: Directional Light
TargetObject deactivated!
GameObject Disabled**/
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
