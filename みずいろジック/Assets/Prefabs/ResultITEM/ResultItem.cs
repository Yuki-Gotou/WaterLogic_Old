////////////////////////////////////////////
// 
// リザルト画面用アイテム
//          prefabの親オブジェに持たせる用
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultItem : MonoBehaviour {
    // アイテム1
    static public int nItemType01;      // アイテム1の種類の設定
    static public bool bItemGet01;      // アイテム1の獲得状態
    static public bool bItemEnter01;    // アイテム1の使用状態
    // アイテム2
    static public int nItemType02;      // アイテム1の種類の設定
    static public bool bItemGet02;      // アイテム1の獲得状態
    static public bool bItemEnter02;    // アイテム1の使用状態
    // アイテム3
    static public int nItemType03;      // アイテム1の種類の設定
    static public bool bItemGet03;      // アイテム1の獲得状態
    static public bool bItemEnter03;    // アイテム1の使用状態
    // アイテム4
    static public int nItemType04;      // アイテム1の種類の設定
    static public bool bItemGet04;      // アイテム1の獲得状態
    static public bool bItemEnter04;    // アイテム1の使用状態
    // アイテム5
    static public int nItemType05;      // アイテム1の種類の設定
    static public bool bItemGet05;      // アイテム1の獲得状態
    static public bool bItemEnter05;    // アイテム1の使用状態
    // アイテム6
    static public int nItemType06;      // アイテム1の種類の設定
    static public bool bItemGet06;      // アイテム1の獲得状態
    static public bool bItemEnter06;    // アイテム1の使用状態

	// Use this for initialization
    void Start()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // リザルト用アイテムの状況格納場所
    static public void SetResultItem(int num, int type , bool enter, bool get)
    {
        switch (num)
        {
            case 1:
                nItemType01 = type;
                bItemEnter01 = enter;
                bItemGet01 = get;
                break;
            case 2:
                nItemType02 = type;
                bItemEnter02 = enter;
                bItemGet02 = get;
                break;
            case 3:
                nItemType03 = type;
                bItemEnter03 = enter;
                bItemGet03 = get;
                break;
            case 4:
                nItemType04 = type;
                bItemEnter04 = enter;
                bItemGet04 = get;
                break;
            case 5:
                nItemType05 = type;
                bItemEnter05 = enter;
                bItemGet05 = get;
                break;
            case 6:
                nItemType06 = type;
                bItemEnter06 = enter;
                bItemGet06 = get;
                break;
        }
    }

    // リザルト用アイテム種類の取り出し
    static public int GetResultItemType(int num)
    {
        switch(num)
        {
            case 1:
                return nItemType01;
            case 2:
                return nItemType02;
            case 3:
                return nItemType03;
            case 4:
                return nItemType04;
            case 5:
                return nItemType05;
            case 6:
                return nItemType06;
        }
        return 0;
    }

    // リザルト用アイテム使用状況の取り出し
    static public bool GetResultItemEnter(int num)
    {
        switch (num)
        {
            case 1:
                return bItemEnter01;
            case 2:
                return bItemEnter02;
            case 3:
                return bItemEnter03;
            case 4:
                return bItemEnter04;
            case 5:
                return bItemEnter05;
            case 6:
                return bItemEnter06;
        }
        return false;
    }

    // リザルト用アイテム獲得状況の取り出し
    static public bool GetResultItemGet(int num)
    {
        switch (num)
        {
            case 1:
                return bItemGet01;
            case 2:
                return bItemGet02;
            case 3:
                return bItemGet03;
            case 4:
                return bItemGet04;
            case 5:
                return bItemGet05;
            case 6:
                return bItemGet06;
        }
        return false;
    }
}
