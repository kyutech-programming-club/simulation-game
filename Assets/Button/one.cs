using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class one : MonoBehaviour
{
    // Start is called before the first frame update
    public static int a = 0;
    public void OnClickStartButton()
    {
        if(a==1){
            SceneManager.LoadScene("selection2");
        }
        else{
            SceneManager.LoadScene("explain");
            a+=1;
        }
    }
}
