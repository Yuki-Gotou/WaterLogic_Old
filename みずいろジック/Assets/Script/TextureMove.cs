////////////////////////////////////////////
// 
// テクスチャムーブ
//      二点の座標を指定して
//        その間を指定の時間内に動く
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureMove : MonoBehaviour
{
    public float PosY1;                // 一つ目の位置
    public float PosY2;                // 二つ目の位置
    public float MoveTime;              // 動く時間

    static float CurrentMoveTime;       // 現在の移動時間
    public string sVector;                 // 移動管理フラグ

    float MovePosY1;              // 座標変更用

    // Use this for initialization
    void Start()
    {
        if (sVector == "MoveA")
        {
            gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, PosY1, transform.position.z);
        }
        else if (sVector == "MoveB")
        {
            gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, PosY2, transform.position.z);
        }

        CurrentMoveTime = Time.time;    // 時間の取得
    }

    // Update is called once per frame
    void Update()
    {
        switch (sVector)
        {
            case "MoveA":  // 下がるに移動
                LerpA();
                if (MovePosY1 <= PosY2)
                {
                    MovePosY1 = PosY2;
                    sVector = "MoveB";
                    CurrentMoveTime = Time.time;    // 時間の取得
                }
                break;
            case "MoveB": // 上がる
                LerpB();

                if (MovePosY1 >= PosY1)
                {
                    MovePosY1 = PosY1;
                    sVector = "MoveA";
                    CurrentMoveTime = Time.time;    // 時間の取得
                }
                break;
        }
        gameObject.GetComponent<Transform>().position = new Vector3(transform.position.x, MovePosY1, transform.position.z);
    }

    //***********************************************************
    //
    //		線形補完関数(linear interpolate)
    //
    //		結果出力用X座標
    //		結果出力用Y座標
    //		開始点X座標
    //		開始点Y座標
    //		終了点X座標
    //		終了点Y座標
    //		最大時間
    //		現在時間
    //
    //***********************************************************
    void LerpA()
    {
        MovePosY1 = PosY1 + (PosY2 - PosY1) * (((Time.time - CurrentMoveTime) - 0.0f) / (MoveTime - 0.0f));
    }

    void LerpB()
    {
        MovePosY1 = PosY2 + (PosY1 - PosY2) * (((Time.time - CurrentMoveTime) - 0.0f) / (MoveTime - 0.0f));
    }
}
