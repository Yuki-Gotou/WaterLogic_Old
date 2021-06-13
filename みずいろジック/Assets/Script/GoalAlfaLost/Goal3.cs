using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal3 : MonoBehaviour {

    Animation Goal;

    // Use this for initialization
    void Start()
    {
        Goal = this.gameObject.GetComponent<Animation>();
        Goal.Play("完成画像版ゴール");
    }

    // Update is called once per frame
    void Update()
    {
        if (KMath.animationf == 4 || KMath.animationf == 41 || KMath.animationf == 411 || KMath.animationf == 4111 || KMath.animationf == 41111 || KMath.animationf == 6 || KMath.animationf == 61 || KMath.animationf == 611 || KMath.animationf == 6111 || KMath.animationf == 61111 || KMath4.animationf == 4 || KMath4.animationf == 41 || KMath4.animationf == 411 || KMath4.animationf == 4111 || KMath4.animationf == 41111 || KMath4.animationf == 6 || KMath4.animationf == 61 || KMath4.animationf == 611 || KMath4.animationf == 6111 || KMath4.animationf == 61111 || KMath4.animationf == 9 || KMath4.animationf == 91 || KMath4.animationf == 911 || KMath4.animationf == 9111 || KMath4.animationf == 91111)
        {
            Goal.Play("消えるゴール");
        }
        else
        {
            Goal.Play("完成画像版ゴール");
        }
    }
}
