// Hello World
// Author: Russel Frerichs
// Date: 10/03/2022
// Purpose: Learn the basics of a Unity script!

// ---------------------------------------------------------------
// Libraries
// ---------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ---------------------------------------------------------------

// ---------------------------------------------------------------
// Class HelloWorld
// ---------------------------------------------------------------
// Class contains everything in the script
public class HelloWorld : MonoBehaviour
{
    void MyFunction()
    {

    }

    // -----------------------------------------------------------
    // Start is called before the first frame update
    // -----------------------------------------------------------
    void Start()
    {
        Debug.LogError("BIG SNAIL TIME");
    }

    // -----------------------------------------------------------
    // Update is called once per frame
    // -----------------------------------------------------------
    void Update()
    {
        Debug.LogWarning("snail");
    }
}
// Ends Script
// ---------------------------------------------------------------