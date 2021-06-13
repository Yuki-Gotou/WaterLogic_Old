using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue43 : MonoBehaviour {
    Animation blue43;
    public int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue43 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色43asdasd", gameObject);
            blue43.Play("青4-3");
            FADEBOX1.FadeU12 = "Stop";
        }
        if (KMath4.animationf == 1311 && NWLB3.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色43asdasd", gameObject);
            blue43.Play("青4-3");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
