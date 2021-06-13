using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green43 : MonoBehaviour
{
    Animation green43;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green43 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 211 && WLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色43asdasd", gameObject);
            green43.Play("緑4-3");
            FADEBOX2.FadeU21 = "Stop";
        }
        if (KMath4.animationf == 1311 && NWLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色43asdasd", gameObject);
            green43.Play("緑4-3");
            FADEBOX2.FadeU21 = "Stop";
        }
    }
}