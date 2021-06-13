using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public float NowPosX;       //現在ポジションX
    public float NowPosY;       //現在ポジションY
    public float FuturePosX;    //移動後座標X
    public float FuturePosY;    //移動後座標Y
    public float SpeedX;        //移動速度X
    public float SpeedY;        //移動速度Y
    public float Zoom;          //ズームする値
    public float Time;          //フレーム数
    public float MaxScale;      //最大スケール
    public float MinitScale;    //最小スケール
    public int ZoomF;           //ズームフラグ

    static public float fNowPosX;       //現在ポジションX
    static public float fNowPosY;       //現在ポジションY
    static public float fFuturePosX;    //移動後座標X
    static public float fFuturePosY;    //移動後座標Y
    static public float fSpeedX;        //移動速度X
    static public float fSpeedY;        //移動速度Y
    static public float fZoom;          //ズームする値
    static public float fTime;          //フレーム数
    static public float fMaxScale;      //最大スケール
    static public float fMinitScale;    //最小スケール
    static public int   nZoomF;           //ズームフラグ
    static public int OnFlg;            //ズーム開始合図
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(GameObject.Find("GOAL").transform.position.x, GameObject.Find("GOAL").transform.position.y, -10);
        NowPosX = transform.position.x;
        NowPosY = transform.position.y;
        FuturePosX = transform.position.x;
        FuturePosY = transform.position.y;
        SpeedX = 0;
        SpeedY = 0;
        Time = 100;
        MaxScale = 10.04761f;
        MinitScale = 2.5f;
        Camera.main.orthographicSize = MinitScale;
        Zoom = (MaxScale - MinitScale) / Time;
        ZoomF = 0;

        // 外部参照用変数の設定
        fNowPosX = NowPosX;
        fNowPosY=NowPosY;
        fFuturePosX=FuturePosX;
        fFuturePosY=FuturePosY;
        fSpeedX=SpeedX;
        fSpeedY=SpeedY;
        fZoom=Zoom;
        fTime=Time;
        fMaxScale=MaxScale;
        fMinitScale=MinitScale;
        nZoomF = ZoomF;
        OnFlg = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //カメラ移動可能
        //transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y + 0.1f, transform.position.z);

        //Camera.main.orthographicSize = 2.0f;
        // 内部参照用変数の設定
        NowPosX = fNowPosX;
        NowPosY = fNowPosY;
        FuturePosX = fFuturePosX;
        FuturePosY = fFuturePosY;
        SpeedX = fSpeedX;
        SpeedY = fSpeedY;
        Zoom = fZoom;
        Time = fTime;
        MaxScale = fMaxScale;
        MinitScale = fMinitScale;
        ZoomF = nZoomF;



        if (OnFlg == 1)
        {

            FuturePosX = GameObject.Find("Player").transform.position.x;
            FuturePosY = GameObject.Find("Player").transform.position.y;

            SpeedX = (FuturePosX - NowPosX) / Time;
            SpeedY = (FuturePosY - NowPosY) / Time;

            ZoomF = 2;
            OnFlg = 2;
        }

        if(SpeedX!=0||SpeedY!=0.0f)
        {
            NowPosX = NowPosX + SpeedX;
            NowPosY = NowPosY + SpeedY;

            if(SpeedX>0.0f)
            {
                if(FuturePosX<NowPosX)
                {
                    NowPosX = FuturePosX;
                    SpeedX = 0.0f;
                }
            }
            else if (SpeedX < 0.0f)
            {
                if (FuturePosX > NowPosX)
                {
                    NowPosX = FuturePosX;
                    SpeedX = 0.0f;
                }
            }

            if (SpeedY > 0.0f)
            {
                if (FuturePosY < NowPosY)
                {
                    NowPosY = FuturePosY;
                    SpeedY = 0.0f;
                }
            }
            else if (SpeedY < 0.0f)
            {
                if (FuturePosY > NowPosY)
                {
                    NowPosY = FuturePosY;
                    SpeedY = 0.0f;
                }
            }

            transform.position = new Vector3(NowPosX, NowPosY, transform.position.z);
        }

        //if (ZoomF == 1)
        //{
        //    Camera.main.orthographicSize = Camera.main.orthographicSize + Zoom;
        //    if (Camera.main.orthographicSize > MaxScale)
        //    {
        //        Camera.main.orthographicSize = MaxScale;
        //        ZoomF = 0;
        //    }
        //}

        if (ZoomF == 2)
        {
            Camera.main.orthographicSize = Camera.main.orthographicSize - Zoom;
            if (Camera.main.orthographicSize < MinitScale)
            {
                Camera.main.orthographicSize = MinitScale;
                ZoomF = 0;
                Debug.Log("ズーム中", gameObject);
                if(Enemy.Hit==1)
                {
                    Enemy.Hit = 2;
                }
                if (gouru.Hit == 1)
                {
                    gouru.Hit = 2;
                }
            }
        }

        

        // 外部参照用変数の設定
        fNowPosX = NowPosX;
        fNowPosY = NowPosY;
        fFuturePosX = FuturePosX;
        fFuturePosY = FuturePosY;
        fSpeedX = SpeedX;
        fSpeedY = SpeedY;
        fZoom = Zoom;
        fTime = Time;
        fMaxScale = MaxScale;
        fMinitScale = MinitScale;
        nZoomF = ZoomF;
    }

    static public void SetStartCamera()
    {
        if (nZoomF == 0)
        {
            fFuturePosX = 0.0f;
            fFuturePosY = 7.0f;

            fSpeedX = ((fFuturePosX - fNowPosX) / fTime);
            fSpeedY = ((fFuturePosY - fNowPosY) / fTime);
            nZoomF = 1;
        }

        if (fSpeedX != 0 || fSpeedY != 0.0f)
        {
            fNowPosX = fNowPosX + fSpeedX;
            fNowPosY = fNowPosY + fSpeedY;

            if (fSpeedX > 0.0f)
            {
                if (fFuturePosX < fNowPosX)
                {
                    fNowPosX = fFuturePosX;
                    fSpeedX = 0.0f;
                }
            }
            else if (fSpeedX < 0.0f)
            {
                if (fFuturePosX > fNowPosX)
                {
                    fNowPosX = fFuturePosX;
                    fSpeedX = 0.0f;
                }
            }

            if (fSpeedY > 0.0f)
            {
                if (fFuturePosY < fNowPosY)
                {
                    fNowPosY = fFuturePosY;
                    fSpeedY = 0.0f;
                }
            }
            else if (fSpeedY < 0.0f)
            {
                if (fFuturePosY > fNowPosY)
                {
                    fNowPosY = fFuturePosY;
                    fSpeedY = 0.0f;
                }
            }
        }

        Camera.main.orthographicSize = Camera.main.orthographicSize + fZoom;
        if (Camera.main.orthographicSize > fMaxScale)
        {
            Camera.main.orthographicSize = fMaxScale;
            nZoomF = 0;
        }
        //nZoomF = 1;
    }
}
