using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue32 : MonoBehaviour
{
    Animation whiteblue32;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue32 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 411 && WLB2.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色32asdasd", gameObject);
            whiteblue32.Play("水色3-2");
            FADEBOX3.FadeU32 = "Stop";
        }
        if (KMath4.animationf == 411 && NWLB2.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色32asdasd", gameObject);
            whiteblue32.Play("水色3-2");
            FADEBOX3.FadeU32 = "Stop";
        }
    }
}
