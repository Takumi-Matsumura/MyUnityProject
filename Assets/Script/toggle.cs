using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    [SerializeField] GameObject BoxA;
    [SerializeField] GameObject BoxB;
    int a=0;
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
        if (timeElapsed >= 1.5f)
        {
            timeElapsed = 0.0f;

            if (a == 0) toggleA();
            else if (a == 1) toggleB();
        }



    }
    void toggleA()
    {
        BoxA.SetActive(false);
        BoxB.SetActive(true);

        a = 1;
    }
    void toggleB()
    {
        BoxA.SetActive(true);
        BoxB.SetActive(false);
        a = 0;
    }
}
