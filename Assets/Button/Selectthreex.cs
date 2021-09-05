using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selectthreex : MonoBehaviour
{
    public static int xxx = 0;

    public void OnClickStartButton()
    {
        xxx+=5;
        SceneManager.LoadScene("Ltwo");
    }
}
