using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green21 : MonoBehaviour
{
    Animation green21;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green21 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 211 && WLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色21asdasd", gameObject);
            green21.Play("緑2-1");
            FADEBOX2.FadeU21 = "Stop";
        }
        if (KMath4.animationf == 211 && NWLB1.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色21asdasd", gameObject);
            green21.Play("緑2-1");
            FADEBOX2.FadeU21 = "Stop";
        }

    }
}
