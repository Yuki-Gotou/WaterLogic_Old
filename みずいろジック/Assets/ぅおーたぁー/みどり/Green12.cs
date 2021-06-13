using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green12 : MonoBehaviour
{
    Animation green12;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green12 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色12asdasd", gameObject);
            green12.Play("緑1-2");
            FADEBOX1.FadeU12 = "Stop";
        }
        if (KMath4.animationf == 111 && NWLB2.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色12asdasd", gameObject);
            green12.Play("緑1-2");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
