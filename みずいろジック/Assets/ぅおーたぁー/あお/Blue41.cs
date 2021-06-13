using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue41 : MonoBehaviour {
    Animation blue41;
    public int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue41 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色41asdasd", gameObject);
            blue41.Play("青4-1");
            FADEBOX1.FadeU12 = "Stop";
        }
        if (KMath4.animationf == 1011 && NWLB1.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色41asdasd", gameObject);
            blue41.Play("青4-1");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
