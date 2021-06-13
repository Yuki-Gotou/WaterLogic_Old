using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green31 : MonoBehaviour
{
    Animation green31;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green31 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 611 && WLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色31asdasd", gameObject);
            green31.Play("緑3-1");
            FADEBOX3.FadeU31 = "Stop";
        }
        if (KMath4.animationf == 611 && NWLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色31asdasd", gameObject);
            green31.Play("緑3-1");
            FADEBOX3.FadeU31 = "Stop";
        }
    }
}

