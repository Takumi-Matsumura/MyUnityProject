using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tset : MonoBehaviour
{
    [SerializeField] GameObject Sphere;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ç∑ÇËî≤ÇØÇΩÅI");
        Sphere.SetActive(true);
    }
}