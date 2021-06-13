using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal4 : MonoBehaviour {

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
        if (KMath4.animationf == 10 || KMath4.animationf == 101 || KMath4.animationf == 1011 || KMath4.animationf == 10111 || KMath4.animationf == 101111 || KMath4.animationf == 12 || KMath4.animationf == 121 || KMath4.animationf == 1211 || KMath4.animationf == 12111 || KMath4.animationf == 121111 || KMath4.animationf == 13 || KMath4.animationf == 131 || KMath4.animationf == 1311 || KMath4.animationf == 13111 || KMath4.animationf == 131111)
        {
            Goal.Play("消えるゴール");
        }
        else
        {
            Goal.Play("完成画像版ゴール");
        }
    }
}
