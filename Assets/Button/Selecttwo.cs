using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selecttwo : MonoBehaviour
{
    public static int zz= 0;
    public void OnClickStartButton()
    {
        zz+=1;
        SceneManager.LoadScene("Lthree");
    }
}