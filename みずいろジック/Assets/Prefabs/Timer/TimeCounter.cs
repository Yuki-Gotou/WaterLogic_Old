using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Sprite[] numimage;   // 使用する画像

    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    [SerializeField]
    private float comma;
    //　前のUpdateの時の秒数
    private float oldSeconds;
    //　前のUpdateの時のコンマ秒数
    private float oldcomma;
    //　タイマー表示用テキスト
    private Text timerText;

    public static int   fminute;
    public static float fseconds;
    public static float fcomma;

    static public int rsScore;  // スコア格納用
        int MAX_Digit;           // 桁数の設定
        int tmpComma;            // 計算用(タイム、コンマ)
        int tmpSecond;            // 計算用(タイム、秒)
        int tmpMinute;            // 計算用(タイム、分)
        int nDigit;              // 計算用(桁)
        public GameObject[] Digit;  // 桁用オブジェクト

        public static bool Timeflg;
        public static bool SEFlg;

    public AudioSource sound01;
    void Start()
    {
        minute = 0;
        seconds = 0f;
        comma = 0f;
        oldSeconds = 0f;
        oldcomma = 0f;
        timerText = GetComponentInChildren<Text>();
        Timeflg = false;
        MAX_Digit = 2;          // 各桁数の設定
        nDigit = MAX_Digit;     // 計算用(桁)
        sound01 = GetComponent<AudioSource>();
        SEFlg = false;
    }

    void Update()
    {
        if (Timeflg == true)
        {
            if (SEFlg == false)
            {
                sound01.PlayOneShot(sound01.clip);
                SEFlg = true;
            }
        }


        if (Timeflg == true)
        {
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }

            comma += Time.deltaTime * 99;
            if (comma >= 99f)
            {
                seconds++;
                comma = comma - 99;
            }
            tmpComma = (int)comma;          // 計算用(スコア)
            tmpSecond = (int)seconds;          // 計算用(スコア)
            tmpMinute = minute;          // 計算用(スコア)
        }
        //timerText.text = minute.ToString("00")+
        //    ":" + ((int)seconds).ToString("00")+ 
        //    ":" + ((int)comma).ToString("00");



        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {// コンマ用
            int number = 0;         // 計算結果格納用
            number = tmpComma % 10;
            tmpComma /= 10;

            SetTextureComma(nCntPlace, number);     // テクスチャのセット
        }

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {// 秒
            int number = 0;         // 計算結果格納用
            number = tmpSecond % 10;
            tmpSecond /= 10;

            SetTextureSecond(nCntPlace, number);     // テクスチャのセット
        }

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {// 分
            int number = 0;         // 計算結果格納用
            number = tmpMinute % 10;
            tmpMinute /= 10;

            SetTextureMinute(nCntPlace, number);     // テクスチャのセット
        }

        oldSeconds = seconds;
        oldcomma = comma;

        fminute =minute;
        fseconds=seconds;
        fcomma=comma;
    }

    void SetTextureComma(int nPlace, int number)
    {
        Digit[nPlace+4].GetComponent<SpriteRenderer>().sprite = numimage[number];
    }

    void SetTextureSecond(int nPlace, int number)
    {
        Digit[nPlace+2].GetComponent<SpriteRenderer>().sprite = numimage[number];
    }

    void SetTextureMinute(int nPlace, int number)
    {
        Digit[nPlace].GetComponent<SpriteRenderer>().sprite = numimage[number];
    }
}