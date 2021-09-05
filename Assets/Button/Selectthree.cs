using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selectthree : MonoBehaviour
{
    public static int zzz= 0;
    public void OnClickStartButton()
    {
        zzz+=1;
        SceneManager.LoadScene("Ltwo");
    }
}