using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue42 : MonoBehaviour
{
    Animation whiteblue42;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue42 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色42asdasd", gameObject);
            whiteblue42.Play("水色4-2");
            FADEBOX3.FadeU31 = "Stop";
        }
        if (KMath4.animationf == 1211 && NWLB2.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色42asdasd", gameObject);
            whiteblue42.Play("水色4-2");
            FADEBOX3.FadeU31 = "Stop";
        }
    }
}
