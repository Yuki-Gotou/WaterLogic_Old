using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green14 : MonoBehaviour
{
    Animation green14;
    public static int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        green14 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 511 && WLB3.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色14asdasd", gameObject);
            green14.Play("緑1-4");
            FADEBOX1.FadeU13 = "Stop";
        }
        if (KMath4.animationf == 711 && WLB4.WAGF == 3 && GF == 1)
        {
            Debug.Log("緑色14asdasd", gameObject);
            green14.Play("緑1-4");
            FADEBOX1.FadeU13 = "Stop";
        }

    }
}
