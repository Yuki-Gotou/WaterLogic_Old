using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue21 : MonoBehaviour
{
    Animation whiteblue21;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue21 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 211 && WLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色21asdasd", gameObject);
            whiteblue21.Play("水色2-1");
            FADEBOX2.FadeU21 = "Stop";
        }
        if (KMath4.animationf == 211 && NWLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色21asdasd", gameObject);
            whiteblue21.Play("水色2-1");
            FADEBOX2.FadeU21 = "Stop";
        }
    }
}
