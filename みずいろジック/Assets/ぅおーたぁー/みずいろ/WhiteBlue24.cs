using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue24 : MonoBehaviour
{
    Animation whiteblue24;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue24 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 311 && WLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色24asdasd", gameObject);
            whiteblue24.Play("水色2-4");
            FADEBOX2.FadeU23 = "Stop";
        }
        if (KMath4.animationf == 811 && WLB4.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色24asdasd", gameObject);
            whiteblue24.Play("水色2-4");
            FADEBOX2.FadeU23 = "Stop";
        }
    }
}
