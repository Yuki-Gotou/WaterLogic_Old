using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue31 : MonoBehaviour
{
    Animation whiteblue31;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue31 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色31asdasd", gameObject);
            whiteblue31.Play("水色3-1");
            FADEBOX3.FadeU31 = "Stop";
        }
        if (KMath4.animationf == 611 && NWLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色31asdasd", gameObject);
            whiteblue31.Play("水色3-1");
            FADEBOX3.FadeU31 = "Stop";
        }
    }
}
