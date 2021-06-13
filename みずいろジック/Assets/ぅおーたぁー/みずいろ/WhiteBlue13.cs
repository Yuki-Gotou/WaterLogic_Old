using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue13 : MonoBehaviour
{
    Animation whiteblue13;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue13 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 511 && WLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色13asdasd", gameObject);
            whiteblue13.Play("水色1-3");
            FADEBOX1.FadeU13 = "Stop";
        }
        if (KMath4.animationf == 511 && NWLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色13asdasd", gameObject);
            whiteblue13.Play("水色1-3");
            FADEBOX1.FadeU13 = "Stop";
        }
    }
}