////////////////////////////////////////////
// 
// ステージセレクトメニュー
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIコンポーネントの使用
using UnityEngine.SceneManagement;      // シーン指導におそらく必要


public class SelectMenu : MonoBehaviour {
    static public int nSelect; // 操作用
    public Sprite SpriteBefore;     // 通常状態の画像
    public Sprite[] SpriteAfter;      // 選択中の画像
    public GameObject[] Stage;      // ステージオブジェ用
    public int numStage;                    // ステージ数
    static public int nClearStage;      // ステージのクリア情報

    public GameObject RedCircle;    // 決定アクションオブジェ
    public Sprite[] AnimTexture;    // 決定アクション用テクスチャ
    private float changeFrameSecond; // 画像の更新時間
    private float dTime;            // 時格納用
    private int frameNum;           // フレームのカウント
    private int frameRedNum;           // 赤丸のフレームのカウント

    public int count;   // 連打防止用

    bool bStageChange;      // ステージ移行用フラグ


	// Use this for initialization
	void Start () {
        nClearStage = PlayerPrefs.GetInt("ClearStage", 0);      // クリア情報の取得(セーブデータ)
        nClearStage = 12;      // クリア情報の取得(セーブデータ)
        // 最初に選択状態にしたいボタンの設定
        Stage[0].GetComponent<SpriteRenderer>().sprite = SpriteAfter[0];
        nSelect = 1;

        for (int i = nClearStage + 1; i < numStage; i++)
        {
            Stage[i].GetComponent<SpriteRenderer>().color 
                = new Color(Stage[i].GetComponent<SpriteRenderer>().color.r, 
                            Stage[i].GetComponent<SpriteRenderer>().color.g, 
                            Stage[i].GetComponent<SpriteRenderer>().color.b, 0.3f);
        }

        RedCircle.GetComponent<SpriteRenderer>().color
            = new Color(RedCircle.GetComponent<SpriteRenderer>().color.r,
                        RedCircle.GetComponent<SpriteRenderer>().color.g, 
                        RedCircle.GetComponent<SpriteRenderer>().color.b,
                        0.0f);          // 赤丸の初期アルファ値の設定

        RedCircle.GetComponent<SpriteRenderer>().sprite = AnimTexture[0];

        bStageChange = false;   // ステージ移行用フラグ初期化

        // 選択用テクスアニメの設定
        changeFrameSecond = 0.25f;  // 画像の更新時間の設定
        dTime = 0.0f;   // 時間の初期化
        frameNum = 0;   // フレームカウントの初期化
        frameRedNum = 0;   // フレームカウントの初期化

        count = 0;
	}
	
	// Update is called once per frame
    void Update()
    {
        // カメラの操作外で操作する
        if (CameraSceneSelect.CmeraStart == "Normal")
        {
            SelectProcess();    // ステージセレクト処理
            SelectEnter();
        }



        // 選択中ポイントのアニメーション
        dTime += Time.deltaTime;
        if (changeFrameSecond < dTime)
        {
            dTime = 0.0f;
            frameNum++;
            if (frameNum >= SpriteAfter.Length) frameNum = 0;
            Stage[nSelect - 1].GetComponent<SpriteRenderer>().sprite = SpriteAfter[frameNum];
        }
    }

