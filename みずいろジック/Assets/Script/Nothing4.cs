using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nothing4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (KMath4.animationf == 10 || KMath4.animationf == 101 || KMath4.animationf == 1011 || KMath4.animationf == 10111 || KMath4.animationf == 101111 || KMath4.animationf == 12 || KMath4.animationf == 121 || KMath4.animationf == 1211 || KMath4.animationf == 12111 || KMath4.animationf == 121111|| KMath4.animationf == 13 || KMath4.animationf == 131 || KMath4.animationf == 1311 || KMath4.animationf == 13111 || KMath4.animationf == 131111 )
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 0);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 1);
        }

    }
}
