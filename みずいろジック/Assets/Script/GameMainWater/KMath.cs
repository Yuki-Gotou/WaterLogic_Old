using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KMath : MonoBehaviour {
    public int MaxNumber;   //最大容器数
    public int MinNumber;   //最小容器数
    //1←.2中.3→
    public int NowNumber;   //現在の選択番号
    //1←.2中.3→
    public static int utusugawa;
    public int utusarerugawa;
    public int count;       //連打防止用
    public static int Playerf;
    public static int animationf;   //アニメーション再生中か、停止中。  0停止中1再生中
    public float OldPosX;    //移動前
    public float FuturPosX;  //移動予定
    public float idouryou;  //移動用の変数

    //---------------------------------------------
    //3容器分の変数
    //---------------------------------------------
    //水色
    public static float CWLB1;
    public static float CWLB2;
    public static float CWLB3;
    //青
    public static float CWB1;
    public static float CWB2;
    public static float CWB3;
    //緑
    public static float CWG1;
    public static float CWG2;
    public static float CWG3;
    //各容器の現在の容積
    public float NBox1;
    public float NBox2;
    public float NBox3;
    //各容器の最大容積
    public float MBox1;
    public float MBox2;
    public float MBox3;
    //各容器の余剰容積
    public float SBox1;
    public float SBox2;
    public float SBox3;
    //各容器変化量
    public float CBox1;
    public float CBox2;
    public float CBox3;
    //各容器ごとに、液体の種類による変化量の格納
    public float CBoxLB1;
    public float CBoxB1;
    public float CBoxG1;
    public float CBoxLB2;
    public float CBoxB2;
    public float CBoxG2;
    public float CBoxLB3;
    public float CBoxB3;
    public float CBoxG3;
    //---------------------------------------------

    // Use this for initialization
    void Start () {
        //plas = 0.0f;
        //mainasu=0.0f;
        NowNumber = 1;
        utusugawa = 0;
        utusarerugawa = 0;
        count = 10;
        Playerf = 0;
        //1.1→2,2.2→1,3.2→3,4.3→2,5.1→3,6.3→1
        //112131415161
        animationf = 0;
        GameObject.Find("カーソル").transform.localPosition = new Vector3(GameObject.Find("青1").transform.localPosition.x, transform.localPosition.y, 0.0f);
        OldPosX = transform.localPosition.x;    //初期X座標代入
        FuturPosX = transform.localPosition.x;  //初期X座標代入
        idouryou = 0.0f;
        CWG1 =WG1.NowWholeScale;
        CWG2 =WG2.NowWholeScale;
        CWG3 =WG3.NowWholeScale;

        CWB1= WB1.NowWholeScale - CWG1;
        CWB2 =WB2.NowWholeScale- CWG2;
        CWB3 =WB3.NowWholeScale- CWG3;

        CWLB1=WLB1.NowWholeScale- CWB1- CWG1;
        CWLB2=WLB2.NowWholeScale- CWB2 - CWG2;
        CWLB3=WLB3.NowWholeScale - CWB3 - CWG3;
        NBox1 = CWLB1+ CWB1+ CWG1;
        NBox2 = CWLB2 + CWB2 + CWG2;
        NBox3 = CWLB3 + CWB3 + CWG3;
        SBox1 = MBox1 - NBox1;
        SBox2 = MBox2 - NBox2;
        SBox3 = MBox3 - NBox3;
        CBox1 = 0.0f;
        CBox2 = 0.0f;
        CBox3 = 0.0f;
        CBoxLB1 = 0.0f;
        CBoxB1 = 0.0f;
        CBoxG1 = 0.0f;
        CBoxLB2 = 0.0f;
        CBoxB2 = 0.0f;
        CBoxG2 = 0.0f;
        CBoxLB3 = 0.0f;
        CBoxB3 = 0.0f;
        CBoxG3 = 0.0f;
        KMath4.animationf = 0;

    }

    // Update is called once per frame
    void Update () {
        if (animationf == 0)
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 1);
            //=========================================================================
            //オブジェクト選択
            if ((FuturPosX - 1.0f < transform.localPosition.x && FuturPosX + 1.0f > transform.localPosition.x))
            {
                //--------------------------------------------------------------
                //キー操作
                if ((Input.GetAxis("LeftStickX") < 0 || Input.GetKey(KeyCode.A)) && (FuturPosX - 1.0f < transform.localPosition.x && FuturPosX + 1.0f > transform.localPosition.x))
                {
                    if (NowNumber != 1)
                    {
                        NowNumber--;
                    }
                    idouryou = -0.5f;
                    count = 0;
                }
                if ((Input.GetAxis("LeftStickX") > 0 || Input.GetKey(KeyCode.D)) && (FuturPosX - 1.0f < transform.localPosition.x && FuturPosX + 1.0f > transform.localPosition.x))
                {
                    if (NowNumber != 3)
                    {
                        NowNumber++;
                    }
                    idouryou = 0.5f;
                    count = 0;
                }
                //---------------------------------------------------------------
            }
            switch (NowNumber)
            {
                case 1:
                    FuturPosX = GameObject.Find("青1").transform.localPosition.x;
                    break;
                case 2:
                    FuturPosX = GameObject.Find("青2").transform.localPosition.x;
                    break;
                case 3:
                    FuturPosX = GameObject.Find("青3").transform.localPosition.x;
                    break;
            }
            if (FuturPosX - 1.0f < transform.localPosition.x && FuturPosX + 1.0f > transform.localPosition.x)
            {
                GameObject.Find("カーソル").transform.localPosition = new Vector3(FuturPosX, transform.localPosition.y, transform.localPosition.z);
            }
            else
            {
                GameObject.Find("カーソル").transform.localPosition = new Vector3(transform.localPosition.x + idouryou, transform.localPosition.y, transform.localPosition.z);
            }
            //---------------------------------------------------------------
            //容器選択
            if ((Input.GetKeyUp(KeyCode.Joystick1Button0) || Input.GetKeyUp(KeyCode.Space)) && count >= 10)
            {
                if (utusugawa == 0)
                {
                    utusugawa = NowNumber;
                }
                else if (utusugawa != NowNumber && utusarerugawa == 0)
                {
                    utusarerugawa = NowNumber;
                }
            }
            //---------------------------------------------------------------------------
            if(utusugawa!=0)
            {
                switch(utusugawa)
                {
                    case 1:
                        if(NBox1==0)
                        {
                            utusugawa = 0;
                        }
                        break;
                    case 2:
                        if (NBox2 == 0)
                        {
                            utusugawa = 0;
                        }
                        break;
                    case 3:
                        if (NBox3 == 0)
                        {
                            utusugawa = 0;
                        }
                        break;
                }
            }
            if(utusarerugawa!=0)
            {
                switch(utusarerugawa)
                {
                    case 1:
                        if(SBox1==0)
                        {
                            utusarerugawa = 0;
                        }
                        break;
                    case 2:
                        if (SBox2 == 0)
                        {
                            utusarerugawa = 0;
                        }
                        break;
                    case 3:
                        if (SBox3 == 0)
                        {
                            utusarerugawa = 0;
                        }
                        break;
                }
            }
            //=========================================================================
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, 0);
        }
        //---------------------------------------------------------------------------
        //移動指示
        if (utusugawa!=0&& utusarerugawa!=0)
        {
            switch (utusugawa)
            {
                case 1:
                    switch (utusarerugawa)
                    {
                        case 2:
                            animationf = 1;
                            //移す側が多い場合
                            if(NBox1>=SBox2)
                            {
                                Debug.Log("122", gameObject);
                                Math1(SBox2, utusugawa);
                                MMath1();
                                Math2(utusarerugawa, CBoxLB1, CBoxB1, CBoxG1);
                                //Math(SBox2, utusugawa, utusarerugawa);
                            }
                            //移される側の空きが多い場合
                            if (NBox1 < SBox2)
                            {
                                Debug.Log("121", gameObject);
                                Math1(NBox1, utusugawa);
                                MMath1();
                                Math2(utusarerugawa, CBoxLB1, CBoxB1, CBoxG1);
                                //Math(NBox1, utusugawa, utusarerugawa);
                            }
                            break;
                        case 3:
                            animationf = 5;
                            if (NBox1 >= SBox3)
                            {
                                Debug.Log("133", gameObject);
                                Math1(SBox3, utusugawa);
                                MMath1();
                                Math2(utusarerugawa, CBoxLB1, CBoxB1, CBoxG1);
                                //Math(WMath3.NowSpace, utusugawa, utusarerugawa);
                            }
                            //移される側の空きが多い場合
                            if (NBox1 < SBox3)
                            {
                                Debug.Log("131", gameObject);
                                Math1(NBox1, utusugawa);
                                MMath1();
                                Math2(utusarerugawa, CBoxLB1, CBoxB1, CBoxG1);
                                //Math(WMath.NowVolume, utusugawa, utusarerugawa);
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (utusarerugawa)
                    {
                        case 1:
                            animationf = 2;
                            //移す側が多い場合
                            if (NBox2 >= SBox1)
                            {
                                Debug.Log("211", gameObject);
                                Math1(SBox1, utusugawa);
                                MMath2();
                                Math2(utusarerugawa, CBoxLB2, CBoxB2, CBoxG2);
                                //Math(WMath.NowSpace, utusugawa, utusarerugawa);
                            }
                            //移される側の空きが多い場合
                            if (NBox2 < SBox1)
                            {
                                Debug.Log("212", gameObject);
                                Math1(NBox2, utusugawa);
                                MMath2();
                                Math2(utusarerugawa, CBoxLB2, CBoxB2, CBoxG2);
                                //Math(WMath2.NowVolume, utusugawa, utusarerugawa);
                            }
                            break;
                        case 3:
                            animationf = 3;
                            //移す側が多い場合
                            if (NBox2 >= SBox3)
                            {
                                Debug.Log("233", gameObject);
                                Math1(SBox3, utusugawa);
                                MMath2();
                                Math2(utusarerugawa, CBoxLB2, CBoxB2, CBoxG2);
                                //Math(WMath3.NowSpace, utusugawa, utusarerugawa);
                            }
                            //移される側の空きが多い場合
                            if (NBox2 < SBox3)
                            {
                                Debug.Log("232", gameObject);
                                Math1(NBox2, utusugawa);
                                MMath2();
                                Math2(utusarerugawa, CBoxLB2, CBoxB2, CBoxG2);
                                //Math(WMath2.NowVolume, utusugawa, utusarerugawa);
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (utusarerugawa)
                    {
                        case 1:
                            animationf = 6;
                            //移す側が多い場合
                            if (NBox3 >= SBox1)
                            {
                                Debug.Log("311", gameObject);
                                Math1(SBox1, utusugawa);
                                MMath3();
                                Math2(utusarerugawa, CBoxLB3, CBoxB3, CBoxG3);
                                //Math(WMath.NowSpace, utusugawa, utusarerugawa);
                            }
                            //移される側の空きが多い場合
                            if (NBox3 < SBox1)
                            {
                                Debug.Log("313", gameObject);
                                Math1(NBox3, utusugawa);
                                MMath3();
                                Math2(utusarerugawa, CBoxLB3, CBoxB3, CBoxG3);
                                //Math(WMath3.NowVolume, utusugawa, utusarerugawa);
                            }
                            break;
                        case 2:
                            animationf = 4;
                            //移す側が多い場合
                            if (NBox3 >= SBox2)
                            {
                                Debug.Log("322", gameObject);
                                Math1(SBox2, utusugawa);
                                MMath3();
                                Math2(utusarerugawa, CBoxLB3, CBoxB3, CBoxG3);
                                //Math(WMath2.NowSpace, utusugawa, utusarerugawa);
                            }

                            //移される側の空きが多い場合
                            if (NBox3 < SBox2)
                            {
                                Debug.Log("323", gameObject);
                                Math1(NBox3, utusugawa);
                                MMath3();
                                Math2(utusarerugawa, CBoxLB3, CBoxB3, CBoxG3);
                                //Math(WMath3.NowVolume, utusugawa, utusarerugawa);
                            }
                            break;
                    }
                    break;
            }
            //各液体の種類ごとに分配
            WZ();
            WFMath(utusugawa, utusarerugawa);
            utusugawa = utusarerugawa = 0;
            count = 0;
            
        }
        count++;
    }
    //移す側の処理
    public void Math1(float atai, int utusu)
    {
        //移す側操作
        switch (utusu)
        {
            case 1:
                CBox1 = atai;
                break;
            case 2:
                CBox2 = atai;
                break;
            case 3:
                CBox3 = atai;
                break;
        }
    }

    //移される側の操作
    public void Math2(int Number,float LB,float B,float G)
    {
        switch(Number)
        {
            case 1:
                Debug.Log("11", gameObject);
                CWLB1 = CWLB1+LB;
                CWB1 = CWB1+B;
                CWG1 = CWG1+G;
                CBoxLB1 = LB;
                CBoxB1 = B;
                CBoxG1 = G;
                break;
            case 2:
                Debug.Log("22", gameObject);
                CWLB2 = CWLB2+LB;
                CWB2 = CWB2+B;
                CWG2 = CWG2+G;
                CBoxLB2 = LB;
                CBoxB2 = B;
                CBoxG2 = G;
                break;
            case 3:
                Debug.Log("33", gameObject);
                CWLB3 = CWLB3+LB;
                CWB3 = CWB3+ B;
                CWG3 = CWG3+G;
                CBoxLB3 = LB;
                CBoxB3 = B;
                CBoxG3 = G;
                break;
        }
    }

    public void MMath1()
    {
        Debug.Log("ああああ", gameObject);
        if (CBox1!=0.0f)
        {
            Debug.Log("1", gameObject);
            if (CBox1- CWLB1 > 0)
            {
                Debug.Log("2", gameObject);
                if (CBox1 - CWLB1 - CWB1 > 0)
                {
                    Debug.Log("3", gameObject);
                    if (CBox1 - CWLB1 - CWB1 - CWG1 > 0)
                    {
                        Debug.Log("予期せぬエラー1", gameObject);

                    }
                    else
                    {
                        Debug.Log("4", gameObject);
                        //変化量を格納
                        CBoxLB1 = CWLB1;
                        CBoxB1 = CWB1;
                        CBoxG1 = CBox1 - CWLB1 - CWB1;
                        //変化後を格納
                        CWLB1 = CWLB1 - CBoxLB1;
                        CWB1 = CWB1 - CBoxB1;
                        CWG1 = CWG1 - CBoxG1;
                    }
                }
                else
                {
                    //変化量を格納
                    CBoxLB1 = CWLB1;
                    CBoxB1 = CBox1 - CWLB1;
                    //変化後を格納
                    CWLB1 = CWLB1 - CBoxLB1;
                    CWB1 = CWB1 - CBoxB1;
                }
            }
            else
            {
                //変化量の格納
                CBoxLB1 = CBox1;
                //変化後を格納。
                CWLB1 = CWLB1 - CBoxLB1;
            }
        }
        CBox1 = 0.0f;
    }
    public void MMath2()
    {
        Debug.Log("ああああ", gameObject);
        if (CBox2 != 0.0f)
        {
            Debug.Log("5", gameObject);
            if (CBox2 - CWLB2 > 0)
            {
                Debug.Log("6", gameObject);
                if (CBox2 - CWLB2 - CWB2 > 0)
                {
                    Debug.Log("7", gameObject);
                    if (CBox2 - CWLB2 - CWB2 - CWG2 > 0)
                    {
                        Debug.Log("予期せぬエラー1", gameObject);

                    }
                    else
                    {
                        Debug.Log("8", gameObject);
                        //変化量を格納
                        CBoxLB2 = CWLB2;
                        CBoxB2 = CWB2;
                        CBoxG2 = CBox2 - CWLB2 - CWB2;
                        //変化後を格納
                        CWLB2 = CWLB2 - CBoxLB2;
                        CWB2 = CWB2 - CBoxB2;
                        CWG2 = CWG2 - CBoxG2;
                    }
                }
                else
                {
                    //変化量を格納
                    CBoxLB2 = CWLB2;
                    CBoxB2 = CBox2 - CWLB2;
                    //変化後を格納
                    CWLB2 = CWLB2 - CBoxLB2;
                    CWB2 = CWB2 - CBoxB2;
                }
            }
            else
            {
                //変化量の格納
                CBoxLB2 = CBox2;
                //変化後を格納。
                CWLB2 = CWLB2 - CBoxLB2;
            }
        }
        CBox2 = 0.0f;
    }
    public void MMath3()
    {
        if (CBox3 != 0.0f)
        {
            Debug.Log("9", gameObject);
            if (CBox3 - CWLB3 > 0)
            {
                Debug.Log("10", gameObject);
                if (CBox3 - CWLB3 - CWB3 > 0)
                {
                    Debug.Log("11", gameObject);
                    if (CBox3 - CWLB3 - CWB3 - CWG3 > 0)
                    {
                        Debug.Log("予期せぬエラー1", gameObject);

                    }
                    else
                    {
                        Debug.Log("12", gameObject);
                        //変化量を格納
                        CBoxLB3 = CWLB3;
                        CBoxB3 = CWB3;
                        CBoxG3 = CBox3 - CWLB3 - CWB3;
                        //変化後を格納
                        CWLB3 = CWLB3 - CBoxLB3;
                        CWB3 = CWB3 - CBoxB3;
                        CWG3 = CWG3 - CBoxG3;
                    }
                }
                else
                {
                    //変化量を格納
                    CBoxLB3 = CWLB3;
                    CBoxB3 = CBox3 - CWLB3;
                    //変化後を格納
                    CWLB3 = CWLB3 - CBoxLB3;
                    CWB3 = CWB3 - CBoxB3;
                }
            }
            else
            {
                //変化量の格納
                CBoxLB3 = CBox3;
                //変化後を格納。
                CWLB3 = CWLB3 - CBoxLB3;
            }
        }
        CBox3 = 0.0f;
    }

    public void WZ()
    {
        if(CWLB1==0.0f)
        {
            WLB1.ZF = 1;
        }
        if (CWB1 == 0.0f)
        {
            WB1.ZF = 1;
        }
        if(CWG1==0.0f)
        {
            WG1.ZF = 1;
        }

        if (CWLB2 == 0.0f)
        {
            WLB2.ZF = 1;
        }
        if (CWB2 == 0.0f)
        {
            WB2.ZF = 1;
        }
        if (CWG2 == 0.0f)
        {
            WG2.ZF = 1;
        }

        if (CWLB3 == 0.0f)
        {
            WLB3.ZF = 1;
        }
        if (CWB3 == 0.0f)
        {
            WB3.ZF = 1;
        }
        if (CWG3 == 0.0f)
        {
            WG3.ZF = 1;
        }

    }

    //変化後の値を各液体に渡す
    public void WFMath(int usutu,int utusareru)
    {
        switch (usutu)
        {
            case 1:
                Debug.Log("問題なし1", gameObject);
                WLB1.ChengeScale = -CBoxLB1;
                WB1.ChengeScale = -CBoxB1;
                WG1.ChengeScale = -CBoxG1;
                WLB1.DF = 1;
                break;
            case 2:
                WLB2.ChengeScale = -CBoxLB2;
                WB2.ChengeScale = -CBoxB2;
                WG2.ChengeScale = -CBoxG2;
                WLB2.DF = 1;
                break;
            case 3:
                WLB3.ChengeScale = -CBoxLB3;
                WB3.ChengeScale = -CBoxB3;
                WG3.ChengeScale = -CBoxG3;
                WLB3.DF = 1;
                break;
        }
        switch (utusareru)
        {
            case 1:
                Debug.Log("問題なし1", gameObject);
                WLB1.ChengeScale = CBoxLB1;
                WB1.ChengeScale = CBoxB1;
                WG1.ChengeScale = CBoxG1;
                WLB1.DF = 1;
                break;
            case 2:
                Debug.Log("問題なし2", gameObject);
                WLB2.ChengeScale = CBoxLB2;
                WB2.ChengeScale = CBoxB2;
                WG2.ChengeScale = CBoxG2;
                WLB2.DF = 1;
                break;
            case 3:
                Debug.Log("問題なし3", gameObject);
                WLB3.ChengeScale = CBoxLB3;
                WB3.ChengeScale = CBoxB3;
                WG3.ChengeScale = CBoxG3;
                WLB3.DF = 1;
                break;
        }
        WFF(usutu, utusareru);
        NBox1 = CWLB1 + CWB1 + CWG1;
        NBox2 = CWLB2 + CWB2 + CWG2;
        NBox3 = CWLB3 + CWB3 + CWG3;
        SBox1 = MBox1 - NBox1;
        SBox2 = MBox2 - NBox2;
        SBox3 = MBox3 - NBox3;
        CBox1 = 0.0f;
        CBox2 = 0.0f;
        CBox3 = 0.0f;
        CBoxLB1 = 0.0f;
        CBoxB1 = 0.0f;
        CBoxG1 = 0.0f;
        CBoxLB2 = 0.0f;
        CBoxB2 = 0.0f;
        CBoxG2 = 0.0f;
        CBoxLB3 = 0.0f;
        CBoxB3 = 0.0f;
        CBoxG3 = 0.0f;

    }

    public void WFF(int utusu,int utusareru)
    {
        switch(utusu)
        {
            case 1:
                switch(utusareru)
                {
                    case 2:
                        if(WLB1.ChengeScale!=0)
                        {
                            WhiteBlue12.GF = 1;
                        }
                        else
                        {
                            WhiteBlue12.GF = 0;
                        }
                        if(WB1.ChengeScale!=0)
                        {
                            Blue12.GF = 1;
                        }
                        else
                        {
                            Blue12.GF = 0;
                        }
                        if(WG1.ChengeScale!=0)
                        {
                            Green12.GF = 1;
                        }
                        else
                        {
                            Green12.GF = 0;
                        }
                        break;
                    case 3:
                        if (WLB1.ChengeScale != 0)
                        {
                            WhiteBlue13.GF = 1;
                        }
                        else
                        {
                            WhiteBlue13.GF = 0;
                        }
                        if (WB1.ChengeScale != 0)
                        {
                            Blue13.GF = 1;
                        }
                        else
                        {
                            Blue13.GF = 0;
                        }
                        if (WG1.ChengeScale != 0)
                        {
                            Green13.GF = 1;
                        }
                        else
                        {
                            Green13.GF = 0;
                        }
                        break;
                }
                break;
            case 2:
                switch (utusareru)
                {
                    case 1:
                        if (WLB2.ChengeScale != 0)
                        {
                            WhiteBlue21.GF = 1;
                        }
                        else
                        {
                            WhiteBlue21.GF = 0;
                        }
                        if (WB2.ChengeScale != 0)
                        {
                            Blue21.GF = 1;
                        }
                        else
                        {
                            Blue21.GF = 0;
                        }
                        if (WG2.ChengeScale != 0)
                        {
                            Green21.GF = 1;
                        }
                        else
                        {
                            Green21.GF = 0;
                        }
                        break;
                    case 3:
                        if (WLB2.ChengeScale != 0)
                        {
                            WhiteBlue23.GF = 1;
                        }
                        else
                        {
                            WhiteBlue23.GF = 0;
                        }
                        if (WB2.ChengeScale != 0)
                        {
                            Blue23.GF = 1;
                        }
                        else
                        {
                            Blue23.GF = 0;
                        }
                        if (WG2.ChengeScale != 0)
                        {
                            Green23.GF = 1;
                        }
                        else
                        {
                            Green23.GF = 0;
                        }
                        break;
                }
                break;
            case 3:
                switch (utusareru)
                {
                    case 1:
                        if (WLB3.ChengeScale != 0)
                        {
                            WhiteBlue31.GF = 1;
                        }
                        else
                        {
                            WhiteBlue31.GF = 0;
                        }
                        if (WB3.ChengeScale != 0)
                        {
                            Blue31.GF = 1;
                        }
                        else
                        {
                            Blue31.GF = 0;
                        }
                        if (WG3.ChengeScale != 0)
                        {
                            Green31.GF = 1;
                        }
                        else
                        {
                            Green31.GF = 0;
                        }
                        break;
                    case 2:
                        if (WLB3.ChengeScale != 0)
                        {
                            WhiteBlue32.GF = 1;
                        }
                        else
                        {
                            WhiteBlue32.GF = 0;
                        }
                        if (WB3.ChengeScale != 0)
                        {
                            Blue32.GF = 1;
                        }
                        else
                        {
                            Blue32.GF = 0;
                        }
                        if (WG3.ChengeScale != 0)
                        {
                            Green32.GF = 1;
                        }
                        else
                        {
                            Green32.GF = 0;
                        }
                        break;
                }
                break;
        }
    }

}
