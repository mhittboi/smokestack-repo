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

    public string runMessage = "Big Snail Time... :)";

    void MyFunction()
    {

    }

    // -----------------------------------------------------------
    // Start is called before the first frame update
    // -----------------------------------------------------------
    void Start()
    {
        Debug.LogError(runMessage);
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