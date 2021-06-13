////////////////////////////////////////////
// 
// リザルト用スコア
//      テクスチャ用
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultScore : MonoBehaviour {
    int MAX_Digit;              // 桁数
    static public int rsScore;  // スコア格納用
    public Sprite[] numimage;   // 使用する画像
    public GameObject[] Digit;  // 桁用オブジェクト

	// Use this for initialization
	void Start () {
        MAX_Digit = 5;      // 桁数の設定
        int tmp = rsScore;          // 計算用(スコア)
        int nDigit = MAX_Digit;     // 計算用(桁)

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {
            int number = 0;         // 計算結果格納用
            number = tmp % 10;
            tmp /= 10;

            SetTextureScore(nCntPlace, number);     // テクスチャのセット
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 外部呼出し：スコアのセット
    static public void SetResultScore(int NumScore)
    {
        rsScore = NumScore;
    }

    /////////////////////////////////////////////
    // 
    // テクスチャの変更
    //    引数：int nPlace     桁数
    //          int number     その桁のスコアの数字
    // 
    /////////////////////////////////////////////
    void SetTextureScore(int nPlace, int number)
    {
        Digit[nPlace].GetComponent<SpriteRenderer>().sprite = numimage[number];
    }
}
