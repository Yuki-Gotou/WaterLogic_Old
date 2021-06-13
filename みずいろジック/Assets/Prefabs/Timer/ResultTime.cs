using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultTime : MonoBehaviour {
    public Sprite[] NumberTexture;   // 使用する画像

    static public int sMinute;     // 格納用(コンマ)
    static public float sSeconds;  // 格納用(秒)
    static public float sComma;    // 格納用(分)

    //private int minute;     // 格納用(コンマ)
    //private float seconds;  // 格納用(秒)
    //private float comma;    // 格納用(分)

    static public int rsScore;  // スコア格納用
    int MAX_Digit;           // 桁数の設定
    int tmpComma;            // 計算用(タイム、コンマ)
    int tmpSecond;            // 計算用(タイム、秒)
    int tmpMinute;            // 計算用(タイム、分)
    public GameObject[] Digit;  // 桁用オブジェクト

    void Start()
    {
        MAX_Digit = 2;          // 各桁数の設定

        tmpMinute = sMinute;             // 計算用(分)
        tmpSecond = (int)sSeconds;       // 計算用(秒)
        tmpComma = (int)sComma;          // 計算用(コンマ)

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {// コンマ用
            int number = 0;         // 計算結果格納用
            number = tmpComma % 10;
            tmpComma /= 10;
            Debug.Log("ABCDEF", gameObject);

            SetTextureComma(nCntPlace, number);     // テクスチャのセット
        }

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {// 秒
            int number = 0;         // 計算結果格納用
            number = tmpSecond % 10;
            tmpSecond /= 10; 
            Debug.Log("ABCDEF", gameObject);

            SetTextureSecond(nCntPlace, number);     // テクスチャのセット
        }

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {// 分
            int number = 0;         // 計算結果格納用
            number = tmpMinute % 10;
            tmpMinute /= 10;
            Debug.Log("ABCDEF", gameObject);

            SetTextureMinute(nCntPlace, number);     // テクスチャのセット
        }
    }

    void Update()
    {
        
    }


    /////////////////////////////////////////////
    // 
    // テクスチャの変更
    //    引数：int nPlace     桁数
    //          int number     その桁の数字
    // 
    /////////////////////////////////////////////
    void SetTextureComma(int nPlace, int number)
    {// コンマ
        Digit[nPlace + 4].GetComponent<SpriteRenderer>().sprite = NumberTexture[number];
    }

    void SetTextureSecond(int nPlace, int number)
    {// 秒
        Digit[nPlace + 2].GetComponent<SpriteRenderer>().sprite = NumberTexture[number];
    }

    void SetTextureMinute(int nPlace, int number)
    {// 分
        Digit[nPlace].GetComponent<SpriteRenderer>().sprite = NumberTexture[number];
    }

    static public void SetResultTimer(int numMinute, float numSeconds, float numComma)
    {
        sMinute = numMinute;
        sSeconds = numSeconds;
        sComma = numComma;
    }
}                                     
                                       