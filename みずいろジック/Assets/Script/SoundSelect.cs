using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSelect : MonoBehaviour {

    public AudioSource sound01;
    public AudioSource sound02;
    void Start()
    {
        AudioSource[] Audio = GetComponents<AudioSource>();
        sound01 = Audio[0];
        sound02 = Audio[1];
    }

    void Update()
    {
        //指定のキーが押されたら音声ファイルの再生をする
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sound01.PlayOneShot(sound01.clip);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sound01.PlayOneShot(sound01.clip);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sound02.PlayOneShot(sound02.clip);
        }
    }
}