using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue13 : MonoBehaviour
{
    Animation blue13;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue13 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 511 && WLB3.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色13asdasd", gameObject);
            blue13.Play("青1-3");
            FADEBOX1.FadeU13 = "Stop";
        }

        if (KMath4.animationf == 511 && NWLB3.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色13asdasd", gameObject);
            blue13.Play("青1-3");
            FADEBOX1.FadeU13 = "Stop";
        }

    }
}
