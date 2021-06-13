using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal1 : MonoBehaviour {

    Animation Goal;

    // Use this for initialization
    void Start () {
        Goal = this.gameObject.GetComponent<Animation>();
        Goal.Play("完成画像版ゴール");
    }

    // Update is called once per frame
    void Update () {
        if (KMath.animationf == 1 || KMath.animationf == 11 || KMath.animationf == 111 || KMath.animationf == 1111 || KMath.animationf == 11111 || KMath.animationf == 5 || KMath.animationf == 51 || KMath.animationf == 511 || KMath.animationf == 5111 || KMath.animationf == 51111 || KMath4.animationf == 1 || KMath4.animationf == 11 || KMath4.animationf == 111 || KMath4.animationf == 1111 || KMath4.animationf == 11111 || KMath4.animationf == 5 || KMath4.animationf == 51 || KMath4.animationf == 511 || KMath4.animationf == 5111 || KMath4.animationf == 51111 || KMath4.animationf == 7 || KMath4.animationf == 71 || KMath4.animationf == 711 || KMath4.animationf == 7111 || KMath4.animationf == 71111)
        {
            Goal.Play("消えるゴール");
        }
        else
        {
            Goal.Play("完成画像版ゴール");
        }
    }
}
