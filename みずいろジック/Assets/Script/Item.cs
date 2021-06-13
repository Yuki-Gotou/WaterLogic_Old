////////////////////////////////////////////
// 
// ゲーム画面用アイテム
//          親オブジェ用
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // アイテム1
    static public bool bItemGet01;    // アイテム1の取得状態
    static public bool bItemEnter01;    // アイテム1の使用状態
    static public int ItemType01;      // アイテム1の種類
    // アイテム2
    static public bool bItemGet02;    // アイテム2の取得状態
    static public bool bItemEnter02;    // アイテム2の使用状態
    static public int ItemType02;      // アイテム2の種類
    // アイテム3
    static public bool bItemGet03;    // アイテム3の取得状態
    static public bool bItemEnter03;    // アイテム3の使用状態
    static public int ItemType03;      // アイテム3の種類
    // アイテム4
    static public bool bItemGet04;    // アイテム4の取得状態
    static public bool bItemEnter04;    // アイテム4の使用状態
    static public int ItemType04;      // アイテム4の種類
    // アイテム5
    static public bool bItemGet05;    // アイテム5の取得状態
    static public bool bItemEnter05;    // アイテム5の使用状態
    static public int ItemType05;      // アイテム5の種類
    // アイテム6
    static public bool bItemGet06;    // アイテム6の取得状態
    static public bool bItemEnter06;    // アイテム6の使用状態
    static public int ItemType06;      // アイテム6の種類

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // アイテムの取得状態の設定
    static public void SetItemGet(int Num, bool bget)
    {
        switch (Num)
        {
            case 1:
                bItemGet01 = bget;
                break;
            case 2:
                bItemGet02 = bget;
                break;
            case 3:
                bItemGet03 = bget;
                break;
            case 4:
                bItemGet04 = bget;
                break;
            case 5:
                bItemGet05 = bget;
                break;
            case 6:
                bItemGet06 = bget;
                break;
        }
    }

    // アイテムの使用状態の設定
    static public void SetItemEnter(int Num, bool enter)
    {
        switch (Num)
        {
            case 1:
                bItemEnter01 = enter;
                break;
            case 2:
                bItemEnter02 = enter;
                break;
            case 3:
                bItemEnter03 = enter;
                break;
            case 4:
                bItemEnter04 = enter;
                break;
            case 5:
                bItemEnter05 = enter;
                break;
            case 6:
                bItemEnter06 = enter;
                break;
        }
    }

    // アイテムの種類の設定
    static public void SetItemType(int Num, int type)
    {
        switch (Num)
        {
            case 1:
                ItemType01 = type;
                break;
            case 2:
                ItemType02 = type;
                break;
            case 3:
                ItemType03 = type;
                break;
            case 4:
                ItemType04 = type;
                break;
            case 5:
                ItemType05 = type;
                break;
            case 6:
                ItemType06 = type;
                break;
        }
    }
}
