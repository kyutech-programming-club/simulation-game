using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectOnex : MonoBehaviour
{
    public static int x = 0;

    public void OnClickStartButton()
    {
        x+=6;
        SceneManager.LoadScene("selection2");
    }
}
