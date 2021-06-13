using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green24 : MonoBehaviour
{
    Animation green24;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green24 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 311 && WLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色24asdasd", gameObject);
            green24.Play("緑2-4");
            FADEBOX2.FadeU23 = "Stop";
        }
        if (KMath4.animationf == 811 && WLB4.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色24asdasd", gameObject);
            green24.Play("緑2-4");
            FADEBOX2.FadeU23 = "Stop";
        }
    }
}
