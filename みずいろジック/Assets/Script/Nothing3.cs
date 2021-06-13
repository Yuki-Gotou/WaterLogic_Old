using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nothing3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (KMath.animationf == 4 || KMath.animationf == 41 || KMath.animationf == 411 || KMath.animationf == 4111 || KMath.animationf == 41111 || KMath.animationf == 6 || KMath.animationf == 61 || KMath.animationf == 611 || KMath.animationf == 6111 || KMath.animationf == 61111 || KMath4.animationf == 4 || KMath4.animationf == 41 || KMath4.animationf == 411 || KMath4.animationf == 4111 || KMath4.animationf == 41111 || KMath4.animationf == 6 || KMath4.animationf == 61 || KMath4.animationf == 611 || KMath4.animationf == 6111 || KMath4.animationf == 61111 || KMath4.animationf == 9 || KMath4.animationf == 91 || KMath4.animationf == 911 || KMath4.animationf == 9111 || KMath4.animationf == 91111)
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 0);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 1);
        }

    }
}
