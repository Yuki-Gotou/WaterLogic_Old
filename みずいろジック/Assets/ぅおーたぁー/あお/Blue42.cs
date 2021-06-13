using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue42 : MonoBehaviour {
    Animation blue42;
    public int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue42 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色42asdasd", gameObject);
            blue42.Play("青4-2");
            FADEBOX1.FadeU12 = "Stop";
        }
        if (KMath4.animationf == 1211 && NWLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色42asdasd", gameObject);
            blue42.Play("青4-2");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
