////////////////////////////////////////////
// 
// リザルト画面用アイテム
//          子オブジェ用
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultItemChild : MonoBehaviour
{
    public Sprite TreasureBag;
    public Sprite TreasureBagS;
    public Sprite Sword;
    public Sprite SwordS;
    public Sprite Diamond;
    public Sprite DiamondS;

    public int ItemNumber;      // アイテム番号
    int ItemTypeC;              // アイテム種類
    bool bItemEnterC;           // アイテム使用状態
    bool bItemGetC;             // アイテム獲得状態

    SpriteRenderer sr; // メッシュカラー用

    // Use this for initialization
    void Start()
    {
        ItemTypeC = ResultItem.GetResultItemType(ItemNumber);        // アイテムの種類格納
        bItemEnterC = ResultItem.GetResultItemEnter(ItemNumber);     // アイテムの使用フラグ格納
        bItemGetC = ResultItem.GetResultItemGet(ItemNumber);         // アイテムの使用フラグ格納
        transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        sr = GetComponent<SpriteRenderer>();
        switch(ItemTypeC)
        {
            case 1:
                if (bItemGetC)
                { sr.sprite = TreasureBag; }
                else 
                if(!bItemGetC)
                { sr.sprite = TreasureBagS; }
                break;
            case 2:
                if (bItemGetC)
                { sr.sprite = Sword; }
                else 
                if(!bItemGetC)
                { sr.sprite = SwordS; }
                break;
            case 3:
                if (bItemGetC)
                { sr.sprite = Diamond; }
                else
                if (!bItemGetC)
                { sr.sprite = DiamondS; }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
