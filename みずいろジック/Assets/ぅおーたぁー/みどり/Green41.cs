using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green41 : MonoBehaviour
{
    Animation green41;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green41 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 211 && WLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色41asdasd", gameObject);
            green41.Play("緑4-1");
            FADEBOX2.FadeU21 = "Stop";
        }
        if (KMath4.animationf == 1011 && NWLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色41asdasd", gameObject);
            green41.Play("緑4-1");
            FADEBOX2.FadeU21 = "Stop";
        }
    }
}