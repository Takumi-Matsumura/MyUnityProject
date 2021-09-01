using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifGoal : MonoBehaviour   
{
    


    private bool once = true;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        
        if (hit.gameObject.tag == "Goal")
        {
            if (once)
            {
                FadeManager.Instance.LoadScene("clear", 1.0f);
                Debug.Log("debug comment");
                once =false;
            }
            
        }

        
    }

}
