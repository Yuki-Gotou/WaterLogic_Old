using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green13 : MonoBehaviour
{
    Animation green13;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green13 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 511 && WLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色13asdasd", gameObject);
            green13.Play("緑1-3");
            FADEBOX1.FadeU13 = "Stop";
        }
        if (KMath4.animationf == 511 && NWLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色13asdasd", gameObject);
            green13.Play("緑1-3");
            FADEBOX1.FadeU13 = "Stop";
        }
    }
}
