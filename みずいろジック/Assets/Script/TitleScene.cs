using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーン遷移に必要!

public class TitleScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return)|| Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            //SceneManager.LoadScene("SelectScene");
            fade.SetFadeOut("SelectScene");
            CameraTitle.bMoveObj = false;
        }
	}
}
