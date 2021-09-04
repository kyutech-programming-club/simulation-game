using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectOne : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("selection2");
    }
}