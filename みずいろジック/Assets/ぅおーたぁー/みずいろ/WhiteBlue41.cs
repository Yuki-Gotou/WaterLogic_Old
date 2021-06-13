using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBlue41 : MonoBehaviour
{
    Animation whiteblue41;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        whiteblue41 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色41asdasd", gameObject);
            whiteblue41.Play("水色4-1");
            FADEBOX3.FadeU31 = "Stop";
        }
        Debug.Log(KMath4.animationf);
        Debug.Log(NWLB1.WAGF);
        Debug.Log(GF);
        if (KMath4.animationf == 1011 && NWLB1.WAGF == 1 && GF == 1)
        {
            Debug.Log("水色41asdasd", gameObject);
            whiteblue41.Play("水色4-1");
            FADEBOX3.FadeU31 = "Stop";
        }
    }
}
