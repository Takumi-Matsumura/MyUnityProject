using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalB : MonoBehaviour
{
    


    public void Onclick()
    {
        Debug.Log("debug comment");
        //�����ňڂ肽���V�[�����w�肵�܂��B
        FadeManager.Instance.LoadScene("Stage", 1.0f);
    }
}
