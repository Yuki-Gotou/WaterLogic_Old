using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WMath : MonoBehaviour {

    public int a;       //デバック用確認変数
    public float fScale;        //液体の初期量
    public static float idou;
    public static float MaxArea;    //最大Yスケール
    public int count;
    public static float MaxVolume;  //最大面容積
    public static float NowVolume;  //現在の液体容積
    public static float NowSpace;   //現在の余剰容積
    public static float NowChangeY; //現在のY変化量

    // Use this for initialization
    void Start () {
        a = 0;
        idou = 0.0f;
        MaxArea = (GameObject.Find("BOX").transform.localScale.y-2)*2;
        transform.localScale = new Vector3(transform.localScale.x, fScale/*MastMesh.maina*/, transform.localScale.z);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        count = 0;
        MaxVolume = MaxArea * (GameObject.Find("BOX").transform.localScale.x-1);
        NowVolume = transform.localScale.x * transform.localScale.y;
        NowSpace = MaxVolume - NowVolume;
        NowChangeY = 0.0f;
    }

    // Update is called once per frame
    void Update () {
        //変化があったら反応
        if (idou > 0.0f/*Input.GetKey(KeyCode.Space) */)
        {
            NowChangeY = idou / (GameObject.Find("BOX").transform.localScale.x - 1);
            idou = 0.0f;
        }
        //加算処理
        if (NowChangeY>0.0f)
        { 
            //スケール変更処理
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + 1.0f, transform.localScale.z);
            //transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (idou), transform.localPosition.z);
            count++;
            if (transform.localScale.y >= MaxArea)
            {
                transform.localScale = new Vector3(transform.localScale.x, MaxArea, transform.localScale.z);
                //transform.localPosition = new Vector3(transform.localPosition.x, 5.13f, transform.localPosition.z);
            }
            if(NowChangeY <= count)
            {
                NowChangeY = 0.0f;
                count = 0;
            }
        }
        //減算処理
        if (NowChangeY < 0.0f/*Input.GetKey(KeyCode.Space) */)
        {
            //スケール変更処理
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y -1.0f, transform.localScale.z);
            //transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + (idou), transform.localPosition.z);
            if (transform.localScale.y <= 0)
            {
                transform.localScale = new Vector3(transform.localScale.x, 0.0f, transform.localScale.z);
                //transform.localPosition = new Vector3(transform.localPosition.x, -1.33f, transform.localPosition.z);
            }
            if (-NowChangeY <= count)
            {
                NowChangeY = 0.0f;
                count = 0;
            }
        }

    }
}
