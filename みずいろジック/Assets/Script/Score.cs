///////////////////////////////////////////////////
// 
// スコア
// 
///////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// スコアいじるために必要？
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static public int score;
    static public Text ScoreLabel;

    void Start()
    {
        score = 0;
        // 「Text」コンポーネントにアクセスして取得する（ポイント）
        ScoreLabel = this.gameObject.GetComponent<Text>();
        ScoreLabel.text = "Score: " + score;        // 最初に表示される文字
    }

    void Update()
    {
       
    }

    // スコア加算関数(外部呼出し)
    static public void AddScore(int nScore)
    {

        // 引数を加算していく。
        score += nScore;

        //ScoreLabel.text = "Score: " + score;       // 加算後表示される文字
    }
}