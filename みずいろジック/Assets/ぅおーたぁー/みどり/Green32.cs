using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green32 : MonoBehaviour
{
    Animation green32;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green32 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 411 && WLB2.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色32asdasd", gameObject);
            green32.Play("緑3-2");
            FADEBOX3.FadeU32 = "Stop";
        }
        if (KMath4.animationf == 411 && NWLB2.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色32asdasd", gameObject);
            green32.Play("緑3-2");
            FADEBOX3.FadeU32 = "Stop";
        }
    }
}
