using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rise : MonoBehaviour
{
    int counter = 0;
    float move = 0.005f;

    void Update()
    {
        Vector3 p = new Vector3(0, move, 0);
        transform.Translate(p);
        counter++;

       
    }
}
