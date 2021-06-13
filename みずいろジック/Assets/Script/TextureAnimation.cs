////////////////////////////////////////////
// 
// テクスチャアニメーション
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAnimation : MonoBehaviour {
    public Sprite[] textures;   // アニメーション用テクスチャ
    public float changeFrameSecond; // 画像の更新時間
    private float dTime;            // 時格納用
    private int frameNum;           // フレームのカウント


	// Use this for initialization
	void Start () {
        dTime = 0.0f;   // 時間の初期化
        frameNum = 0;   // フレームカウントの初期化
	}
	
	// Update is called once per frame
	void Update () {
		// アニメーションの更新
        dTime += Time.deltaTime;
        if (changeFrameSecond < dTime)
        {
            dTime = 0.0f;
            frameNum++;
            if (frameNum >= textures.Length) frameNum = 0;
            GetComponent<SpriteRenderer>().sprite = textures[frameNum];
        }
	}
}
