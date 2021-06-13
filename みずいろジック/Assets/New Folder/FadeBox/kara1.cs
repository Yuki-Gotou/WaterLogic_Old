using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kara1 : MonoBehaviour {
    Animation Kara1;

    // Use this for initialization
    void Start()
    {
        Kara1 = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            Kara1.Play("Fade U 12 kara Animation");
        }
        else if (Input.GetKey(KeyCode.Y))
        {
            Kara1.Play("Fade U Stay 12 kara Animation");
        }
        else if (Input.GetKey(KeyCode.U))
        {
            Kara1.Play("Fade U 13 kara Animation");
        }
        else if (Input.GetKey(KeyCode.I))
        {
            Kara1.Play("Fade U Stay 13 kara Animation");
        }
    }
}
