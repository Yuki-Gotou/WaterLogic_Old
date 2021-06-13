using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue43 : MonoBehaviour
{
    Animation whiteblue43;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue43 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色43asdasd", gameObject);
            whiteblue43.Play("水色4-3");
            FADEBOX3.FadeU31 = "Stop";
        }

        if (KMath4.animationf == 1311 && NWLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色43asdasd", gameObject);
            whiteblue43.Play("水色4-3");
            FADEBOX3.FadeU31 = "Stop";
        }
    }
}
