using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue31 : MonoBehaviour
{
    Animation blue31;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue31 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色31asdasd", gameObject);
            blue31.Play("青3-1");
            FADEBOX3.FadeU31 = "Stop";
            Debug.Log(WLB1.WAGF);
        }

        if (KMath4.animationf == 611 && NWLB1.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色31asdasd", gameObject);
            blue31.Play("青3-1");
            FADEBOX3.FadeU31 = "Stop";
            Debug.Log(WLB1.WAGF);
        }
    }
}
