using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Sprite[] numimage;   // 使用する画像

    public float totalTime;
    int seconds;
    //　タイマー表示用テキスト
    private Text timerText;

    static public int rsCount;  // スコア格納用
    int MAX_Digit;           // 桁数の設定
    int tmpCountDown;            // 計算用(カウントダウン)
    int nDigit;              // 計算用(桁)
    public GameObject[] Digit;  // 桁用オブジェクト
    public float MaxScaleX;
    public float MaxScaleY;
    public float MinScaleX;
    public float MinScaleY;
    public float idouX;
    public float idouY;

    public AudioSource sound01;
    public int OldNumber;

    void Start()
    {
        timerText = GetComponentInChildren<Text>();
        MAX_Digit = 1;          // 各桁数の設定
        nDigit = MAX_Digit;     // 計算用(桁)
        MaxScaleX = 7;
        MaxScaleY = 7;
        MinScaleX=3;
        MinScaleY = 3;
        idouX = 0.02f/*(MaxScaleX - MinScaleX) / CameraZoom.fTime*/;
        idouY = 0.02f/*(MaxScaleY - MinScaleY) / CameraZoom.fTime*/;

        sound01 = GetComponent<AudioSource>();
        OldNumber = 0;
    }

    void Update()
    {

        CameraZoom.SetStartCamera();
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x + idouX, gameObject.transform.localScale.y + idouY, gameObject.transform.localScale.z);
        gameObject.transform.position = 
            new Vector3(Camera.main.transform.position.x, 
                Camera.main.transform.position.y, 0);

        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;

        for (int nCntPlace = MAX_Digit - 1; 0 <= nCntPlace; nCntPlace--)
        {
            int number = 0;         // 計算結果格納用
            number = seconds % 10;
            seconds /= 10;

            KMath.animationf = 20;
            KMath4.animationf = 20;

            SetTextureCountDown(nCntPlace, number);     // テクスチャのセット
            if (OldNumber != number)
            {
                sound01.PlayOneShot(sound01.clip);
                OldNumber = number;
            }
        }

        if(totalTime < 1)
        {
            Destroy(gameObject);
            KMath.animationf = 0;
            KMath4.animationf = 0;
            TimeCounter.Timeflg = true;
        }
    }
    void SetTextureCountDown(int nPlace, int number)
    {
        Digit[nPlace].GetComponent<SpriteRenderer>().sprite = numimage[number];
    }
}
