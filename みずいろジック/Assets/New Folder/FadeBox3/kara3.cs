using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kara3 : MonoBehaviour {
    Animation Kara3;

    // Use this for initialization
    void Start()
    {
        Kara3 = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            Kara3.Play("Fade U 31 kara Animation");
        }
        else if (Input.GetKey(KeyCode.B))
        {
            Kara3.Play("Fade U Stay 31 kara Animation");
        }
        else if (Input.GetKey(KeyCode.N))
        {
            Kara3.Play("Fade U 32 kara Animation");
        }
        else if (Input.GetKey(KeyCode.M))
        {
            Kara3.Play("Fade U Stay 32 kara Animation");
        }
    }
}
