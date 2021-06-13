using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WB2 : MonoBehaviour {
    public float XScale;
    public static float NowWholeScale;         //現在の全体スケール
    public float NowYScale;         //現在のYスケール  Unity内で値指定
    public static float fNowYScale;            //外部参照用変数
    public static float ChengeScale;
    public static float FuturNowYScale; //自身単体の増加合計値
    public static float FuturYScale; //変化量 変化予定値を足した後
    public static float NowChangeY;        //Y変化量
    public float a;
    public static float ChangeF;
    public static int ZF;
    public static int GF;       //開始の合図

    // Use this for initialization
    void Start () {
        XScale = transform.localScale.x;
        transform.localScale = new Vector3(transform.localScale.x, NowYScale + GameObject.Find("緑2").transform.localScale.y, transform.localScale.z);
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
        if (/*ChengeScale != 0.0f || WG2.ChangeF != 0.0f||*/WLB2.DF!=0)
        {
            NowChangeY = ChengeScale / XScale;
            ChengeScale = 0.0f;
            FuturNowYScale = NowYScale + NowChangeY;
            FuturYScale = FuturNowYScale + WG2.NowChangeY;
            a = NowYScale;
            WG2.ChangeF = 0.0f;
            ChangeF = 1.0f;
        }
        //---------------------------------------------------------------------
        //移動開始の合図がきたら
        //---------------------------------------------------------------------
        if (GF == 1)
        {
            //-----------------------------------
            //増える時
            if (NowYScale < FuturYScale)
            {
                NowYScale = NowYScale + 0.05f;
                if (NowYScale > FuturNowYScale)
                {
                    //緑に開始の合図
                    WG2.GF = 1;
                    WLB2.WAGF = 3;
                }
                if (NowYScale > FuturYScale)
                {
                    Debug.Log("青色", gameObject);
                    NowYScale = FuturYScale;
                }
                transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
            }
            //-------------------------------------
            //---------------------------------------
            //減る時
            else if (NowYScale > FuturYScale)
            {
                //NowYScale = NowYScale - 0.01f;
                //if (NowYScale < FuturNowYScale)
                //{
                //    //緑に開始の合図
                //    WG2.GF = 1;
                //}
                //if (NowYScale < FuturYScale)
                //{
                    NowYScale = FuturYScale;
                //}
                transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
                WG2.GF = 1;
            }
            //------------------------------------------
            //----------------------------------------------
            //変化終了時、変化しなかったときに入る
            if (NowYScale == FuturNowYScale)
            {
                //青に開始の合図
                WG2.GF = 1;
                WLB2.WAGF = 3;
            }
            if (NowYScale == FuturYScale)
            {
                Debug.Log("青色フィニッシュ", gameObject);
                GF = 2;
            }
            //------------------------------------------------
        }
        //-------------------------------------------------------------------------------   
        fNowYScale = NowYScale;

    }
}
