using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geo_Controller : MonoBehaviour
{
    string String = "Hello ";
    int fire = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(fire);
        fire++;
    }
}
