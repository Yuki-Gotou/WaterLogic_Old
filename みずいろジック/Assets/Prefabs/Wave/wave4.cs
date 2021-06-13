////////////////////////////////////////////
// 
// 波テクスチャアニメーション
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave4 : MonoBehaviour
{
    public Sprite[] texturesLB;		// 水色の波の画像
    public Sprite[] texturesB;		// 青色の波の画像
    public Sprite[] texturesG;		// 緑色の波の画像
    public float changeFrameSecond; // 画像の更新時間
    private float dTime;            // 時間格納用
    private int frameNum;           // フレームのカウント
    static int nowWave;     // 外部参照：ここに現在の色を設定
    float StandardPosX;     // 常にいてほしい座標X
    static Color WaveAlpha; // ウェーブのアルファ値
    public static int ChangeWave;   //ウェーブの変換
    public static int WaveGF;       //ウェーブ変化開始フラグ

    // Use this for initialization
    void Start()
    {
        dTime = 0.0f;   // 時間の初期化
        frameNum = 0;   // フレームカウントの初期化
        nowWave = 1;    // 最初の画像グループを設定
        StandardPosX = transform.position.x;
        WaveAlpha = GetComponent<SpriteRenderer>().color;
        WaveAlpha.a = 1.0f;   // アルファ値の初期化
        ChangeWave = nowWave;
        WaveGF = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //現在のウェーブ確認
        //nowWave = ChangeWave;
        // デバック用
        if (Input.GetKey(KeyCode.X))
        {
            nowWave = 1;
        }

        if (Input.GetKey(KeyCode.C))
        {
            nowWave = 2;
        }

        if (Input.GetKey(KeyCode.V))
        {
            nowWave = 3;
        }

        if (Input.GetKey(KeyCode.J))
        {
            WaveAlpha.a = 0.0f;
            //SetAlpha(1.0f);
            //GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, WaveAlpha);
        }

        if (Input.GetKey(KeyCode.H))
        {
            WaveAlpha.a = 1.0f;
            //SetAlpha(0.0f);
            //GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, WaveAlpha);
        }
        if (WaveGF == 1)
        {
            if ( KMath4.CWLB4 != 0)
            {
                ChangeWave = 1;
                WaveAlpha.a = 1.0f;
                Debug.Log("水1", gameObject);
            }
            else if ( KMath4.CWB4 != 0)
            {
                ChangeWave = 2;
                WaveAlpha.a = 1.0f;
                Debug.Log("青1", gameObject);
            }
            else if (KMath4.CWG4 != 0)
            {
                ChangeWave = 3;
                WaveAlpha.a = 1.0f;
                Debug.Log("緑1", gameObject);
            }
            else
            {
                ChangeWave = 4;
                WaveAlpha.a = 0.0f;
                Debug.Log("無し", gameObject);
            }
            WaveGF = 0;
        }
        Debug.Log(nowWave);
        if (KMath4.animationf == 10 || KMath4.animationf == 101 || KMath4.animationf == 1011 || KMath4.animationf == 10111 || KMath4.animationf == 101111 || KMath4.animationf == 12 || KMath4.animationf == 121 || KMath4.animationf == 1211 || KMath4.animationf == 12111 || KMath4.animationf == 121111 || KMath4.animationf == 13 || KMath4.animationf == 131 || KMath4.animationf == 1311 || KMath4.animationf == 13111 || KMath4.animationf == 131111)
        {
            ChangeWave = 4;
            WaveAlpha.a = 0.0f;
        }
        nowWave = ChangeWave;
        // アニメーションの更新
        dTime += Time.deltaTime;
        if (changeFrameSecond < dTime)
        {
            dTime = 0.0f;
            frameNum++;
            switch (nowWave)
            {
                case 1:
                    if (frameNum >= texturesLB.Length) frameNum = 0;
                    GetComponent<SpriteRenderer>().sprite = texturesLB[frameNum];
                    break;
                case 2:
                    if (frameNum >= texturesB.Length) frameNum = 0;
                    GetComponent<SpriteRenderer>().sprite = texturesB[frameNum];
                    break;
                case 3:
                    if (frameNum >= texturesG.Length) frameNum = 0;
                    GetComponent<SpriteRenderer>().sprite = texturesG[frameNum];
                    break;
                case 4:
                    WaveAlpha.a = 0.0f;
                    break;
            }

        }
        transform.position = new Vector3(StandardPosX, transform.position.y, transform.position.z);    // X座標の固定
        GetComponent<SpriteRenderer>().color = WaveAlpha;
        Debug.Log(WaveAlpha);
    }

    //static public void SetAlpha(float num)
    //{
    //    WaveAlpha.a = num;
    //}
}
