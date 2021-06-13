using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーン遷移に必要!

public class LevelSelectFlag : MonoBehaviour {
    public int MAX_SCENE;
    public GameObject[] m_Aroow;
    public GameObject[] Level;
    public Vector3[] Pos;
    public bool UseFlg;
   // public SCENE m_ID;
    public int  m_ID;
    public enum SCENE
    {
        LEVEL1 = 0,
        LEVEL2,
        LEVEL3,
    };

	void Start () {
        FlagManager.Instance.ResetFlags();
         for (int i = 0; i < MAX_SCENE; i++ )
         {
            Pos[i] = Level[i].GetComponent<Level>().transform.position;
            // Pos[i] = Level[i].CompareTag("") .transform.position;
         }
        // m_ID = SCENE.LEVEL1;
         m_ID = 0;
    }
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && (!UseFlg))
        {
            //  m_ID = SCENE.LEVEL1;
              m_ID =( m_ID+1);

             //m_Aroow[0].GetComponent<Aroow>().UseMoveFlg = false;
             //m_Aroow[1].GetComponent<Aroow>().UseMoveFlg = false;
              UseFlg = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (!UseFlg))
        {
            //  m_ID = SCENE.LEVEL1;
            m_ID = (m_ID - 1);
            UseFlg = true;
           // m_Aroow[0].GetComponent<Aroow>().UseMoveFlg = false;
           // m_Aroow[1].GetComponent<Aroow>().UseMoveFlg = false;
        }
       
        MaxOver();

       
        //Ｌｅｖｅｌ　シーン　各シーンへ飛べる
        switch(m_ID)
        {
            case 0:
                if (Input.GetKey(KeyCode.Return))
                {
                   // SceneManager.LoadScene("Main");
                    SceneManager.LoadScene("ResultGameOver");
                }
                break;
            case 1:
                if (Input.GetKey(KeyCode.Return))
                {
                   // SceneManager.LoadScene("GamePlaying");
                   
                    SceneManager.LoadScene("ResultClear");
                }

                break;
            case 2:
                if (Input.GetKey(KeyCode.Return))
                {
                    SceneManager.LoadScene("Title");
                }
                break;
                
        }


       //     if (Input.GetKey(KeyCode.Space))
       //     {
       //         if (FlagManager.Instance.flags[0] == true)
       //         {
       //             Debug.Log("True");
       //             FlagManager.Instance.flags[0] = true;
       //         }
       //         else
       //         {
       //             Debug.Log("False");
       //         }
       //     }
       //
       // if (Input.GetKey(KeyCode.RightArrow))
       // {
       //     FlagManager.Instance.flags[0] = false;
       //     FlagManager.Instance.flags[1] = true;
       // }
       // if (Input.GetKey(KeyCode.LeftArrow))
       // {
       //     FlagManager.Instance.flags[0] = true;
       //     FlagManager.Instance.flags[1] = false;
       // }
	}

   public  void MaxOver()
    {
        if(m_ID < 0)
        {
            m_ID = (0);
        }
        else if (m_ID >= MAX_SCENE)
        {
            m_ID = (MAX_SCENE - 1);
        }
    }
}
