using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aroow : MonoBehaviour {
    public bool UseMoveFlg;        //移動中なのか
    float DiffAlpha;
   public float Alpha;
	// Use this for initialization
	void Start () {
        Renderer rend = GetComponent<Renderer>();
        Color c = rend.material.color;
        c.a = 0.3f;
        Alpha = c.a;

       // c.a = 0.5f;

        rend.material.color = c;
        //最初は、減少処理
        DiffAlpha = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
		if(UseMoveFlg)
        {
            //このオブジェクトの色を取得
            Renderer rend = GetComponent<Renderer>();
            Color c = rend.material.color;
           
            //透明度変動
            Alpha = Alpha + DiffAlpha;
            if (c.a > 1.0f) { c.a = 1.0f; DiffAlpha = DiffAlpha * -1; }
            else if (c.a < 0.3f) { c.a = 0.1f; DiffAlpha = DiffAlpha * -1; }
            c.a = Alpha;
            rend.material.color=c;

        }
        else
        {
            //このオブジェクトの色を取得
            Renderer rend = GetComponent<Renderer>();
            Color c = rend.material.color;
            DiffAlpha = 0.05f;

            Alpha = 0.3f;
            c.a = Alpha;
            rend.material.color = c;
           
        }
	}
}
