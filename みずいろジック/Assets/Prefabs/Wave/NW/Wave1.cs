using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1 : MonoBehaviour {
    public Sprite[] texturesLB;		// 水色の波の画像
    public Sprite[] texturesB;		// 青色の波の画像
    public Sprite[] texturesG;		// 緑色の波の画像
    public float changeFrameSecond; // 画像の更新時間
    private float dTime;            // 時間格納用
    private int frameNum;           // フレームのカウント
    static int nowWave;     // 外部参照：ここに現在の色を設定
    float StandardPosX;     // 常にいてほしい座標X
    static float WaveAlpha; // ウェーブのアルファ値

    // Use this for initialization
    void Start()
    {
        dTime = 0.0f;   // 時間の初期化
        frameNum = 0;   // フレームカウントの初期化
        nowWave = 1;    // 最初の画像グループを設定
        StandardPosX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(StandardPosX, transform.position.y, transform.position.z);    // X座標の固定
        GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, WaveAlpha);

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
            }

        }
    }

    static public void SetAlpha(float num)
    {
        WaveAlpha = num;
    }
}
