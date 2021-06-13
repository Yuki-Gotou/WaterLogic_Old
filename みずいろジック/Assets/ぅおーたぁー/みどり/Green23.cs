using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green23 : MonoBehaviour
{
    Animation green23;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green23 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 311 && WLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色23asdasd", gameObject);
            green23.Play("緑2-3");
            FADEBOX2.FadeU23 = "Stop";
        }
        if (KMath4.animationf == 311 && NWLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色23asdasd", gameObject);
            green23.Play("緑2-3");
            FADEBOX2.FadeU23 = "Stop";
        }
    }
}
