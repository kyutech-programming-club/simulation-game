using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selecttwox : MonoBehaviour
{
    public static int xx = 0;

    public void OnClickStartButton()
    {
        xx+=5;
        SceneManager.LoadScene("Lthree");
    }
}