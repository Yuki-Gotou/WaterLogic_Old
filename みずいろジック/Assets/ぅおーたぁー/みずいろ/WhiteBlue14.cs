using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue14 : MonoBehaviour
{
    Animation whiteblue14;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue14 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 511 && WLB3.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色14asdasd", gameObject);
            whiteblue14.Play("水色1-4");
            FADEBOX1.FadeU13 = "Stop";
        }
        if (KMath4.animationf == 711 && WLB4.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色14asdasd", gameObject);
            whiteblue14.Play("水色1-4");
            FADEBOX1.FadeU13 = "Stop";
        }
    }
}