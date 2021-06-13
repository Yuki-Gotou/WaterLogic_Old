using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue32 : MonoBehaviour
{
    Animation blue32;
    public int count;
    public static int GF;   //カーソルからの許可


    void Start()
    {
        blue32 = this.gameObject.GetComponent<Animation>();
        count = 0;
        GF = 0;
    }

    void Update()
    {
        if (KMath.animationf == 411 && WLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log(KMath.animationf);
            Debug.Log("青色32asdasd", gameObject);
            blue32.Play("青3-2");
            FADEBOX3.FadeU32 = "Stop";
        }
        if (KMath4.animationf == 411 && NWLB2.WAGF == 2 && GF == 1)
        {
            Debug.Log(KMath.animationf);
            Debug.Log("青色32asdasd", gameObject);
            blue32.Play("青3-2");
            FADEBOX3.FadeU32 = "Stop";
        }
    }
}
