using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RING: MonoBehaviour
{
   
    [SerializeField] GameObject ring;
    [SerializeField] GameObject nextring;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("���蔲�����I");
        

        ring.SetActive(false);
        nextring.SetActive(true);

    }
}
