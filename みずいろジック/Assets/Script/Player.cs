using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static int f;
    public bool stopFlg;

	// Use this for initialization
	void Start () {
        stopFlg = true;
        f = 0;
	}
	
	// Update is called once per frame
	void Update () {
        // デバック用
        if (Input.GetKey(KeyCode.Z))
        {
            ResultScore.SetResultScore(Score.score);        // リザルトスコア用スクリプトに格納
            ResultItem.SetResultItem(1, Item.ItemType01, Item.bItemEnter01, Item.bItemGet01);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(2, Item.ItemType02, Item.bItemEnter02, Item.bItemGet02);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(3, Item.ItemType03, Item.bItemEnter03, Item.bItemGet03);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(4, Item.ItemType04, Item.bItemEnter04, Item.bItemGet04);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(5, Item.ItemType05, Item.bItemEnter05, Item.bItemGet05);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(6, Item.ItemType06, Item.bItemEnter06, Item.bItemGet06);   // リザルトアイテム用スクリプトに格納
            SelectMenu.SetInformationClear(stageInformation.GetStageNumber());     // クリア情報の格納
            fade.SetFadeOut("ResultClear");        // リザルト画面へフェード
            ResultTime.SetResultTimer(12, 34.0f, 56.0f);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Z))
        {
            ResultScore.SetResultScore(Score.score);        // リザルトスコア用スクリプトに格納
            ResultItem.SetResultItem(1, Item.ItemType01, Item.bItemEnter01, Item.bItemGet01);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(2, Item.ItemType02, Item.bItemEnter02, Item.bItemGet02);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(3, Item.ItemType03, Item.bItemEnter03, Item.bItemGet03);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(4, Item.ItemType04, Item.bItemEnter04, Item.bItemGet04);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(5, Item.ItemType05, Item.bItemEnter05, Item.bItemGet05);   // リザルトアイテム用スクリプトに格納
            ResultItem.SetResultItem(6, Item.ItemType06, Item.bItemEnter06, Item.bItemGet06);   // リザルトアイテム用スクリプトに格納
            ResultTime.SetResultTimer(12, 34.0f, 56.0f);
            fade.SetFadeOut("ResultGameOver");        // リザルト画面へフェード
        }


        if (f != 0)
        {
            if (WMath.idou > 0)
            {
                f = 0;
            }
            if (WMath2.idou > 0)
            {
                f = 0;
            }
            if (WMath3.idou > 0)
            {
                f = 0;
            }
        }

    }
}
