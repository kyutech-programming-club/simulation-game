using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selecttwoy : MonoBehaviour
{
    public static int yy = 0;

    public void OnClickStartButton()
    {
        yy+=10;
        SceneManager.LoadScene("Lthree");
    }
}

