﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rone : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Opening");
    }
}