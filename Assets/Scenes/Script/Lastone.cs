﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lastone : MonoBehaviour
{
    public GameObject texta;
    public GameObject textb;
    public GameObject textc;
    public GameObject textd;
    public GameObject texte;
    public int a;
    bool aa;

    // Start is called before the first frame update
    void Start()
    {
        a=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(aa)
        {
            var obj = Instantiate(texta, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
            obj.name = texta.name;
            aa = false;
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            
            a += 1;
            Debug.Log(a);
            if (a == 2){
                //   Debug.Log(a);
                var objb = Instantiate(textb, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objb.name = textb.name;
            }
            else if(a == 3){
                //   Debug.Log(a);
                var objc = Instantiate(textc, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objc.name = textc.name;
            }

            else if(a==4){
                //   Debug.Log(a);
                var objd = Instantiate(textd, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objd.name = textd.name;
            }
            else if(a==5){
                //   Debug.Log(a);
                var obje = Instantiate(texte, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                obje.name = texte.name;
            }
            else if (a==1){
                //   Debug.Log(a);
                aa = true;
            }
        }
    }
}