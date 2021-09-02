using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RING: MonoBehaviour
{
   
    [SerializeField] GameObject ring;
    [SerializeField] GameObject nextring;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("すり抜けた！");
        

        ring.SetActive(false);
        nextring.SetActive(true);

    }
}
