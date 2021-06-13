using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue23 : MonoBehaviour
{
    Animation whiteblue23;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue23 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 311 && WLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色23asdasd", gameObject);
            whiteblue23.Play("水色2-3");
            FADEBOX2.FadeU23 = "Stop";
        }
        if (KMath4.animationf == 311 && NWLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色23asdasd", gameObject);
            whiteblue23.Play("水色2-3");
            FADEBOX2.FadeU23 = "Stop";
        }
    }
}
