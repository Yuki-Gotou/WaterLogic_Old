using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target4 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (KMath.utusugawa == 4 || KMath4.utusugawa == 4)
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 0.5f);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 0);
        }
    }
}
