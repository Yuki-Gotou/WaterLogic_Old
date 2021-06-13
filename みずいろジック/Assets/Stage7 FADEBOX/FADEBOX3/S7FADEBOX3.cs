using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S7FADEBOX3 : MonoBehaviour {

    Animation fadeanim;
    public bool FadeAnimFlg;
    public int oneflag; //何か1度だけ動かしたいときに使用
    public static int count;
    public float Anime0;        // カウント用

    public static string FadeU31;         // 1→2用管理ステータス
    bool bFadeU31;          // FadeU31用フラグ
    bool bFadeU31poure;     // FadeU31poure用フラグ
    bool bFadeU31Stay;      // FadeU31Stay用フラグ
    bool bFadeU31finish;    // FadeU31Stayfinish用フラグ

    public static string FadeU32;         // 1→3用管理ステータス
    bool bFadeU32;          // FadeU32用フラグ
    bool bFadeU32poure;     // FadeU32poure用フラグ
    bool bFadeU32Stay;      // FadeU32Stay用フラグ
    bool bFadeU32finish;    // FadeU32Stayfinish用フラグ

    public static string FadeU34;         // 1→4用管理ステータス
    bool bFadeU34;          // FadeU34用フラグ
    bool bFadeU34poure;     // FadeU34poure用フラグ
    bool bFadeU34Stay;      // FadeU34Stay用フラグ
    bool bFadeU34finish;    // FadeU34Stayfinish用フラグ

    public int a;

    void Start()
    {
        fadeanim = gameObject.GetComponent<Animation>();
        FadeAnimFlg = false;
        oneflag = 0;
        Anime0 = 0.0f;    // カウント用初期化
        Debug.Log("Animation1");
        FadeU31 = "No";
        FadeU32 = "No";
        FadeU34 = "No";

        // アニメーション用のフラグ初期化
        bFadeU31 = false;
        bFadeU31poure = false;
        bFadeU31Stay = false;
        bFadeU31finish = false;
        bFadeU32 = false;
        bFadeU32poure = false;
        bFadeU32Stay = false;
        bFadeU32finish = false;
        bFadeU34 = false;
        bFadeU34poure = false;
        bFadeU34Stay = false;
        bFadeU34finish = false;
    }

    void Update()
    {
        // 1→2
        switch (FadeU31)
        {
            case "No":
                //                wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["7 FADEBOX 31"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 61;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["7 FADEBOX 31 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31poure = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 611;
                    NWLB3.GF = 1;
                    NWLB1.GF = 1;
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
                if (Anime0 > fadeanim["7 FADEBOX 31 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 61111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                //KMath4.animationf = 0;
                if (Anime0 > fadeanim["7 FADEBOX 31 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU31finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU31 = "No";
                }
                break;
        }

        // 1→3
        switch (FadeU32)
        {
            case "No":
                //                wave1.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                wave1.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["7 FADEBOX 32"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 41;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["7 FADEBOX 32 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32poure = true;
                    KMath4.animationf = 411;
                    NWLB3.GF = 1;
                    NWLB2.GF = 1;
                    Anime0 = 0.0f;
                    oneflag = 1;
                }
                oneflag = 0;
                break;
            case "Stop":
                break;
            case "Stay":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["7 FADEBOX 32 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 41111;
                }
                //                //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["7 FADEBOX 32 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU32 = "No";
                }
                //KMath4.animationf = 0;
                break;
        }

        // 1→4
        switch (FadeU34)
        {
            case "No":
                //                        wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                a = KMath4.animationf;                            //                        wave.SetAlpha(0.0f);        // 波のアルファ値の設定
                Debug.Log("OKです", gameObject);
                Debug.Log(KMath4.animationf);
                a = KMath4.animationf;
                KMath4.animationf = 9;
                Debug.Log(KMath4.animationf);
                if (Anime0 > fadeanim["7 FADEBOX 34"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU34 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 91;
                    Debug.Log(KMath4.animationf);
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["7 FADEBOX 34 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU34poure = true;
                    KMath4.animationf = 911;
                    Debug.Log(KMath4.animationf);
                    NWLB3.GF = 1;
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

                if (Anime0 > fadeanim["7 FADEBOX 34 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 91111;
                }
                //                        //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["7 FADEBOX 34 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU32finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU34 = "No";
                }
                //KMath4.animationf = 0;
                break;
        }

        AnimeFlag();        // 各フラグの中身処理
        U31Animation();     // アニメーション1→2動かす
        U32Animation();     // アニメーション1→3動かす
        U34Animation();     // アニメーション1→3動かす
    }


    // アニメーション1→2動かす
    void U31Animation()
    {
        if (KMath4.animationf == 6/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～2移動
            fadeanim.Play("7 FADEBOX 31");
            //Anime0 = anim["U 31 Animation"].length;
            FadeU31 = "Normal";
        }

        if (KMath4.animationf == 61 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～2傾き
            fadeanim.Play("7 FADEBOX 31 poure");
            FadeU31 = "poure";
        }
        if (KMath4.animationf == 6111)
        {
            //1～2戻る
            fadeanim.Play("7 FADEBOX 31 Stay");
            FadeU31 = "Stay";
        }

        if (KMath4.animationf == 61111)
        {
            //1～2消える
            fadeanim.Play("7 FADEBOX 31 Finish");
            FadeU31 = "finish";
        }
    }

    // アニメーション1→3動かす
    void U32Animation()
    {
        if (KMath4.animationf == 4/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim.Play("7 FADEBOX 32");
            FadeU32 = "Normal";
        }

        if (KMath4.animationf == 41 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim.Play("7 FADEBOX 32 poure");
            FadeU32 = "poure";
        }
        if (KMath4.animationf == 4111)
        {
            //1～3戻る
            fadeanim.Play("7 FADEBOX 32 Stay");
            FadeU32 = "Stay";
        }

        if (KMath4.animationf == 41111)
        {
            //1～3消える
            fadeanim.Play("7 FADEBOX 32 Finish");
            FadeU32 = "finish";
        }
    }


    // アニメーション1→4動かす
    void U34Animation()
    {
        if (KMath4.animationf == 9/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～4移動
            Debug.Log("来てはいます。", gameObject);
            Debug.Log(KMath4.animationf);
            a = KMath4.animationf;
            fadeanim.Play("7 FADEBOX 34");
            FadeU34 = "Normal";
        }

        if (KMath4.animationf == 91 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～4傾き
            fadeanim.Play("7 FADEBOX 34 poure");
            FadeU34 = "poure";
        }
        if (KMath4.animationf == 9111)
        {
            //1～4戻る
            fadeanim.Play("7 FADEBOX 34 Stay");
            FadeU34 = "Stay";
        }

        if (KMath4.animationf == 91111)
        {
            //1～4消える
            fadeanim.Play("7 FADEBOX 34 Finish");
            FadeU34 = "finish";
        }
    }


    // アニメーションフラグによる結果処理
    void AnimeFlag()
    {
        // 1→2
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

        // 1→3
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


        // 1→4
        if (bFadeU34)
        {
            bFadeU34 = false;
        }

        if (bFadeU34poure)
        {
            bFadeU34poure = false;
        }

        if (bFadeU34Stay)
        {
            bFadeU34Stay = false;
        }

        if (bFadeU34finish)
        {
            bFadeU34finish = false;
        }
    }
}
