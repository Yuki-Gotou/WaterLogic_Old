using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue21 : MonoBehaviour
{
    Animation blue21;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue21 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 211 && WLB1.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色21asdasd", gameObject);
            blue21.Play("青2-1");
            FADEBOX2.FadeU21 = "Stop";
        }

        if (KMath4.animationf == 211 && NWLB1.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色21asdasd", gameObject);
            blue21.Play("青2-1");
            FADEBOX2.FadeU21 = "Stop";
        }
    }
}
