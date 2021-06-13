////////////////////////////////////////////
// 
// シーンセレクト用カメラ
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSceneSelect : MonoBehaviour
{
    public float fCameraPosX1;          // カメラの位置1
    public float fCameraPosX2;          // カメラの位置2
    static public float PosX1;          // カメラの位置1格納用
    static public float PosX2;          // カメラの位置2格納用
    static Vector3 camera;              // カメラ座標変更用
    static float CurrentMoveTime;       // 現在の移動時間
    int MoveTime;                       // カメラの移動時間
    static public string CmeraStart;    // カメラの状態

    public GameObject MoveObj1;         // カメラと一緒に動かすモノ
    float MoveObj1PosX;                 // ↑のX座標格納用
    public GameObject MoveFade;          // カメラと一緒に動かすタイトルフェード(Unity呼び出し) 
    float MoveFadePosX;                 // ↑のX座標格納用



    // Use this for initialization
    void Start()
    {
        PosX1 = fCameraPosX1;           // カメラ1の座標格納
        PosX2 = fCameraPosX2;           // カメラ2の座標格納
        camera = new Vector3(PosX1, 0.0f, -10.0f);  // カメラの初期位置
        MoveTime = 2;                   // 移動時間の設定
        CurrentMoveTime = Time.time;    // 経過時間の取得
        CmeraStart = "Normal";          // カメラの状態設定
        MoveObj1PosX = MoveObj1.GetComponent<Transform>().position.x;
        MoveFadePosX = MoveFade.GetComponent<Transform>().position.x;
    }

    // Update is called once per frame
    void Update()
    {
        switch (CmeraStart)
        {
            case "Normal":  // 通常状態
                Debug.Log("Normal", gameObject);
                break;
            case "MoveToLeft":  // 左に移動
                // 現在の位置 = 元の位置 - 元の位置 * (経過時間の式) / 終了の時間       (目的の位置 < 元の位置　の式)
                camera.x = PosX2 - PosX2 * (Time.time - CurrentMoveTime) / MoveTime;
                Debug.Log("左", gameObject);
                if (camera.x <= PosX1)
                {
                    camera.x = PosX1;
                    CmeraStart = "Normal";
                    Debug.Log("Normalになる１", gameObject);
                }
                break;
            case "MoveToRight": // 右に移動
                // 現在の位置 = 元の位置 * (経過時間の式) / 終了の時間                  (目的の位置 > 元の位置　の式)
                camera.x = PosX2 * (Time.time - CurrentMoveTime) / MoveTime;
                if (camera.x >= PosX2)
                {
                    camera.x = PosX2;
                    CmeraStart = "Normal";
                    Debug.Log("Normalになる２", gameObject);
                }
                Debug.Log("右", gameObject);
                break;
        }

        MoveObj1.GetComponent<Transform>().position = new Vector3(camera.x + MoveObj1PosX, MoveObj1.transform.position.y, MoveObj1.transform.position.z);
        MoveFade.GetComponent<Transform>().position = new Vector3(camera.x + MoveFadePosX, MoveFade.transform.position.y, MoveFade.transform.position.z);
        GetComponent<Transform>().position = camera;    // カメラの座標更新
    }

    // カメラ操作1
    static public void MoveCamera1()
    {
        if (CameraSceneSelect.CmeraStart == "Normal" && camera.x == PosX2)
        {
            CmeraStart = "MoveToLeft";     // カメラの状態設定
            CurrentMoveTime = Time.time;
        }
    }
    // カメラ操作2
    static public void MoveCamera2()
    {
        if (CameraSceneSelect.CmeraStart == "Normal" && camera.x == PosX1)
        {
            CmeraStart = "MoveToRight";     // カメラの状態設定
            CurrentMoveTime = Time.time;
        }
    }
}
