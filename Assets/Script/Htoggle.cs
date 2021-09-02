using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Htoggle : MonoBehaviour
{
    [SerializeField] GameObject BoxA;
    
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    float timeElapsed;

    void Update()
    {
        //1.5s–ˆ
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 0.6f)
        {
            timeElapsed = 0.0f;

            if (a == 0) toggleA();
            else if (a == 1) toggleB();
        }



    }
    void toggleA()
    {
        BoxA.SetActive(false);
       

        a = 1;
    }
    void toggleB()
    {
        BoxA.SetActive(true);
        
        a = 0;
    }
}