    // ステージセレクト処理
    void SelectProcess()
    {
        // キー操作
        if ((Input.GetAxis("LeftStickX") < 0 || Input.GetKeyDown(KeyCode.LeftArrow)) &&
            nSelect > 1 && count >= 20) 
        {
            nSelect--;   // ひとつ左へ
            count = 0;
        }

        if (numStage == nClearStage)
        {
            if ((Input.GetAxis("LeftStickX") > 0 || Input.GetKeyDown(KeyCode.RightArrow)) && 
                nSelect < numStage && count >=20)
            {
                nSelect++;   // ひとつ右へ
                count = 0;
            }
        }
        else
        {
            if ((Input.GetAxis("LeftStickX") > 0 || Input.GetKeyDown(KeyCode.RightArrow)) &&
                nSelect < (nClearStage + 1) && count >= 20)
            {
                nSelect++;   // ひとつ右へ
                count = 0;
            }
        }

        // 選択中ステージの移動
        for (int nCount = 0; nCount < numStage; nCount++)
        {
            if(nCount != nSelect - 1)
            {
                Stage[nCount].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージの選択解除
            }
        }

        // カメラ移動条件
        if (nSelect == 6)
        {
            CameraSceneSelect.MoveCamera1();    // カメラの位置変更
        }
        else if (nSelect == 7)
        {
            CameraSceneSelect.MoveCamera2();    // カメラの位置変更
        }
        count++;

        //switch (nSelect)
        //{
        //    case 1:
        //        Stage[0].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ01を選択
        //        Stage[1].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ02の選択解除
        //        break;
        //    case 2:
        //        Stage[0].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ01の選択解除
        //        Stage[1].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ02を選択
        //        Stage[2].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ03の選択解除
        //        break;
        //    case 3:
        //        Stage[1].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ02の選択解除
        //        Stage[2].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ03を選択
        //        Stage[3].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ04の選択解除
        //        break;
        //    case 4:
        //        Stage[2].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ03の選択解除
        //        Stage[3].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ04を選択
        //        Stage[4].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ05の選択解除
        //        break;
        //    case 5:
        //        Stage[3].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ04の選択解除
        //        Stage[4].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ05を選択
        //        Stage[5].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ06の選択解除
        //        break;
        //    case 6:
        //        Stage[4].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ05の選択解除
        //        Stage[5].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ06を選択
        //        Stage[6].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ07の選択解除
        //        CameraSceneSelect.MoveCamera1();    // カメラの位置変更
        //        break;
        //    case 7:
        //        Stage[5].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ06の選択解除
        //        Stage[6].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ07を選択
        //        Stage[7].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ08の選択解除
        //        CameraSceneSelect.MoveCamera2();    // カメラの位置変更
        //        break;
        //    case 8:
        //        Stage[6].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ06の選択解除
        //        Stage[7].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ07を選択
        //        Stage[8].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ08の選択解除
        //        break;
        //    case 9:
        //        Stage[7].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ08の選択解除
        //        Stage[8].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ09を選択
        //        Stage[9].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ10の選択解除
        //        break;
        //    case 10:
        //        Stage[8].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ09の選択解除
        //        Stage[9].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ10を選択
        //        Stage[10].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ11の選択解除
        //        break;
        //    case 11:
        //        Stage[9].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ10の選択解除
        //        Stage[10].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ11を選択
        //        Stage[11].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ12の選択解除
        //        break;
        //    case 12:
        //        Stage[10].GetComponent<SpriteRenderer>().sprite = SpriteBefore;      // ステージ11の選択解除
        //        Stage[11].GetComponent<SpriteRenderer>().sprite = SpriteAfter;       // ステージ12を選択
        //        break;

        //}
    }

    // ステージ決定処理
    void SelectEnter()
    {
        // キー操作
        if (Input.GetKey(KeyCode.Joystick1Button0) || Input.GetKey(KeyCode.Space))
        {
            RedCircle.GetComponent<Transform>().position = Stage[nSelect - 1].GetComponent<Transform>().position + new Vector3(0.5f, -0.5f, 0.0f);  // 赤丸の座標設定
            RedCircle.GetComponent<SpriteRenderer>().color
                = new Color(RedCircle.GetComponent<SpriteRenderer>().color.r,
                            RedCircle.GetComponent<SpriteRenderer>().color.g,
                            RedCircle.GetComponent<SpriteRenderer>().color.b,
                            1.0f);  // 赤丸のアルファ値の設定

            bStageChange = true;
           //dTime = 0.0f;   // 時間の初期化
           frameNum = 0;   // フレームカウントの初期化

            // 選択中ステージの移動
            switch (nSelect)
            {
                case 1:
                    fade.SetFadeOut("stage001");     // ステージ1にフェードで移動
                    break;
                case 2:
                    fade.SetFadeOut("stage002");     // ステージ2にフェードで移動
                    break;
                case 3:
                    fade.SetFadeOut("stage003");     // ステージ3にフェードで移動
                    break;
                case 4:
                    fade.SetFadeOut("stage004");     // ステージ4にフェードで移動
                    break;
                case 5:
                    fade.SetFadeOut("stage005");     // ステージ5にフェードで移動
                    break;
                case 6:
                    fade.SetFadeOut("stage006");     // ステージ6にフェードで移動
                    break;
                case 7:
                    fade.SetFadeOut("stage007");     // ステージ7にフェードで移動
                    break;
                case 8:
                    fade.SetFadeOut("stage008");     // ステージ8にフェードで移動
                    break;
                case 9:
                    fade.SetFadeOut("stage009");     // ステージ9にフェードで移動
                    break;
                case 10:
                    fade.SetFadeOut("stage010");     // ステージ10にフェードで移動
                    break;
                case 11:
                    fade.SetFadeOut("stage011");     // ステージ11にフェードで移動
                    break;
                case 12:
                    fade.SetFadeOut("stage012");     // ステージ12にフェードで移動
                    break;
            }
        }

        if (bStageChange)
        {
            // アニメーションの更新
            dTime += Time.deltaTime;
            if (changeFrameSecond < dTime)
            {
                frameRedNum++;
                if (frameRedNum >= AnimTexture.Length) { } //frameNum = 0;
                else
                {
                    RedCircle.GetComponent<SpriteRenderer>().sprite = AnimTexture[frameRedNum];
                }
            }
            
        }
    }

    // クリア情報の更新(外部呼出し)
    static public void SetInformationClear(int stageNumber)
    {
        if (nClearStage < stageNumber)
        {
            nClearStage = stageNumber;
            PlayerPrefs.SetInt("ClearStage", nClearStage);   // クリア情報の格納
        }
    }
}
