using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5FADEBOX2 : MonoBehaviour {
    Animation fadeanim;
    public bool FadeAnimFlg;
    public int oneflag; //何か1度だけ動かしたいときに使用
    public static int count;
    public float Anime0;        // カウント用

    public static string FadeU21;         // 1→2用管理ステータス
    bool bFadeU21;          // FadeU21用フラグ
    bool bFadeU21poure;     // FadeU21poure用フラグ
    bool bFadeU21Stay;      // FadeU21Stay用フラグ
    bool bFadeU21finish;    // FadeU21Stayfinish用フラグ

    public static string FadeU23;         // 1→3用管理ステータス
    bool bFadeU23;          // FadeU23用フラグ
    bool bFadeU23poure;     // FadeU23poure用フラグ
    bool bFadeU23Stay;      // FadeU23Stay用フラグ
    bool bFadeU23finish;    // FadeU23Stayfinish用フラグ

    public static string FadeU24;         // 1→4用管理ステータス
    bool bFadeU24;          // FadeU24用フラグ
    bool bFadeU24poure;     // FadeU24poure用フラグ
    bool bFadeU24Stay;      // FadeU24Stay用フラグ
    bool bFadeU24finish;    // FadeU24Stayfinish用フラグ

    void Start()
    {
        fadeanim = gameObject.GetComponent<Animation>();
        FadeAnimFlg = false;
        oneflag = 0;
        Anime0 = 0.0f;    // カウント用初期化
        Debug.Log("Animation1");
        FadeU21 = "No";

        // アニメーション用のフラグ初期化
        bFadeU21 = false;
        bFadeU21poure = false;
        bFadeU21Stay = false;
        bFadeU21finish = false;
        bFadeU23 = false;
        bFadeU23poure = false;
        bFadeU23Stay = false;
        bFadeU23finish = false;
        bFadeU24 = false;
        bFadeU24poure = false;
        bFadeU24Stay = false;
        bFadeU24finish = false;
    }

    void Update()
    {
        // 1→2
        switch (FadeU21)
        {
            case "No":
                //wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["5 FADEBOX 21"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 21;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["5 FADEBOX 21 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21poure = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 211;
                    NWLB2.GF = 1;
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
                if (Anime0 > fadeanim["5 FADEBOX 21 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 21111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                //KMath4.animationf = 0;
                if (Anime0 > fadeanim["5 FADEBOX 21 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU21 = "No";
                }
                break;
        }

        // 1→3
        switch (FadeU23)
        {
            case "No":
                //                wave1.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                wave1.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["5 FADEBOX 23"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 31;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["5 FADEBOX 23 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23poure = true;
                    KMath4.animationf = 311;
                    NWLB2.GF = 1;
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

                if (Anime0 > fadeanim["5 FADEBOX 23 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 31111;
                }
                //                //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["5 FADEBOX 23 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU23 = "No";
                }
                //KMath4.animationf = 0;
                break;
        }

        // 1→4
        switch (FadeU24)
        {
            case "No":
                //                        wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                        wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["5 FADEBOX 24"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU24 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 81;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["5 FADEBOX 24 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU24poure = true;
                    KMath4.animationf = 811;
                    NWLB2.GF = 1;
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

                if (Anime0 > fadeanim["5 FADEBOX 24 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 81111;
                }
                //                        //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["5 FADEBOX 24 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU24 = "No";
                }
                //KMath4.animationf = 0;
                break;
        }

        AnimeFlag();        // 各フラグの中身処理
        U21Animation();     // アニメーション1→2動かす
        U23Animation();     // アニメーション1→3動かす
        U24Animation();     // アニメーション1→3動かす
    }


    // アニメーション1→2動かす
    void U21Animation()
    {
        if (KMath4.animationf == 2/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～2移動
            fadeanim.Play("5 FADEBOX 21");
            //Anime0 = anim["U 21 Animation"].length;
            FadeU21 = "Normal";
        }

        if (KMath4.animationf == 21 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～2傾き
            fadeanim.Play("5 FADEBOX 21 poure");
            FadeU21 = "poure";
        }
        if (KMath4.animationf == 2111)
        {
            //1～2戻る
            Debug.Log("行きました。", gameObject);
            fadeanim.Play("5 FADEBOX 21 Stay");
            FadeU21 = "Stay";
        }

        if (KMath4.animationf == 21111)
        {
            //1～2消える
            fadeanim.Play("5 FADEBOX 21 Finish");
            FadeU21 = "finish";
        }
    }

    // アニメーション1→3動かす
    void U23Animation()
    {
        if (KMath4.animationf == 3/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim.Play("5 FADEBOX 23");
            FadeU23 = "Normal";
        }

        if (KMath4.animationf == 31 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim.Play("5 FADEBOX 23 poure");
            FadeU23 = "poure";
        }
        if (KMath4.animationf == 3111)
        {
            //1～3戻る
            fadeanim.Play("5 FADEBOX 23 Stay");
            FadeU23 = "Stay";
        }

        if (KMath4.animationf == 31111)
        {
            //1～3消える
            fadeanim.Play("5 FADEBOX 23 Finish");
            FadeU23 = "finish";
        }
    }


    // アニメーション1→4動かす
    void U24Animation()
    {
        if (KMath4.animationf == 8/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～4移動
            fadeanim.Play("5 FADEBOX 24");
            FadeU24 = "Normal";
        }

        if (KMath4.animationf == 81 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～4傾き
            fadeanim.Play("5 FADEBOX 24 poure");
            FadeU24 = "poure";
        }
        if (KMath4.animationf == 8111)
        {
            //1～4戻る
            fadeanim.Play("5 FADEBOX 24 Stay");
            FadeU24 = "Stay";
        }

        if (KMath4.animationf == 81111)
        {
            //1～4消える
            fadeanim.Play("5 FADEBOX 24 Finish");
            FadeU24 = "finish";
        }
    }


    // アニメーションフラグによる結果処理
    void AnimeFlag()
    {
        // 1→2
        if (bFadeU21)
        {
            bFadeU21 = false;
        }

        if (bFadeU21poure)
        {
            bFadeU21poure = false;
        }

        if (bFadeU21Stay)
        {
            bFadeU21Stay = false;
        }

        if (bFadeU21finish)
        {
            bFadeU21finish = false;
        }

        // 1→3
        if (bFadeU23)
        {
            bFadeU23 = false;
        }

        if (bFadeU23poure)
        {
            bFadeU23poure = false;
        }

        if (bFadeU23Stay)
        {
            bFadeU23Stay = false;
        }

        if (bFadeU23finish)
        {
            bFadeU23finish = false;
        }


        // 1→4
        if (bFadeU24)
        {
            bFadeU24 = false;
        }

        if (bFadeU24poure)
        {
            bFadeU24poure = false;
        }

        if (bFadeU24Stay)
        {
            bFadeU24Stay = false;
        }

        if (bFadeU24finish)
        {
            bFadeU24finish = false;
        }
    }
}
