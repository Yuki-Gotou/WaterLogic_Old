using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kara2 : MonoBehaviour {
    Animation Kara2;

    // Use this for initialization
    void Start()
    {
        Kara2 = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            Kara2.Play("Fade U 21 kara Animation");
        }
        else if (Input.GetKey(KeyCode.H))
        {
            Kara2.Play("Fade U Stay 21 kara Animation");
        }
        else if (Input.GetKey(KeyCode.J))
        {
            Kara2.Play("Fade U 23 kara Animation");
        }
        else if (Input.GetKey(KeyCode.K))
        {
            Kara2.Play("Fade U Stay 23 kara Animation");
        }
    }
}
