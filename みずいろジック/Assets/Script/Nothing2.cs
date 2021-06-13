using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nothing2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (KMath.animationf == 2 || KMath.animationf == 21 || KMath.animationf == 211 || KMath.animationf == 2111 || KMath.animationf == 21111 || KMath.animationf == 3 || KMath.animationf == 31 || KMath.animationf == 311 || KMath.animationf == 3111 || KMath.animationf == 31111|| KMath4.animationf == 2 || KMath4.animationf == 21 || KMath4.animationf == 211 || KMath4.animationf == 2111 || KMath4.animationf == 21111 || KMath4.animationf == 3 || KMath4.animationf == 31 || KMath4.animationf == 311 || KMath4.animationf == 3111 || KMath4.animationf == 31111 || KMath4.animationf == 8 || KMath4.animationf == 81 || KMath4.animationf == 811 || KMath4.animationf == 8111 || KMath4.animationf == 81111)
        {
            GetComponent<SpriteRenderer>().color = 
                new Color(GetComponent<SpriteRenderer>().color.r,
                    GetComponent<SpriteRenderer>().color.g, 
                    GetComponent<SpriteRenderer>().color.b, 0);
            
        }
        else
        {
            GetComponent<SpriteRenderer>().color =
                new Color(GetComponent<SpriteRenderer>().color.r,
                    GetComponent<SpriteRenderer>().color.g,
                    GetComponent<SpriteRenderer>().color.b, 1);
        }

    }
}
