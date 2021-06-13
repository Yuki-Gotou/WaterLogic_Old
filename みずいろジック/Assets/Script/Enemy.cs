////////////////////////////////////////////
// 
// 敵
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    static public bool bPtrigger = false;      // プレイヤーとの判定フラグ
    static bool reverseFlg = false;
    public bool SEFlg = false;
    public float RotY;
    public static int Hit;
    public static Vector3 StayPosition;

    //public AudioSource sound01;

    // Use this for initialization
    void Start()
    {
        bPtrigger = false;
        reverseFlg = false;
        SEFlg = false;
        Hit = 0;
        StayPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x <= GameObject.Find("Player").transform.localPosition.x)
        {
            if (transform.localScale.x > 0)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
        }

        if (transform.localPosition.x > GameObject.Find("Player").transform.localPosition.x)
        {
            if (transform.localScale.x < 0)
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
        }

        if (KMath.animationf == 0 && KMath4.animationf == 0)
        {
            if (Hit == 0)
            {
                if (transform.localPosition.x <= GameObject.Find("Player").transform.localPosition.x + 1 && transform.localPosition.x >= GameObject.Find("Player").transform.localPosition.x - 1)
                {
                    Debug.Log("ゲームオーバーX", gameObject);
                    if (transform.localPosition.y <= GameObject.Find("Player").transform.localPosition.y + 1 && transform.localPosition.y >= GameObject.Find("Player").transform.localPosition.y - 1)
                    {
                        Debug.Log("ゲームオーバーY", gameObject);

                        Debug.Log("ゲームオーバー", gameObject);
                        Hit = 1;
                        CameraZoom.OnFlg = 1;
                        StayPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                        ResultTime.SetResultTimer(TimeCounter.fminute, TimeCounter.fseconds, TimeCounter.fcomma);
                    }
                }
                if (transform.localPosition.x < GameObject.Find("Player").transform.localPosition.x + 3 && transform.localPosition.x > GameObject.Find("Player").transform.localPosition.x - 3)
                {
                    if (transform.localPosition.y < GameObject.Find("Player").transform.localPosition.y + 4 && transform.localPosition.y > GameObject.Find("Player").transform.localPosition.y - 4)
                    {
                        if (transform.position.x > GameObject.Find("Player").transform.position.x)
                        {
                            transform.position = new Vector3(transform.position.x - 0.3f, transform.position.y, transform.position.z);
                        }
                        else
                        {
                            transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y, transform.position.z);
                        }
                        if (transform.position.y > GameObject.Find("Player").transform.position.y)
                        {
                            transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
                        }
                        else
                        {
                            transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
                        }

                    }
                }
            }
            if(Hit==1)
            {
                transform.position = StayPosition;
            }
            if (Hit == 2)
            {
                bPtrigger = true;
                Debug.Log("ゲームオーバー開始", gameObject);
                transform.position = StayPosition;
                ResultScore.SetResultScore(Score.score);        // リザルトスコア用スクリプトに格納
                ResultItem.SetResultItem(1, Item.ItemType01, Item.bItemEnter01, Item.bItemGet01);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(2, Item.ItemType02, Item.bItemEnter02, Item.bItemGet02);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(3, Item.ItemType03, Item.bItemEnter03, Item.bItemGet03);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(4, Item.ItemType04, Item.bItemEnter04, Item.bItemGet04);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(5, Item.ItemType05, Item.bItemEnter05, Item.bItemGet05);   // リザルトアイテム用スクリプトに格納
                ResultItem.SetResultItem(6, Item.ItemType06, Item.bItemEnter06, Item.bItemGet06);   // リザルトアイテム用スクリプトに格納
                fade.SetFadeOut("ResultGameOver");                                        // リザルト画面へフェード
                Hit = 3;
            }
            if(Hit==3)
            {
                transform.position = StayPosition;
            }
        }
    }

}


    //衝突した時に、一度だけ実行する
    //public void OnTriggerEnter2D(Collider2D Collider)
    //{
    //    if (Collider.tag == "Player")   // " "の中にはタグ名を入れる
    //    {
    //        bPtrigger = true;
    //    }

    //}

