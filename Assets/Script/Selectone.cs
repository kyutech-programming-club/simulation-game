﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selectone : MonoBehaviour
{
    public static int z= 0;
    public void OnClickStartButton()
    {
        z+=1;
        SceneManager.LoadScene("Lone");
    }
}