using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teilbarkeiten : MonoBehaviour
{
    int number = 1234; // Hier kannst du die Zahl ändern, deren Ziffern du extrahieren möchtest.
    string numberstring;


    private void Start()
    {
        numberstring = number.ToString();

        Debug.Log(int.Parse(numberstring.Remove(2, 1)));

    }
}
