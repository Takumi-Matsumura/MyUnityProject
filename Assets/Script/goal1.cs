using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal1 : MonoBehaviour
{
    [SerializeField] GameObject anim;
   
    [SerializeField] GameObject redblock;
    [SerializeField] GameObject redblock2;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ç∑ÇËî≤ÇØÇΩÅI");
        anim.SetActive(true);
       
        redblock.SetActive(false);
        redblock2.SetActive(false);
    }
}