using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorExample : MonoBehaviour
{
    new Renderer renderer;
    Material material;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        material = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Color redColor = Color.red;
        Color blueColor = Color.blue;
        material.color = Color.Lerp(redColor,blueColor,timer);
    }
}
