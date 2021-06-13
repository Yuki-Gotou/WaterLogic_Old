////////////////////////////////////////////
// 
// タイトル用カメラ
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTitle : MonoBehaviour {
    public float fCameraPosX1;          // カメラの初期位置
    public float fCameraPosX2;          // カメラの目的位置
    static public float PosX1;          // カメラの初期位置格納用
    static public float PosX2;          // カメラの目的位置格納用
    static Vector3 camera;              // カメラ座標変更用
    static float CurrentMoveTime;       // 現在の移動時間
    int MoveTime;                       // カメラの移動時間

    public GameObject MoveTex;          // カメラと一緒に動かすタイトルロゴ(Unity呼び出し) 
    public GameObject MoveRogo;          // カメラと一緒に動かすタイトルロゴ(Unity呼び出し) 
    public GameObject MoveFade;          // カメラと一緒に動かすタイトルフェード(Unity呼び出し) 

    static public bool bMoveObj;        // カメラと一緒に動かすフラグ

    // Use this for initialization
    void Start()
    {
        PosX1 = fCameraPosX1;           // カメラ1の座標格納
        PosX2 = fCameraPosX2;           // カメラ2の座標格納
        camera = new Vector3(PosX1, 0.0f, -10.0f);  // カメラの初期位置
        MoveTime = 5;                   // 移動時間の設定
        CurrentMoveTime = Time.time;    // 経過時間の取得

        bMoveObj = true;
    }

    // Update is called once per frame
    void Update()
    {
        // カメラループ
        // 現在の位置 = 元の位置 * (経過時間の式) / 終了の時間                  (目的の位置 > 元の位置　の式)
        camera.x = PosX2 * (Time.time - CurrentMoveTime) / MoveTime;
        if (camera.x >= PosX2)
        {
            CurrentMoveTime = Time.time;
            camera.x = PosX1;
        }

        if (bMoveObj)
        {
            MoveTex.GetComponent<Transform>().position = new Vector3(camera.x, MoveTex.transform.position.y);
            MoveRogo.GetComponent<Transform>().position = new Vector3(camera.x, MoveRogo.transform.position.y);
        }
        MoveFade.GetComponent<Transform>().position = new Vector3(camera.x, MoveFade.transform.position.y);
        GetComponent<Transform>().position = camera;    // カメラの座標更新
    }
}
