using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue12 : MonoBehaviour
{
    Animation blue12;
    public int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue12 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色12asdasd", gameObject);
            blue12.Play("青1-2");
            FADEBOX1.FadeU12 = "Stop";
        }
        if (KMath4.animationf == 111 && NWLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色12asdasd", gameObject);
            blue12.Play("青1-2");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
