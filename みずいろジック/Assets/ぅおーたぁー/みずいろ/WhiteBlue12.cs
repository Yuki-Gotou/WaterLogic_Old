using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue12 : MonoBehaviour
{
    Animation whiteblue12;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue12 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色12asdasd", gameObject);
            whiteblue12.Play("水色1-2");
            FADEBOX1.FadeU12 = "Stop";
        }

        if (KMath4.animationf == 111 && NWLB2.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色12asdasd", gameObject);
            whiteblue12.Play("水色1-2");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
