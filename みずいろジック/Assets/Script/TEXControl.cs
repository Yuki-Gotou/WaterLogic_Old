////////////////////////////////////////////
// 
// UI_TEXTの変更
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TEXControl : MonoBehaviour {
    public Text Qtext;
    public Text Qtext2;
    // Use this for initialization
    void Start()
    {
        // 最初はアルファ値だけ0にする
        //Qtext.color = new Color(Qtext.color.r, Qtext.color.g, Qtext.color.b, 0f);
        //Qtext2.color = new Color(Qtext2.color.r, Qtext2.color.g, Qtext2.color.b, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gouru.bClear)   // 外部フラグ
        {// クリア
            // アルファ値を入れる
            //SceneManager.LoadScene("ResultClear");
            gouru.bClear = false;
            Qtext.color = new Color(Qtext.color.r, Qtext.color.g, Qtext.color.b, 1f);
        }

        if (Enemy.bPtrigger)   // 外部フラグ
        {// ゲームオーバー
            // アルファ値を入れる
            Qtext2.color = new Color(Qtext2.color.r, Qtext2.color.g, Qtext2.color.b, 1f);
            SceneManager.LoadScene("ResultGameOver");
        }
    }
}
