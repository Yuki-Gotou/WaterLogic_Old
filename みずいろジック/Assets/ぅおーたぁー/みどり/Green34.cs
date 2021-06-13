using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green34 : MonoBehaviour
{
    Animation green34;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green34 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 411 && WLB2.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色34asdasd", gameObject);
            green34.Play("緑3-4");
            FADEBOX3.FadeU32 = "Stop";
        }
        if (KMath4.animationf == 911 && WLB4.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色34asdasd", gameObject);
            green34.Play("緑3-4");
            FADEBOX3.FadeU32 = "Stop";
        }
    }
}
