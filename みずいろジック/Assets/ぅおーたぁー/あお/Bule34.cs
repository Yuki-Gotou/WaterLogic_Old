using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bule34 : MonoBehaviour
{
    Animation blue34;
    public int count;
    public static int GF;   //カーソルからの許可


    void Start()
    {
        blue34 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 411 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log(KMath.animationf);
            Debug.Log("青色34asdasd", gameObject);
            blue34.Play("青3-4");
            FADEBOX3.FadeU32 = "Stop";
        }

        if (KMath4.animationf == 911 && WLB4.WAGF == 2 && GF == 1)
        {
            Debug.Log(KMath.animationf);
            Debug.Log("青色34asdasd", gameObject);
            blue34.Play("青3-4");
            FADEBOX3.FadeU32 = "Stop";
        }
    }
}
