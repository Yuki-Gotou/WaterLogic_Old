﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WG3 : MonoBehaviour {
    public float XScale;
    public static float NowWholeScale;         //現在の全体スケール
    public float NowYScale;         //現在のYスケール  Unity内で値指定
    public static float fNowYScale;            //外部参照用変数
    public static float ChengeScale;
    public static float FuturNowYScale; //自身単体の増加合計値
    public static float FuturYScale; //変化量 変化予定値を足した後
    public static float NowChangeY;        //Y変化量
    public static float ChangeF;
    public static int ZF;
    public static int GF;                   //液体増加開始合図

    // Use this for initialization
    void Start () {
        XScale = transform.localScale.x;
        transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
        NowWholeScale = transform.localScale.x * transform.localScale.y;
        ChengeScale = 0.0f;
        NowYScale = transform.localScale.y;
        fNowYScale = NowYScale;
        FuturNowYScale = NowYScale;
        FuturYScale = NowYScale;
        NowChangeY = 0.0f;
        ChangeF = 0.0f;
        ZF = 0;
        GF = 0;
    }

    // Update is called once per frame
    void Update () {
        //変化があったら入る
		if(/*ChengeScale!=0.0f ||*/ WLB3.DF != 0)
        {
            Debug.Log("おかしい1", gameObject);
            NowChangeY = ChengeScale/ XScale;
            ChengeScale = 0.0f;
            FuturNowYScale = NowYScale + NowChangeY;
            FuturYScale = NowYScale + NowChangeY;
            ChangeF = 1.0f;
        }
        if (GF == 1)
        {
            //増える時
            if (NowYScale < FuturYScale)
            {
                NowYScale = NowYScale + 0.05f;
                if (NowYScale > FuturNowYScale)
                {
                    //青に開始の合図
                    GF = 2;
                    WLB3.WAGF = 0;
                }
                if (NowYScale > FuturYScale)
                {
                    NowYScale = FuturYScale;
                }
                transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
            }
            //減る時
            else if (NowYScale > FuturYScale)
            {
                //NowYScale = NowYScale - 0.01f;
                //if (NowYScale < FuturNowYScale)
                //{
                //    //青に開始の合図
                //    GF = 2;
                //}
                //if (NowYScale < FuturYScale)
                //{
                    NowYScale = FuturYScale;
                //}
                GF = 2;
                transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
            }
            if (NowYScale == FuturNowYScale)
            {
                //青に開始の合図
                GF = 2;
                WLB3.WAGF = 0;
            }
            if (NowYScale == FuturYScale)
            {
                Debug.Log("緑色フィニッシュ", gameObject);
                GF = 2;
            }
        }
        fNowYScale = NowYScale;

    }
}
