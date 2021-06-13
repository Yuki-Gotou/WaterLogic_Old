using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2FADEBOX4 : MonoBehaviour {
    Animation fadeanim;
    public bool FadeAnimFlg;
    public int oneflag; //何か1度だけ動かしたいときに使用
    public static int count;
    public float Anime0;        // カウント用

    public static string FadeU41;         // 1→2用管理ステータス
    bool bFadeU41;          // FadeU41用フラグ
    bool bFadeU41poure;     // FadeU41poure用フラグ
    bool bFadeU41Stay;      // FadeU41Stay用フラグ
    bool bFadeU41finish;    // FadeU41Stayfinish用フラグ

    public static string FadeU42;         // 1→3用管理ステータス
    bool bFadeU42;          // FadeU42用フラグ
    bool bFadeU42poure;     // FadeU42poure用フラグ
    bool bFadeU42Stay;      // FadeU42Stay用フラグ
    bool bFadeU42finish;    // FadeU42Stayfinish用フラグ

    public static string FadeU43;         // 1→4用管理ステータス
    bool bFadeU43;          // FadeU43用フラグ
    bool bFadeU43poure;     // FadeU43poure用フラグ
    bool bFadeU43Stay;      // FadeU43Stay用フラグ
    bool bFadeU43finish;    // FadeU43Stayfinish用フラグ

    void Start()
    {
        fadeanim = gameObject.GetComponent<Animation>();
        FadeAnimFlg = false;
        oneflag = 0;
        Anime0 = 0.0f;    // カウント用初期化
        Debug.Log("Animation1");
        FadeU41 = "No";
        FadeU42 = "No";
        FadeU43 = "No";

        // アニメーション用のフラグ初期化
        bFadeU41 = false;
        bFadeU41poure = false;
        bFadeU41Stay = false;
        bFadeU41finish = false;
        bFadeU42 = false;
        bFadeU42poure = false;
        bFadeU42Stay = false;
        bFadeU42finish = false;
        bFadeU43 = false;
        bFadeU43poure = false;
        bFadeU43Stay = false;
        bFadeU43finish = false;
    }

    void Update()
    {
        // 1→2
        switch (FadeU41)
        {
            case "No":
                //                //wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                //wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["2 FADEBOX 41"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU41 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 101;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["2 FADEBOX 41 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU41poure = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 1011;
                    WLB4.GF = 1;
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
                if (Anime0 > fadeanim["2 FADEBOX 41 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU41Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 101111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                //KMath4.animationf = 0;
                if (Anime0 > fadeanim["2 FADEBOX 41 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU41finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU41 = "No";
                }
                break;
        }

        // 1→3
        switch (FadeU42)
        {
            case "No":
                //                //wave1.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                //wave1.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["2 FADEBOX 42"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU42 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 121;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["2 FADEBOX 42 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU42poure = true;
                    KMath4.animationf = 1211;
                    WLB4.GF = 1;
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

                if (Anime0 > fadeanim["2 FADEBOX 42 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU42Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 121111;
                }
                //                //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["2 FADEBOX 42 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU42finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU42 = "No";
                }
                //KMath4.animationf = 0;
                break;
        }

        // 1→4
        switch (FadeU43)
        {
            case "No":
                //                        //wave.SetAlpha(1.0f);        // 波のアルファ値の設定
                Debug.Log("NO", gameObject);
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                                            //                        //wave.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim["2 FADEBOX 43"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU43 = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 131;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["2 FADEBOX 43 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU43poure = true;
                    KMath4.animationf = 1311;
                    WLB4.GF = 1;
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

                if (Anime0 > fadeanim["2 FADEBOX 43 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU42Stay = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 131111;
                }
                //                        //Water1.count = 0;
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim["2 FADEBOX 43 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU42finish = true;
                    Anime0 = 0.0f;
                    KMath4.animationf = 0;
                    FadeU43 = "No";
                    Debug.Log(KMath4.animationf);
                    Debug.Log("あｓｄ", gameObject);
                }
                //KMath4.animationf = 0;
                break;
        }

        AnimeFlag();        // 各フラグの中身処理
        U41Animation();     // アニメーション1→2動かす
        U42Animation();     // アニメーション1→3動かす
        U43Animation();     // アニメーション1→3動かす
    }


    // アニメーション1→2動かす
    void U41Animation()
    {
        if (KMath4.animationf == 10/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～2移動
            fadeanim.Play("2 FADEBOX 41");
            //Anime0 = anim["U 41 Animation"].length;
            FadeU41 = "Normal";
        }

        if (KMath4.animationf == 101 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～2傾き
            fadeanim.Play("2 FADEBOX 41 poure");
            FadeU41 = "poure";
        }
        if (KMath4.animationf == 10111)
        {
            //1～2戻る
            fadeanim.Play("2 FADEBOX 41 Stay");
            FadeU41 = "Stay";
        }

        if (KMath4.animationf == 101111)
        {
            //1～2消える
            fadeanim.Play("2 FADEBOX 41 Finish");
            FadeU41 = "finish";
        }
    }

    // アニメーション1→3動かす
    void U42Animation()
    {
        if (KMath4.animationf == 12/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim.Play("2 FADEBOX 42");
            FadeU42 = "Normal";
        }

        if (KMath4.animationf == 121 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim.Play("2 FADEBOX 42 poure");
            FadeU42 = "poure";
        }
        if (KMath4.animationf == 12111)
        {
            //1～3戻る
            fadeanim.Play("2 FADEBOX 42 Stay");
            FadeU42 = "Stay";
        }

        if (KMath4.animationf == 121111)
        {
            //1～3消える
            fadeanim.Play("2 FADEBOX 42 Finish");
            FadeU42 = "finish";
        }
    }


    // アニメーション1→4動かす
    void U43Animation()
    {
        if (KMath4.animationf == 13/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～4移動
            fadeanim.Play("2 FADEBOX 43");
            FadeU43 = "Normal";
        }

        if (KMath4.animationf == 131 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～4傾き
            fadeanim.Play("2 FADEBOX 43 poure");
            FadeU43 = "poure";
        }
        if (KMath4.animationf == 13111)
        {
            //1～4戻る
            fadeanim.Play("2 FADEBOX 43 Stay");
            FadeU43 = "Stay";
        }

        if (KMath4.animationf == 131111)
        {
            //1～4消える
            fadeanim.Play("2 FADEBOX 43 Finish");
            FadeU43 = "finish";
        }
    }


    // アニメーションフラグによる結果処理
    void AnimeFlag()
    {
        // 1→2
        if (bFadeU41)
        {
            bFadeU41 = false;
        }

        if (bFadeU41poure)
        {
            bFadeU41poure = false;
        }

        if (bFadeU41Stay)
        {
            bFadeU41Stay = false;
        }

        if (bFadeU41finish)
        {
            bFadeU41finish = false;
        }

        // 1→3
        if (bFadeU42)
        {
            bFadeU42 = false;
        }

        if (bFadeU42poure)
        {
            bFadeU42poure = false;
        }

        if (bFadeU42Stay)
        {
            bFadeU42Stay = false;
        }

        if (bFadeU42finish)
        {
            bFadeU42finish = false;
        }


        // 1→4
        if (bFadeU43)
        {
            bFadeU43 = false;
        }

        if (bFadeU43poure)
        {
            bFadeU43poure = false;
        }

        if (bFadeU43Stay)
        {
            bFadeU43Stay = false;
        }

        if (bFadeU43finish)
        {
            bFadeU43finish = false;
        }
    }
}
