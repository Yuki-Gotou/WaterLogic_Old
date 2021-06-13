///////////////////////////////////////////
// 
// リザルト画面のボタンシステム
// 
///////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      // シーン指導におそらく必要
using UnityEngine.UI; // UIコンポーネントの使用

public class ResultGameOverMenu : MonoBehaviour
{

    static int stageNumber;

    public GameObject cRetry;
    public GameObject cSelect;
    public GameObject cTitle;
    private int nSelect; // ボタン操作用

    public Sprite sRetryBefore;     // ネクスト文字の画像の変化前
    public Sprite sRetryAfter;      // ネクスト文字の画像の変化後
    public Sprite sSelectBefore;   // セレクト文字の画像の変化前
    public Sprite sSelectAfter;    // セレクト文字の画像の変化後
    public Sprite sTitleBefore;    // タイトル文字の画像の変化前
    public Sprite sTitleAfter;     // タイトル文字の画像の変化後

    public int count;   //連打防止用

    void Start()
    {
        // 最初に選択状態にしたいボタンの設定
        nSelect = 0;

        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("LeftStickX") < 0 || Input.GetKeyDown(KeyCode.LeftArrow))
            && nSelect > 0 && count >= 20)
        {
            nSelect--;　// ひとつ左に
            count = 0;
        }

        if ((Input.GetAxis("LeftStickX") > 0 || Input.GetKeyDown(KeyCode.RightArrow))
            && nSelect < 2 && count >= 20)
        {
            nSelect++;   // ひとつ右に
            count = 0;
        }

        switch (nSelect)
        {
            case 0:
                cRetry.GetComponent<SpriteRenderer>().sprite = sRetryAfter;  // 次へ選択
                cSelect.GetComponent<SpriteRenderer>().sprite = sSelectBefore;  // セレクトを選択解除
                break;
            case 1:
                cRetry.GetComponent<SpriteRenderer>().sprite = sRetryBefore;  // 次へ選択解除
                cSelect.GetComponent<SpriteRenderer>().sprite = sSelectAfter;  // セレクトを選択
                cTitle.GetComponent<SpriteRenderer>().sprite = sTitleBefore;  // タイトルを選択解除
                break;
            case 2:
                cSelect.GetComponent<SpriteRenderer>().sprite = sSelectBefore;  // セレクトを選択解除
                cTitle.GetComponent<SpriteRenderer>().sprite = sTitleAfter;  // タイトルを選択
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            switch (nSelect)
            {
                case 0:
                    RetryStage();
                    break;
                case 1:
                    SceneManager.LoadScene("SelectScene");                    
                    break;
                case 2:
                    SceneManager.LoadScene("Title");                    
                    break;
            }
        }
        count++;
    }

    // 次のステージへ
    public void RetryStage()
    {
        switch (stageNumber)
        {// (" ")の中に行きたいシーンの名前を入れる

            case 1:    // ステージ1へ
                SceneManager.LoadScene("stage001");
                break;
            case 2:    // ステージ2へ
                SceneManager.LoadScene("stage002");
                break;
            case 3:    // ステージ3へ
                SceneManager.LoadScene("stage003");
                break;
            case 4:    // ステージ4へ
                SceneManager.LoadScene("stage004");
                break;
            case 5:    // ステージ5へ
                SceneManager.LoadScene("stage005");
                break;
            case 6:    // ステージ6へ
                SceneManager.LoadScene("stage006");
                break;
            case 7:    // ステージ7へ
                SceneManager.LoadScene("stage007");
                break;
            case 8:    // ステージ8へ
                SceneManager.LoadScene("stage008");
                break;
            case 9:    // ステージ9へ
                SceneManager.LoadScene("stage009");
                break;
            case 10:    // ステージ10へ
                SceneManager.LoadScene("stage010");
                break;
            case 11:    // ステージ11へ
                SceneManager.LoadScene("stage011");
                break;
            case 12:    // ステージ12へ
                SceneManager.LoadScene("stage012");
                break;
        }
    }

    static public void SetInformationStage(int StageNumber)
    {
        stageNumber = StageNumber;
    }
}