using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue23 : MonoBehaviour
{
    Animation blue23;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue23 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 311 && WLB3.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色23asdasd", gameObject);
            blue23.Play("青2-3");
            FADEBOX2.FadeU23 = "Stop";
        }
        if (KMath4.animationf == 311 && NWLB3.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色23asdasd", gameObject);
            blue23.Play("青2-3");
            FADEBOX2.FadeU23 = "Stop";
        }

    }
}
