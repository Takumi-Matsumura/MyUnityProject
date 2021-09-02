using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal2 : MonoBehaviour
{
    [SerializeField] GameObject anim;
    
    [SerializeField] GameObject Active;
    [SerializeField] GameObject Active2;
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ç∑ÇËî≤ÇØÇΩÅI");
        anim.SetActive(true);
        
        Active.SetActive(true);
        Active2.SetActive(true);
        
    }
}
