using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Selectoney;
using static SelectOnex;
using static Selectone;
public class Lastone : MonoBehaviour
{
    public GameObject texta;
    public GameObject textb;
    public GameObject textc;
    public GameObject textd;
    public GameObject texte;
    public GameObject textf;
    public GameObject textg;
    public GameObject texth;
    public GameObject texti;
    public GameObject textj;
    public GameObject textk;
    public GameObject textl;
    public GameObject textm;
    public GameObject textn;
    public GameObject texto;
    public GameObject textp;
    public GameObject button1;
    public Transform parent;
    public int a;
    bool aa;

    // Start is called before the first frame update
    void Awake()
    {
        a=x+y+z;
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
            
            Debug.Log(a);
            if (a == 2){
                //   Debug.Log(a);
                var objb = Instantiate(textb, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objb.name = textb.name;
                a += 1;
            }
            else if(a == 3){
                //   Debug.Log(a);
                var objc = Instantiate(textc, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objc.name = textc.name;
                a += 1;
            }

            else if(a==4){
                //   Debug.Log(a);
                var objd = Instantiate(textd, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objd.name = textd.name;
                a += 1;
            }
            else if(a==5){
                //   Debug.Log(a);
                var obje = Instantiate(texte, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                obje.name = texte.name;
                var obj1 = Instantiate(button1, new Vector3(  464,180 , 0.0f), Quaternion.identity,parent) as GameObject;
                obj1.name = button1.name;
            }
            else if (a == 6){
                //   Debug.Log(a);
                var objf = Instantiate(textf, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objf.name = textf.name;
                a += 1;
            }
            else if (a == 7){
                //   Debug.Log(a);
                var objg = Instantiate(textg, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objg.name = textg.name;
                a += 1;
            }
            else if (a == 8){
                //   Debug.Log(a);
                var objh = Instantiate(texth, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objh.name = texth.name;
                a += 1;
            }
            else if (a == 9){
                //   Debug.Log(a);
                var obji = Instantiate(texti, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                obji.name = texti.name;
                a+=1;
            }
            else if (a == 10){
                //   Debug.Log(a);
                var objj = Instantiate(textj, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objj.name = textj.name;
                var obj1 = Instantiate(button1, new Vector3(  464,180 , 0.0f), Quaternion.identity,parent) as GameObject;
                obj1.name = button1.name;
            }
            else if (a == 11){
                //   Debug.Log(a);
                var objk = Instantiate(textk, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objk.name = textk.name;
                a += 1;
            }
            else if (a == 12){
                //   Debug.Log(a);
                var objl = Instantiate(textl, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objl.name = textl.name;
                a += 1;
            }
            else if (a == 13){
                //   Debug.Log(a);
                var objm = Instantiate(textm, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objm.name = textm.name;
                a += 1;
            }
            else if (a == 14){
                //   Debug.Log(a);
                var objn = Instantiate(textn, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objn.name = textn.name;
                a += 1;
            }
            else if (a == 15){
                //   Debug.Log(a);
                var objo = Instantiate(texto, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objo.name = texto.name;
                a += 1;
            }
            else if (a == 16){
                //   Debug.Log(a);
                var objp = Instantiate(textp, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
                objp.name = textp.name;
                a += 1;
                var obj1 = Instantiate(button1, new Vector3( 464,180 , 0.0f), Quaternion.identity,parent) as GameObject;
                obj1.name = button1.name;
            }
            else if (a==1){
                //   Debug.Log(a);
                aa = true;
                a += 1;
            }
        }
    }
}