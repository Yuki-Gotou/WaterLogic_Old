using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3FADEBOX : MonoBehaviour
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

    public static string FadeU14;         // 1→4用管理ステータス
    bool bFadeU14;          // FadeU14用フラグ
    bool bFadeU14poure;     // FadeU14poure用フラグ
    bool bFadeU14Stay;      // FadeU14Stay用フラグ
    bool bFadeU14finish;    // FadeU14Stayfinish用フラグ

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
        bFadeU14 = false;
        bFadeU14poure = false;
        bFadeU14Stay = false;
        bFadeU14finish = false;
    }

    void Update()
    {
        // 1→2
        switch (FadeU12)
        {
            case "No":
//                //wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
//                //wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["3 FADEBOX 12"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 11;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["3 FADEBOX 12 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12poure = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 111;
                    NWLB1.GF = 1;
                    NWLB2.GF = 1;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Anime0 += Time.deltaTime;   // 時間を入れる

                //KMath.animationf = 0;
//                //Water1.count = 0;
                if (Anime0 > fadeanim["3 FADEBOX 12 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 11111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                //KMath4.animationf = 0;
                if (Anime0 > fadeanim["3 FADEBOX 12 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU12finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU12 = "No";
                }
                break;
        }

        // 1→3
        switch (FadeU13)
        {
            case "No":
//                //wave1.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
//                //wave1.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["3 FADEBOX 13"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 51;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["3 FADEBOX 13 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13poure = true;
                    KMath4.animationf = 511;
                    NWLB1.GF = 1;
                    NWLB3.GF = 1;
                    Anime0 = 0.0f;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["3 FADEBOX 13 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 51111;
                }
//                //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["3 FADEBOX 13 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU13finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU13 = "No";
                }
                //KMath4.animationf = 0;
                break;
        }

                // 1→4
                switch (FadeU14)
                {
                    case "No":
//                        //wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                        break;
                    case "Normal":
                        Anime0 += Time.deltaTime;   // 時間を入れる
//                        //wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                        if (Anime0 > fadeanim["3 FADEBOX 14"].length)
                        {// .length はアニメーションの最大の長さと思われる
                            bFadeU14 = true;
                            Anime0 = 0.0f;
                            KMath4.animationf = 71;
                            oneflag = 1;
                        }
                        break;
                    case "poure":
                        Anime0 += Time.deltaTime;   // 時間を入れる

                        if (Anime0 > fadeanim["3 FADEBOX 14 poure"].length)
                        {// .length はアニメーションの最大の長さと思われる
                            bFadeU14poure = true;
                            KMath4.animationf = 711;
                            NWLB1.GF = 1;
                            WLB4.GF = 1;
                            Anime0 = 0.0f;
                            oneflag = 1;
                        }
                        oneflag = 0;
                        break;
                    case "Stop":
                        break;
                    case "Stay":
                        Anime0 += Time.deltaTime;   // 時間を入れる

                        if (Anime0 > fadeanim["3 FADEBOX 14 Stay"].length)
                        {// .length はアニメーションの最大の長さと思われる
                            bFadeU13Stay = true;
                            Anime0 = 0.0f;
                            KMath4.animationf = 71111;
                        }
//                        //Water1.count = 0;
                        break;
                    case "finish":
                        Anime0 += Time.deltaTime;   // 時間を入れる

                        if (Anime0 > fadeanim["3 FADEBOX 14 Finish"].length)
                        {// .length はアニメーションの最大の長さと思われる
                            bFadeU13finish = true;
                            Anime0 = 0.0f;
                            KMath4.animationf = 0;
                            FadeU14 = "No";
                        }
                        //KMath4.animationf = 0;
                        break;
                }

                AnimeFlag();        // 各フラグの中身処理
                U12Animation();     // アニメーション1→2動かす
                U13Animation();     // アニメーション1→3動かす
                U14Animation();     // アニメーション1→3動かす
        }
    

    // アニメーション1→2動かす
    void U12Animation()
    {
        if (KMath4.animationf == 1/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～2移動
            fadeanim.Play("3 FADEBOX 12");
            //Anime0 = anim["U 12 Animation"].length;
            FadeU12 = "Normal";
        }

        if (KMath4.animationf == 11 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～2傾き
            fadeanim.Play("3 FADEBOX 12 poure");
            FadeU12 = "poure";
        }
        if (KMath4.animationf == 1111)
        {
            //1～2戻る
            fadeanim.Play("3 FADEBOX 12 Stay");
            FadeU12 = "Stay";
        }

        if (KMath4.animationf == 11111)
        {
            //1～2消える
            fadeanim.Play("3 FADEBOX 12 Finish");
            FadeU12 = "finish";
        }
    }

    // アニメーション1→3動かす
    void U13Animation()
    {
        if (KMath4.animationf == 5/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim.Play("3 FADEBOX 13");
            FadeU13 = "Normal";
        }

        if (KMath4.animationf == 51 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim.Play("3 FADEBOX 13 poure");
            FadeU13 = "poure";
        }
        if (KMath4.animationf == 5111)
        {
            //1～3戻る
            fadeanim.Play("3 FADEBOX 13 Stay");
            FadeU13 = "Stay";
        }

        if (KMath4.animationf == 51111)
        {
            //1～3消える
            fadeanim.Play("3 FADEBOX 13 Finish");
            FadeU13 = "finish";
        }
    }


    // アニメーション1→4動かす
    void U14Animation()
    {
        if (KMath4.animationf == 7/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～4移動
            fadeanim.Play("3 FADEBOX 14");
            FadeU14 = "Normal";
        }

        if (KMath4.animationf == 71 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～4傾き
            fadeanim.Play("3 FADEBOX 14 poure");
            FadeU14 = "poure";
        }
        if (KMath4.animationf == 7111)
        {
            //1～4戻る
            fadeanim.Play("3 FADEBOX 14 Stay");
            FadeU14 = "Stay";
        }

        if (KMath4.animationf == 71111)
        {
            //1～4消える
            fadeanim.Play("3 FADEBOX 14 Finish");
            FadeU14 = "finish";
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


        // 1→4
        if (bFadeU14)
        {
            bFadeU14 = false;
        }

        if (bFadeU14poure)
        {
            bFadeU14poure = false;
        }

        if (bFadeU14Stay)
        {
            bFadeU14Stay = false;
        }

        if (bFadeU14finish)
        {
            bFadeU14finish = false;
        }
    }
}