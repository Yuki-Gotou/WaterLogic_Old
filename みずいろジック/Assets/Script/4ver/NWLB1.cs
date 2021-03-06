using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NWLB1 : MonoBehaviour {
    public float XScale;
    public float MaxScale;              //容器内の最大量
    public static float NowWholeScale;         //現在の全体スケール
    public float NowYScale;             //現在のYスケール  Unity内で値指定
    public static float fNowYScale;            //外部参照用変数
    public static float ChengeScale;    //変化する値外部から値をもらってくる。
    public static float FuturNowYScale; //自身単体の増加合計値
    public static float FuturYScale;    //変化量 変化予定値を足した後
    public static float NowChangeY;            //Y変化量
    public static int ZF;
    public static int DF;
    public float a;
    public static int GF;                   //液体増加開始合図
    public static int PF;       //加算処理のみ使用
    public static int WAGF;     //水アニメーション開始合図

    // Use this for initialization
    void Start()
    {
        XScale = transform.localScale.x;
        transform.localScale = new Vector3(transform.localScale.x, NowYScale + GameObject.Find("青青1").transform.localScale.y, transform.localScale.z);
        NowWholeScale = transform.localScale.x * transform.localScale.y;
        ChengeScale = 0.0f;
        NowYScale = transform.localScale.y;
        fNowYScale = NowYScale;
        FuturNowYScale = NowYScale;
        FuturYScale = NowYScale;
        NowChangeY = 0.0f;
        ZF = 0;
        DF = 0;
        a = 0;
        GF = 0;
        PF = 0;
        WAGF = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //変化があったら入る
        if (/*ChengeScale != 0.0f || WB1.ChangeF == 1.0f ||*/ DF != 0)
        {
            Debug.Log("入ったよ");
            NowChangeY = (ChengeScale / XScale);
            ChengeScale = 0.0f;
            FuturNowYScale = NowYScale + NowChangeY;
            FuturYScale = NowYScale + NowChangeY + NWB1.NowChangeY + NWG1.NowChangeY;
            NWB1.ChangeF = 0.0f;
            a = NowWholeScale;
            DF = 0;
            if (NowYScale < FuturYScale)
            {
                WAGF = 1;
            }
        }
        if (GF == 1)
        {
            wave1.WaveGF = 1;
            //増える時
            if (NowYScale < FuturYScale)
            {
                PF = 1;
                NowYScale = NowYScale + 0.05f;
                if (NowYScale > FuturNowYScale)
                {
                    Debug.Log("終了");
                    //青に開始の合図
                    NWB1.GF = 1;
                    if (WAGF != 3&& WAGF!=4)
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
                    NowYScale = FuturYScale;
                //}
                transform.localScale = new Vector3(transform.localScale.x, NowYScale, transform.localScale.z);
                NWB1.GF = 1;
            }
            if (NowYScale == FuturNowYScale)
            {
                Debug.Log("終了2");
                //青に開始の合図
                NWB1.GF = 1;
                WAGF = 2;
            }
            if (NowYScale == FuturYScale)
            {
                Debug.Log("水色フィニッシュ", gameObject);
                GF = 2;
                Debug.Log(GF);
                Debug.Log(NWB1.GF);
                Debug.Log(NWG1.GF);
                Debug.Log(PF);
            }
        }
        if (GF == 2 && NWB1.GF == 2 && NWG1.GF == 2 && PF == 1)
        {
            Debug.Log(KMath4.animationf);
            //FADEBOX1.FadeU12 = "Stay";
            KMath4.animationf = KMath4.animationf * 10 + 1;
            Debug.Log(KMath4.animationf);
            GF = 0;
            NWB1.GF = 0;
            NWG1.GF = 0;
            PF = 0;
        }
        else if (GF == 2 && NWB1.GF == 2 && NWG1.GF == 2)
        {
            GF = 0;
            NWB1.GF = 0;
            NWG1.GF = 0;
        }
        fNowYScale = NowYScale;

    }
}
