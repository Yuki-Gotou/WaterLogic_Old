using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainseen : MonoBehaviour {

    public static int seenf;   //シーン内での状況判断

	// Use this for initialization
	void Start () {
        seenf = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            //SceneManager.LoadScene("ResultClear");
        }

    }
}
