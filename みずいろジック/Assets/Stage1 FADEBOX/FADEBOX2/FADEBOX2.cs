using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FADEBOX2 : MonoBehaviour
{
    Animation fadeanim2;
    public bool FadeAnimFlg;
    public int oneflag; //何か1度だけ動かしたいときに使用
    public static int count;
    public float Anime0;        // カウント用

    public static string FadeU21;         // 2→1用管理ステータス
    bool bFadeU21;          // FadeU21用フラグ
    bool bFadeU21poure;     // FadeU21poure用フラグ
    bool bFadeU21Stay;      // FadeU21Stay用フラグ
    bool bFadeU21finish;    // FadeU21Stayfinish用フラグ

    public static string FadeU23;         // 2→3用管理ステータス
    bool bFadeU23;          // FadeU23用フラグ
    bool bFadeU23poure;     // FadeU23poure用フラグ
    bool bFadeU23Stay;      // FadeU23Stay用フラグ
    bool bFadeU23finish;    // FadeU23Stayfinish用フラグ

    void Start()
    {
        fadeanim2 = this.gameObject.GetComponent<Animation>();
        FadeAnimFlg = false;
        oneflag = 0;
        count = 0;
        Anime0 = 0.0f;    // カウント用初期化
        Debug.Log("Animation2");

        // アニメーション用のフラグ初期化
        bFadeU21 = false;
        bFadeU21poure = false;
        bFadeU21Stay = false;
        bFadeU21finish = false;
        bFadeU23 = false;
        bFadeU23poure = false;
        bFadeU23Stay = false;
        bFadeU23finish = false;
    }

    void Update()
    {
        // 2→1
        switch (FadeU21)
        {
            case "No":
                //wave2.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                //wave2.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim2["FADEBOX 21"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21 = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 21;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim2["FADEBOX 21 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21poure = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 211;
                    WLB2.GF = 1;
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
                if (Anime0 > fadeanim2["FADEBOX 21 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21Stay = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 21111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim2["FADEBOX 21 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU21finish = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 0;
                    FadeU21 = "No";
                }
                break;
        }

        // 2→3
        switch (FadeU23)
        {
            case "No":
                //wave2.SetAlpha(1.0f);        // 波のアルファ値の設定
                break;
            case "Normal":
                Anime0 += Time.deltaTime;   // 時間を入れる
                //wave2.SetAlpha(0.0f);        // 波のアルファ値の設定

                if (Anime0 > fadeanim2["FADEBOX 23"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23 = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 31;
                    oneflag = 1;
                }
                break;
            case "poure":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim2["FADEBOX 23 poure"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23poure = true;
                    KMath.animationf = 311;
                    WLB2.GF = 1;
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

                if (Anime0 > fadeanim2["FADEBOX 23 Stay"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23Stay = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 31111;
                }
                break;
            case "finish":
                Anime0 += Time.deltaTime;   // 時間を入れる

                if (Anime0 > fadeanim2["FADEBOX 23 Finish"].length)
                {// .length はアニメーションの最大の長さと思われる
                    bFadeU23finish = true;
                    Anime0 = 0.0f;
                    KMath.animationf = 0;
                    FadeU23 = "No";
                }
                break;
        }

        AnimeFlag();        // 各フラグの中身処理
        U21Animation();     // アニメーション2→1動かす
        U23Animation();     // アニメーション2→3動かす
    }

    // アニメーション2→1動かす
    void U21Animation()
    {
        if (KMath.animationf == 2/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //2～1移動
            fadeanim2.Play("FADEBOX 21");
            FadeU21 = "Normal";
        }

        if (KMath.animationf == 21 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //2～1傾き
            fadeanim2.Play("FADEBOX 21 poure");
            FadeU21 = "poure";
        }

        if (KMath.animationf == 2111)
        {
            //2～1戻る
            fadeanim2.Play("FADEBOX 21 Stay");
            FadeU21 = "Stay";
        }

        if (KMath.animationf == 21111)
        {
            //2～1消える
            fadeanim2.Play("FADEBOX 21 Finish");
            FadeU21 = "finish";
        }
    }

    // アニメーション2→3動かす
    void U23Animation()
    {
        if (KMath.animationf == 3/*Input.GetKey(KeyCode.Alpha1)*/)
        {
            //1～3移動
            fadeanim2.Play("FADEBOX 23");
            FadeU23 = "Normal";
        }

        if (KMath.animationf == 31 && oneflag == 1/*Input.GetKey(KeyCode.F1)*/)
        {
            //1～3傾き
            fadeanim2.Play("FADEBOX 23 poure");
            FadeU23 = "poure";
        }
        if (KMath.animationf == 3111)
        {
            //1～3戻る
            fadeanim2.Play("FADEBOX 23 Stay");
            FadeU23 = "Stay";
        }

        if (KMath.animationf == 31111)
        {
            //1～3消える
            fadeanim2.Play("FADEBOX 23 Finish");
            FadeU23 = "finish";
        }
    }

    // アニメーションフラグによる結果処理
    void AnimeFlag()
    {
        // 2→1
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

        // 2→3
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
    }
}