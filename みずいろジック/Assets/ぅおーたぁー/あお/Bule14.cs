using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bule14 : MonoBehaviour {
    Animation blue14;
    public int count;
    public static int GF;   //カーソルからの許可

    void Start()
    {
        blue14 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 111 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色12asdasd", gameObject);
            blue14.Play("青1-4");
            FADEBOX1.FadeU12 = "Stop";
        }
        if (KMath4.animationf == 711 && WLB4.WAGF == 2 && GF == 1)
        {
            Debug.Log("青色12asdasd", gameObject);
            blue14.Play("青1-4");
            FADEBOX1.FadeU12 = "Stop";
        }
    }
}
