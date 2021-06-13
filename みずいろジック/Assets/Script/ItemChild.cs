////////////////////////////////////////////
// 
// ゲーム画面用アイテム
//          子オブジェ用
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChild : MonoBehaviour {
    public int scoreValue;   // スコアの設定は inspector 部分でやる
    public int itemArray;       // アイテムの配列番号
    public int itemType;     // アイテム種類の設定
    public int a;

	// Use this for initialization
    void Start()
    {
        Item.SetItemType(itemArray, itemType);
        Item.SetItemGet(itemArray, false);
        Item.SetItemEnter(itemArray, true);
        a = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (KMath.animationf == 0&&KMath4.animationf==0)
        {
            a = 2;
            if (transform.localPosition.y < GameObject.Find("Player").transform.localPosition.y + 1 
                && transform.position.y > GameObject.Find("Player").transform.localPosition.y - 1)
            {//衝突した時に、実行する
                Debug.Log("あいてむ１");

                a = 3;
                if (transform.localPosition.x < GameObject.Find("Player").transform.localPosition.x + 3 
                    && transform.position.x > GameObject.Find("Player").transform.localPosition.x - 3)
                {
                    Debug.Log("あいてむ２");
                    Item.SetItemEnter(itemArray, true);
                    Item.SetItemGet(itemArray, true);
                    Destroy(gameObject);
                    Score.AddScore(scoreValue);
                    a = 1;
                }
            }
        }
    }
}
