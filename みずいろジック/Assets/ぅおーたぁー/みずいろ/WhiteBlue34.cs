using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue34 : MonoBehaviour
{
    Animation whiteblue34;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue34 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色34asdasd", gameObject);
            whiteblue34.Play("水色3-4");
            FADEBOX3.FadeU31 = "Stop";
        }
        if (KMath4.animationf == 911 && WLB4.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色34asdasd", gameObject);
            whiteblue34.Play("水色3-4");
            FADEBOX3.FadeU31 = "Stop";
        }
    }
}
