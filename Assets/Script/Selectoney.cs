using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selectoney : MonoBehaviour
{
    public static int y = 0;

    public void OnClickStartButton()
    {
        y+=10;
        SceneManager.LoadScene("selection2");
    }
}