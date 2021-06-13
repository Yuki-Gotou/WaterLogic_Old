using UnityEngine;
using System.Collections;

public class CameraScene : MonoBehaviour
{
    //public GameObject player;
    public Vector3 SceneLevelPos;       //目標座標（ＬｅｖｅｌのＣｅｎｔｅｒ座標の位置）
    public int m_OldID;                 //前のＩＤの情報（現在のＬｅｖｅｌの位置の配列番号）
    public int m_SaveID;                 //前のＩＤの情報（現在のＬｅｖｅｌの位置の配列番号）兼万が一移動途中で、止まった場合、最後に入力した、ＩＤへ行く
    public Vector3 CameraPos;           //現在のカメラの座標
    public GameObject LevelSelect;      //クラス内で保持出来る仮の器のＯｂｊｅｃｔを作成
    public int count;               //カウント
    public int Maxcount;            //次のＩＤの変更が一定カウントなかったら変更処理
    public Vector3[] SafetyPos;     //一旦格納用 LevelFlg座標用
    Vector3 SafePassPos;            //より近いLevel(配列番号)座標に移動用
    bool UseFlg;                    //一回目(false)は、ＡとＢで比較する必要があるので、やるが、二回目以降（Ｔｒｕｅ）は、ＣとＳａｆｅＰａｓｓＰｏｓで比較し決める
    bool StopFlg;                   //もし、エラーな動きがあったら、修正処理をSetDiffPosを使い、その後フラグ起動後、その座標にたどり着くまでは、操作できないようにする
    void Start()
    {
        count = 0;
       // CameraPos = new Vector3(0.0f, 0.0f, -10.0f);// this.transform.position; //多分必要無し？Unity内で、座標を入力使用
        //カメラの現在座標をＵｐｄａｔｅ内での処理で比較で使用
        SceneLevelPos = new Vector3(CameraPos.x, CameraPos.y, CameraPos.z);
         
        //現在選ばれている座標を保持とUpdate内で、比較し、違った場合、動くように処理
         SceneLevelPos=LevelSelect.GetComponent<LevelSelectFlag>()
            .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
        //現在のＩＤを保持
         m_OldID = (int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
    }

    void Update()
    {
        //常にＩＤを取得
        //m_SaveID = LevelSelect.GetComponent<LevelSelectFlag>().m_ID;

       // if(CameraPos.x!=SceneLevelPos.x)
        //もし現在使用しているＩＤ（Ｌevel1～３）が、変更されたのが確認されたら、処理入る
        //前のＩＤより、→だったら座標　ｘ増える

        if ((LevelSelect.GetComponent<LevelSelectFlag>().m_ID > m_OldID))
        //if (UpdateFlg(
        //    LevelSelect.GetComponent<LevelSelectFlag>().m_ID,
        //     LevelSelect.GetComponent<LevelSelectFlag>()
        //    .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID],
        //    m_OldID,
        //    CameraPos,
        //     LevelSelect.GetComponent<LevelSelectFlag>().UseFlg,
        //    0.2f))
        {
           //常に、座標をもらう違ったら、下にある、移動処理を使用
           SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
            .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
           
           
           CameraPos =new  Vector3(CameraPos.x + 0.2f,CameraPos.y,CameraPos.z);
            SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
           .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
           
           //現在（カメラ）より目標（ＬｅｖｅｌＰｏｓ）の方が小さく行けば座標挿入
           if (CameraPos.x > SceneLevelPos.x-1)
           {
               CameraPos.x = SceneLevelPos.x-1;
               m_OldID = LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
               LevelSelect.GetComponent<LevelSelectFlag>().UseFlg = false;
           }
        }
        //else if (UpdateFlg( m_OldID,CameraPos,
        //                    LevelSelect.GetComponent<LevelSelectFlag>().m_ID,
        //                    LevelSelect.GetComponent<LevelSelectFlag>()
        //                   .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID],
        //     LevelSelect.GetComponent<LevelSelectFlag>().UseFlg,
        //                    -0.2f))
        if ((LevelSelect.GetComponent<LevelSelectFlag>().m_ID < m_OldID))
        {
            //常に、座標をもらう違ったら、下にある、移動処理を使用
            SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
             .Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
            
            
            CameraPos = new Vector3(CameraPos.x - 0.2f, CameraPos.y, CameraPos.z);
            // SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
            //.Pos[(int)LevelSelect.GetComponent<LevelSelectFlag>().m_ID];
            //現在（カメラ）より目標（ＬｅｖｅｌＰｏｓ）の方が大きく行けば座標挿入
            if (CameraPos.x < SceneLevelPos.x-1)
            {
                CameraPos.x = SceneLevelPos.x-1;
                m_OldID = LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
                LevelSelect.GetComponent<LevelSelectFlag>().UseFlg = false;
            }
        }
        //万が一、一定カウント過ぎても、押さなかったら、（変更されてないんなら、最後に入力されたＩＤ（Ｌｅｖｅｌの場所の配列）に移動する）
        else
        {
            ////もしＩＤ（ＬｅｖｅｌＰｏｓ格納の番号）違えば、処理開始
            //if (UpdatePosID()) { }
            //    //違うなら、初期化　Countのみ
            //else { count = 0; }
        }

              

        ////目標座標より右へ進んだら、強制補正
        //else  if (CameraPos.x > SceneLevelPos.x)
        //{
        //    CameraPos.x = SceneLevelPos.x;
        //}
        transform.position = new Vector3(CameraPos.x, 0, -10);
    }
   bool UpdateFlg(int A_ID,Vector3 APos,int B_ID,Vector3 BPos,bool Flg,float Diff)
   {
       if((A_ID > B_ID)&&(Flg))
       {
           //常に、座標をもらう違ったら、下にある、移動処理を使用
           SceneLevelPos = LevelSelect.GetComponent<LevelSelectFlag>()
            .Pos[A_ID];

           CameraPos = new Vector3(CameraPos.x + Diff, CameraPos.y, CameraPos.z);

           //現在（カメラ）より目標（ＬｅｖｅｌＰｏｓ）の方が小さく行けば座標挿入
           if (BPos.x > APos.x)
           {
               CameraPos.x = SceneLevelPos.x; 
               m_OldID = LevelSelect.GetComponent<LevelSelectFlag>().m_ID;
               LevelSelect.GetComponent<LevelSelectFlag>().UseFlg=false;
           }

           return true;
       }
       return false;
   }
   
  //  //もしＩＤ（ＬｅｖｅｌＰｏｓ格納の番号）違えば、処理開始
  // public  bool UpdatePosID()
  //  {
  //      //もしＩＤ（ＬｅｖｅｌＰｏｓ格納の番号）違えば、処理開始
  //      if (LevelSelect.GetComponent<LevelSelectFlag>().m_ID == m_OldID)
  //      {
  //         
  //          count = count + 1;
  //          if (count > Maxcount)
  //          {
  //              //比較Ａ
  //              for (int i = 0; i > LevelSelect.GetComponent<LevelSelectFlag>().MAX_SCENE; i++)
  //              {
  //                  //個数分（最大配列数まで） だけ取得
  //                  SafetyPos[i] = LevelSelect.GetComponent<LevelSelectFlag>()
  //                    .Pos[i];
  //                  //Ｍａｘ＿Ｓｃｅｎｅで、偶数だと、エラー出る恐れあり
  //                  if (!(i >= LevelSelect.GetComponent<LevelSelectFlag>().MAX_SCENE))
  //                  {
  //                      //一回の回る事で、二個分取得
  //                      i = i + 1;
  //                      SafetyPos[i] = LevelSelect.GetComponent<LevelSelectFlag>()
  //                      .Pos[i];
  //                  }
  //
  //                  //Ｆｏｒ文に関わる処理を別関数で行う
  //                  ForUpdate(i);
  //                                }
  //              count = 0;
  //              //m_OldID = m_SaveID;
  //
  //          }
  //          return true;
  //      }
  //      return false;
  //  }
  //  //複数の配列を使い、現在のカメラ座標から、一番近い配列情報を見つけ、その座標へ移動する
  // public void ForUpdate(int i)
  // {
  //     //座標のＡとＢを取得して、どちらが近いかを　二乗して、整数での低い方をSafePosへ保存
  //     //ＡＰｏｓ(比較Ａ)
  //     float APosX = SafetyPos[i - 1].x * SafetyPos[i - 1].x;
  //     //ＢＰｏｓ(比較Ｂ)
  //     float BPosX = SafetyPos[i].x * SafetyPos[i].x;
  //
  //     //目標比較座標から現座標を引く
  //     APosX = APosX - (CameraPos.x * CameraPos.x);
  //     BPosX = BPosX - (CameraPos.x * CameraPos.x);
  //     if (false == UseFlg)
  //     {
  //         //より小さい方をを入れる
  //         if (SetDiffPos(APosX, BPosX, i - 1, i))
  //         {
  //             //中で処理するので、ここでの処理なし
  //             UseFlg = true;
  //         }
  //     }
  //     else
  //     {
  //         //  True A  false B
  //         if (SetDiffPos(APosX, BPosX, i - 1, i))
  //         {   //True　SafePassPos  false A
  //             if (SetDiffPos(SafePassPos.x, APosX, m_SaveID, i - 1)) { }
  //             StopFlg = true;
  //         }
  //         else
  //         {
  //             //True　SafePassPos  false B
  //             if (SetDiffPos(SafePassPos.x, BPosX, m_SaveID, i)) { }
  //             StopFlg = true;
  //         }
  //     }
  //
  // }
  //
  //  // AとＢでの情報比較し、低い数字（カメラ座標により近いのを検出）
  //  bool SetDiffPos(float APos, float BPos,int A_ID,int B_ID)
  //  {
  //
  //      if (APos < BPos)
  //      {
  //          SafePassPos.x = APos;
  //          m_SaveID = A_ID;
  //          return true;
  //
  //      }
  //      else if (APos > BPos)
  //      {
  //          SafePassPos.x = BPos;
  //          m_SaveID = B_ID;
  //      }
  //      //上のフラグ起動しなかったら、自動的に、false
  //      return false;
  //  }

}