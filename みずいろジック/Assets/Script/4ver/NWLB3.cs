using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWLB3 : MonoBehaviour {
    public float XScale;
    public float MaxScale;      //
    public static float NowWholeScale; //現在の全体スケール
    public float NowYScale;         //現在のYスケール  Unity内で値指定
    public static float fNowYScale;            //外部参照用変数
    public static float ChengeScale;
    public static float FuturNowYScale; //自身単体の増加合計値
    public static float FuturYScale; //変化量 変化予定値を足した後
    public static float NowChangeY;        //Y変化量
    public static int ZF;
    public static int DF;
    public static int GF;                   //液体増加開始合図
    public static int PF;       //加算処理のみ使用
    public static int WAGF;     //水アニメーション開始合図

    // Use this for initialization
    void Start()
    {
        XScale = transform.localScale.x;
        transform.localScale = new Vector3(transform.localScale.x, NowYScale + GameObject.Find("青青3").transform.localScale.y, transform.localScale.z);
        NowWholeScale = transform.localScale.x * transform.localScale.y;
        ChengeScale = 0.0f;
        NowYScale = transform.localScale.y;
        fNowYScale = NowYScale;
        FuturNowYScale = NowYScale;
        FuturYScale = NowYScale;
        NowChangeY = 0.0f;
        ZF = 0;
        DF = 0;
        GF = 0;
        PF = 0;
        WAGF = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //変化があったら入る
        if (/*ChengeScale != 0.0f || WB3.ChangeF != 0.0f||*/DF != 0)
        {
            Debug.Log("おかしい3", gameObject);
            NowChangeY = ChengeScale / XScale;
            ChengeScale = 0.0f;
            FuturNowYScale = NowYScale + NowChangeY;
            FuturYScale = NowYScale + NowChangeY + NWB3.NowChangeY + NWG3.NowChangeY;
            NWB3.ChangeF = 0.0f;
            DF = 0;
            PF = 0;
            if (NowYScale < FuturYScale)
            {
                WAGF = 1;
            }
        }
        if (GF == 1)
        {
            wave3.WaveGF = 1;
            //増える時
            if (NowYScale < FuturYScale)
            {
                PF = 1;
                NowYScale = NowYScale + 0.05f;
                if (NowYScale > FuturNowYScale)
                {
                    //青に開始の合図
                    NWB3.GF = 1;
                    if (WAGF != 3 && WAGF != 4)
                    {
                        WAGF = 2;
                    }
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
                //NowYScale--;
                //if (NowYScale <= FuturYScale)
                //{
                //    NowYScale = FuturYScale;
                //    //if (ZF == 1)
                //    //{
                //    //    NowYScale = 0.0f;
                //    //    NowChangeY = 0.0f;
                //    //    ZF = 0;
                //    //}
                //}
                NowYScale = FuturYScale;
                transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
                NWB3.GF = 1;
            }
            if (NowYScale == FuturNowYScale)
            {
                //青に開始の合図
                NWB3.GF = 1;
                WAGF = 2;
            }
            if (NowYScale == FuturYScale)
            {
                Debug.Log("水色フィニッシュ", gameObject);
                GF = 2;
            }
        }
        if (GF == 2 && NWB3.GF == 2 && NWG3.GF == 2 && PF == 1)
        {
            Debug.Log(KMath4.animationf);
            //FADEBOX1.FadeU12 = "Stay";
            KMath4.animationf = KMath4.animationf * 10 + 1;
            Debug.Log(KMath4.animationf);
            GF = 0;
            NWB3.GF = 0;
            NWG3.GF = 0;
            //PF = 0;
        }
        else if (GF == 2 && NWB3.GF == 2 && NWG3.GF == 2)
        {
            Debug.Log(KMath4.animationf);
            GF = 0;
            NWB3.GF = 0;
            NWG3.GF = 0;
        }
        fNowYScale = NowYScale;

    }
}
