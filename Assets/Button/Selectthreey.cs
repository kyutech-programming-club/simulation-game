using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selectthreey : MonoBehaviour
{
    public static int yyy = 0;

    public void OnClickStartButton()
    {
        yyy+=10;
        SceneManager.LoadScene("Ltwo");
    }
}
