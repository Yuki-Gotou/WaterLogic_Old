using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTitle : MonoBehaviour {

    public AudioSource sound01;
    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }

    void Update()
    {
        //指定のキーが押されたら音声ファイルの再生をする
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sound01.PlayOneShot(sound01.clip);
        }
    }
}
