////////////////////////////////////////////
// 
// ゴール
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gouru : MonoBehaviour
{
    public static Vector2 Pos;
    public static bool bClear;  // クリアフラグ
    public static int Hit;

    // Use this for initialization
    void Start()
    {
        bClear = false;
        Hit = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (KMath.animationf == 0&&KMath4.animationf==0)
        {
            if (Hit == 0)
            {

                if (GameObject.Find("Player").transform.localPosition.x <
                GameObject.Find("GOAL").transform.position.x + 3 &&
                GameObject.Find("Player").transform.localPosition.x >
                GameObject.Find("GOAL").transform.position.x - 3)
                {
                    if (GameObject.Find("Player").transform.localPosition.y <
                        GameObject.Find("GOAL").transform.position.y + 3 &&
                        GameObject.Find("Player").transform.localPosition.y >
                        GameObject.Find("GOAL").transform.position.y - 3)
                    {
                        bClear = true;
                        ResultScore.SetResultScore(Score.score);        // リザルトスコア用スクリプトに格納
                        ResultTime.SetResultTimer(TimeCounter.fminute, TimeCounter.fseconds, TimeCounter.fcomma);
                        Hit = 1;
                        CameraZoom.OnFlg = 1;
                        GoalFlower.GFlower = 1;
                    }
                }
            }
            if (Hit == 1)
            {
                
            }
            if (Hit == 2)
            {
                ResultItem.SetResultItem(1, Item.ItemType01, Item.bItemEnter01, Item.bItemGet01);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(2, Item.ItemType02, Item.bItemEnter02, Item.bItemGet02);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(3, Item.ItemType03, Item.bItemEnter03, Item.bItemGet03);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(4, Item.ItemType04, Item.bItemEnter04, Item.bItemGet04);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(5, Item.ItemType05, Item.bItemEnter05, Item.bItemGet05);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(6, Item.ItemType06, Item.bItemEnter06, Item.bItemGet06);   // リザルトアイテム用スクリプトに格納
                SelectMenu.SetInformationClear(stageInformation.GetStageNumber());     // クリア情報の格納
                fade.SetFadeOut("ResultClear");                                        // リザルト画面へフェード
                KMath.animationf = 20;
                KMath4.animationf = 20;
            }
            if (Hit == 3)
            {
                
            }
        }

        //if(GameObject.Find("Player").transform.localPosition.x == 
        //    6.008778f&& GameObject.Find("Player").transform.localPosition.y== 10.84889f)
        //{
        //    bClear = true;
        //}
    }

    //衝突した時に、一度だけ実行する
    ////public void OnTriggerEnter2D(Collider2D Collider)
    ////{
    ////    if (Collider.tag == "Player")
    ////    {
    ////            bClear = true;
    ////    }

    ////}

    private bool IsSleeping()
    {
        throw new System.NotImplementedException();
    }


}
