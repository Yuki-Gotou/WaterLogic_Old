using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green42 : MonoBehaviour
{
    Animation green42;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green42 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 211 && WLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色42asdasd", gameObject);
            green42.Play("緑4-2");
            FADEBOX2.FadeU21 = "Stop";
        }
        if (KMath4.animationf == 1211 && NWLB2.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色42asdasd", gameObject);
            green42.Play("緑4-2");
            FADEBOX2.FadeU21 = "Stop";
        }
    }
}