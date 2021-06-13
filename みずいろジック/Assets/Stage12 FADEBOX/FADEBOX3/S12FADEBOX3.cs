using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S12FADEBOX3 : MonoBehaviour
{
    Animation fadeanim3;
    public bool FadeAnimFlg;
    public int oneflag; //何か1度だけ動かしたいときに使用
    public static int count;
    public float Anime0;        // カウント用

    public static string FadeU31;         // 1→2用管理ステータス
    bool bFadeU31;          // FadeU12用フラグ
    bool bFadeU31poure;     // FadeU12poure用フラグ
    bool bFadeU31Stay;      // FadeU12Stay用フラグ
    bool bFadeU31finish;    // FadeU12Stayfinish用フラグ

    public static string FadeU32;         // 1→3用管理ステータス
    bool bFadeU32;          // FadeU13用フラグ
    bool bFadeU32poure;     // FadeU13poure用フラグ
    bool bFadeU32Stay;      // FadeU13Stay用フラグ
    bool bFadeU32finish;    // FadeU13Stayfinish用フラグ

    void Start()
    {
        fadeanim3 = this.gameObject.GetComponent<Animation>();
        FadeAnimFlg = false;
        oneflag = 0;
        count = 0;
        Anime0 = 0.0f;    // カウント用初期化
        Debug.Log("Animation3");

        // アニメーション用のフラグ初期化
        bFadeU31 = false;
        bFadeU31poure = false;
        bFadeU31Stay = false;
        bFadeU31finish = false;
        bFadeU32 = false;
        bFadeU32poure = false;
        bFadeU32Stay = false;
        bFadeU32finish = false;
    }

    void Update()
    {
        // 1→2
        switch (FadeU31)
        {
            case "No":
                //wave3.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                //wave3.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim3["12 FADEBOX 31"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31 = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 61;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim3["12 FADEBOX 31 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31poure = true;
                    KMath.animationf = 611;
                    Anime0 = 0.0f;
                    WLB3.GF = 1;
                    WLB1.GF = 1;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Anime0 += Time.deltaTime;   // 時間を入れる

                //KMath.animationf = 0;
                if (Anime0 > fadeanim3["12 FADEBOX 31 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31Stay = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 61111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim3["12 FADEBOX 31 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31finish = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 0;
                    FadeU31 = "No";
                }
                break;
        }

        // 1→3
        switch (FadeU32)
        {
            case "No":
                //wave3.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                //wave3.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim3["12 FADEBOX 32"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32 = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 41;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim3["12 FADEBOX 32 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32poure = true;
                    KMath.animationf = 411;
                    WLB3.GF = 1;
                    WLB2.GF = 1;
                    Anime0 = 0.0f;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim3["12 FADEBOX 32 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32Stay = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 41111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim3["12 FADEBOX 32 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32finish = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 0;
                    FadeU32 = "No";
                }
                break;
        }

        AnimeFlag();        // 各フラグの中身処理
        U31Animation();     // アニメーション3→1動かす
        U32Animation();     // アニメーション3→2動かす
    }

    // アニメーション3→1動かす
    void U31Animation()
    {
        if (KMath.animationf == 6/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～2移動
            fadeanim3.Play("12 FADEBOX 31");
            FadeU31 = "Normal";
        }

        if (KMath.animationf == 61 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～2傾き
            fadeanim3.Play("12 FADEBOX 31 poure");
            FadeU31 = "poure";
        }
        if (KMath.animationf == 6111)
        {
            //1～2戻る
            fadeanim3.Play("12 FADEBOX 31 Stay");
            FadeU31 = "Stay";
        }

        if (KMath.animationf == 61111)
        {
            //1～2消える
            fadeanim3.Play("12 FADEBOX 31 Finish");
            FadeU31 = "finish";
        }
    }

    // アニメーション3→2動かす
    void U32Animation()
    {
        if (KMath.animationf == 4/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim3.Play("12 FADEBOX 32");
            FadeU32 = "Normal";
        }

        if (KMath.animationf == 41 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim3.Play("12 FADEBOX 32 poure");
            FadeU32 = "poure";
        }
        if (KMath.animationf == 4111)
        {
            //1～3戻る
            fadeanim3.Play("12 FADEBOX 32 Stay");
            FadeU32 = "Stay";
        }

        if (KMath.animationf == 41111)
        {
            //1～3消える
            fadeanim3.Play("12 FADEBOX 32 Finish");
            FadeU32 = "finish";
        }
    }

    // アニメーションフラグによる結果処理
    void AnimeFlag()
    {
        // 3→1
        if (bFadeU31)
        {
            bFadeU31 = false;
        }

        if (bFadeU31poure)
        {
            bFadeU31poure = false;
        }

        if (bFadeU31Stay)
        {
            bFadeU31Stay = false;
        }

        if (bFadeU31finish)
        {
            bFadeU31finish = false;
        }

        // 3→2
        if (bFadeU32)
        {
            bFadeU32 = false;
        }

        if (bFadeU32poure)
        {
            bFadeU32poure = false;
        }

        if (bFadeU32Stay)
        {
            bFadeU32Stay = false;
        }

        if (bFadeU32finish)
        {
            bFadeU32finish = false;
        }
    }
}