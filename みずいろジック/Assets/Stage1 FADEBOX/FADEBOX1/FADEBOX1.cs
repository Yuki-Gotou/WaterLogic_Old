using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FADEBOX1 : MonoBehaviour
{
    Animation fadeanim;
    public bool FadeAnimFlg;
    public int oneflag; //何か1度だけ動かしたいときに使用
    public static int count;
    public float Anime0;        // カウント用

    public static string FadeU12;         // 1→2用管理ステータス
    bool bFadeU12;          // FadeU12用フラグ
    bool bFadeU12poure;     // FadeU12poure用フラグ
    bool bFadeU12Stay;      // FadeU12Stay用フラグ
    bool bFadeU12finish;    // FadeU12Stayfinish用フラグ

    public static string FadeU13;         // 1→3用管理ステータス
    bool bFadeU13;          // FadeU13用フラグ
    bool bFadeU13poure;     // FadeU13poure用フラグ
    bool bFadeU13Stay;      // FadeU13Stay用フラグ
    bool bFadeU13finish;    // FadeU13Stayfinish用フラグ


    void Start()
    {
        fadeanim = gameObject.GetComponent<Animation>();
        FadeAnimFlg = false;
        oneflag = 0;
        Anime0 = 0.0f;    // カウント用初期化
        Debug.Log("Animation1");
        FadeU12 = "No";

        // アニメーション用のフラグ初期化
        bFadeU12 = false;
        bFadeU12poure = false;
        bFadeU12Stay = false;
        bFadeU12finish = false;
        bFadeU13 = false;
        bFadeU13poure = false;
        bFadeU13Stay = false;
        bFadeU13finish = false;
    }

    void Update()
    {
        // 1→2
        switch (FadeU12)
        {
            case "No":
                //wave1.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                //wave1.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["FADEBOX 12"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12 = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 11;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["FADEBOX 12 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12poure = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 111;
                    WLB1.GF = 1;
                    WLB2.GF = 1;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Debug.Log("個々にはくるの", gameObject);
                Anime0 += Time.deltaTime;   // 時間を入れる
                //KMath.animationf = 0;
                if (Anime0 > fadeanim["FADEBOX 12 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12Stay = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 11111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["FADEBOX 12 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12finish = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 0;
                    FadeU12 = "No";
                }
                break;
        }

        // 1→3
        switch (FadeU13)
        {
            case "No":
                //wave1.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                //wave1.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["FADEBOX 13"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13 = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 51;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["FADEBOX 13 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13poure = true;
                    KMath.animationf = 511;
                    WLB1.GF = 1;
                    WLB3.GF = 1;
                    Anime0 = 0.0f;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["FADEBOX 13 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13Stay = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 51111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["FADEBOX 13 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13finish = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 0;
                    FadeU13 = "No";
                }
                break;
        }

        AnimeFlag();        // 各フラグの中身処理
        U12Animation();     // アニメーション1→2動かす
        U13Animation();     // アニメーション1→3動かす
    }

    // アニメーション1→2動かす
    void U12Animation()
    {
        if (KMath.animationf == 1/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～2移動
            fadeanim.Play("FADEBOX 12");
            //Anime0 = anim["U 12 Animation"].length;
            FadeU12 = "Normal";
        }

        if (KMath.animationf == 11 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～2傾き
            fadeanim.Play("FADEBOX 12 poure");
            FadeU12 = "poure";
        }
        if (KMath.animationf == 1111)
        {
            Debug.Log("アニメーション入ったよ", gameObject);
            //1～2戻る
            fadeanim.Play("FADEBOX 12 Stay");
            FadeU12 = "Stay";
        }

        if (KMath.animationf == 11111)
        {
            Debug.Log("あんたはまだだよ", gameObject);
            //1～2消える
            fadeanim.Play("FADEBOX 12 Finish");
            FadeU12 = "finish";
        }
    }

    // アニメーション1→3動かす
    void U13Animation()
    {
        if (KMath.animationf == 5/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim.Play("FADEBOX 13");
            FadeU13 = "Normal";
        }

        if (KMath.animationf == 51 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim.Play("FADEBOX 13 poure");
            FadeU13 = "poure";
        }
        if (KMath.animationf == 5111)
        {
            //1～3戻る
            fadeanim.Play("FADEBOX 13 Stay");
            FadeU13 = "Stay";
        }

        if (KMath.animationf == 51111)
        {
            //1～3消える
            fadeanim.Play("FADEBOX 13 Finish");
            FadeU13 = "finish";
        }
    }

    // アニメーションフラグによる結果処理
    void AnimeFlag()
    {
        // 1→2
        if (bFadeU12)
        {
            bFadeU12 = false;
        }

        if (bFadeU12poure)
        {
            bFadeU12poure = false;
        }

        if (bFadeU12Stay)
        {
            bFadeU12Stay = false;
        }

        if (bFadeU12finish)
        {
            bFadeU12finish = false;
        }

        // 1→3
        if (bFadeU13)
        {
            bFadeU13 = false;
        }

        if (bFadeU13poure)
        {
            bFadeU13poure = false;
        }

        if (bFadeU13Stay)
        {
            bFadeU13Stay = false;
        }

        if (bFadeU13finish)
        {
            bFadeU13finish = false;
        }
    }
}