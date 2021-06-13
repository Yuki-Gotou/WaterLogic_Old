using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{

    public Vector3 SceneLevelPos;       //目標座標（ＬｅｖｅｌのＣｅｎｔｅｒ座標の位置）
    public int m_OldID;                 //前のＩＤの情報（現在のＬｅｖｅｌの位置の配列番号）
    public Vector3 CameraPos;           //現在のカメラの座標
    public GameObject LevelSelect;      //クラス内で保持出来る仮の器のＯｂｊｅｃｔを作成
    public int count;               //カウント
    public int Maxcount;            //次のＩＤの変更が一定カウントなかったら変更処理
   

    // Use this for initialization
    void Start()
    {
        count = 0;
        CameraPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);// this.transform.position; //多分必要無し？Unity内で、座標を入力使用
        //カメラの現在座標をＵｐｄａｔｅ内での処理で比較で使用
        SceneLevelPos = new Vector3(CameraPos.x, CameraPos.y, CameraPos.z);

        //現在選ばれている座標を保持とUpdate内で、比較し、違った場合、動くように処理
        SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
           .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
        //現在のＩＤを保持
        m_OldID = (int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
    }

    // Update is called once per frame
    void Update()
    {

      
        // if(CameraPos.x!=SceneLevelPos.x)
        //もし現在使用しているＩＤ（Ｌevel1～３）が、変更されたのが確認されたら、処理入る
        //前のＩＤより、→だったら座標　ｘ増える

        if ((LevelSelect.GetComponent<LevelSelectFlag>().m_ID > m_OldID))
        {
            //常に、座標をもらう違ったら、下にある、移動処理を使用
            SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
             .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];

            LevelSelect.GetComponent<LevelSelectFlag>().m_Aroow[1].GetComponent<Aroow>().UseMoveFlg = true;

            CameraPos = new Vector3(CameraPos.x + 0.2f, CameraPos.y, CameraPos.z);
           // SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
           //.Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
            
           
            //現在（カメラ）より目標（ＬｅｖｅｌＰｏｓ）の方が小さく行けば座標挿入
            if (CameraPos.x > SceneLevelPos.x+0.09f)
            {
             
                  //矢印のアルファ値を調整中
                  LevelSelect.GetComponent<LevelSelectFlag>().m_Aroow[1].GetComponent<Aroow>().UseMoveFlg = true;
                    CameraPos.x = SceneLevelPos.x+0.09f;
                m_OldID = LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
                LevelSelect.GetComponent<LevelSelectFlag>().UseFlg = false;
            }
        }
        if ((LevelSelect.GetComponent<LevelSelectFlag>().m_ID < m_OldID))
        {
            //常に、座標をもらう違ったら、下にある、移動処理を使用
            SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
             .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];

            LevelSelect.GetComponent<LevelSelectFlag>().m_Aroow[0].GetComponent<Aroow>().UseMoveFlg = true;
            CameraPos = new Vector3(CameraPos.x - 0.2f, CameraPos.y, CameraPos.z);
            // SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
            //.Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
            //現在（カメラ）より目標（ＬｅｖｅｌＰｏｓ）の方が大きく行けば座標挿入
            if (CameraPos.x < SceneLevelPos.x+0.09f)
            {
                CameraPos.x = SceneLevelPos.x+0.09f;
                m_OldID = LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
                LevelSelect.GetComponent<LevelSelectFlag>().UseFlg = false;
                LevelSelect.GetComponent<LevelSelectFlag>().m_Aroow[1].GetComponent<Aroow>().UseMoveFlg = false;
          
            }
        }
        else
        {
            LevelSelect.GetComponent<LevelSelectFlag>().UseFlg = false;
        }
        transform.position = new Vector3(CameraPos.x, 0, -10);

    }



}













