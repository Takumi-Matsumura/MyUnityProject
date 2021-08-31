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
        //ここで移りたいシーンを指定します。
        FadeManager.Instance.LoadScene("Stage", 1.0f);
    }
}
