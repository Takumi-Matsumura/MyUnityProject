using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartB : MonoBehaviour
{
    public void Onclick()
    {
        //�����ňڂ肽���V�[�����w�肵�܂��B
        FadeManager.Instance.LoadScene("Tutorial",1.0f);
    }
}