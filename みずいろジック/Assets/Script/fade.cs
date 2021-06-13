////////////////////////////////////////////
// 
// フェード
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      // シーン指導におそらく必要

public class fade : MonoBehaviour {

    GameObject fadeObj;     // フェード用画像格納

    static float CurrentFadeTime;        // 現在のフェード時間

    public int fadeTime;    // フェードイン・アウト時間
    Color alpha;            // 色
    static public string fadeStart;       // フェードの状態
    static string SceneNameManager;       // シーン名格納用

    // Use this for initialization
    void Start()
    {

        fadeObj = GameObject.Find("FADE");   // フェード用画像の取得
        CurrentFadeTime = Time.time;        // 経過時間の取得
        fadeStart = "FadeIn";               // フェードインの実行

        alpha = fadeObj.GetComponent<SpriteRenderer>().color;   // 現在の状態を取得
        alpha.a = 1.0f;                     // 初期アルファ値
        fadeObj.GetComponent<SpriteRenderer>().color = alpha;
    }

    // Update is called once per frame
    void Update()
    {
        switch (fadeStart)
        {
            case "FadeIn":
                alpha.a = 1.0f - (Time.time - CurrentFadeTime) / fadeTime;
                if (alpha.a < 0.0f)
                {
                    alpha.a = 0.0f;
                }
                break;
            case "FadeOut":
                alpha.a = (Time.time - CurrentFadeTime) / fadeTime;
                alpha.r = 1.0f - (Time.time - CurrentFadeTime) / (fadeTime * 1.3f);
                alpha.g = 1.0f - (Time.time - CurrentFadeTime) / (fadeTime * 1.3f);
                alpha.b = 1.0f - (Time.time - CurrentFadeTime) / (fadeTime * 1.3f);
                if (alpha.a > 1.0f)		// 100%以上の値になったら
                {
                    alpha.a = 1.0f;		// 100%を超えていても100%固定
                    //Load(SceneNameManager);
                }

                if (alpha.r < 0.0f)		// 100%以上の値になったら
                {
                    alpha.r = 0.0f;		// 0%を超えていても0%固定
                    alpha.g = 0.0f;		// 0%を超えていても0%固定
                    alpha.b = 0.0f;		// 0%を超えていても0%固定
                    Load(SceneNameManager);
                }
                break;
        }

        fadeObj.GetComponent<SpriteRenderer>().color = new Color(alpha.r, alpha.g, alpha.b, alpha.a);

        if (Input.GetKey(KeyCode.N))
        {
            fadeStart = "FadeIn";
            CurrentFadeTime = Time.time;
        }
        if (Input.GetKey(KeyCode.M))
        {
            fadeStart = "FadeOut";
            CurrentFadeTime = Time.time;
        }

        
    }

    static public void SetFadeOut(string SceneName)
    {
        fadeStart = "FadeOut";
        CurrentFadeTime = Time.time;
        SceneNameManager = SceneName;
    }

    public void Load(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
