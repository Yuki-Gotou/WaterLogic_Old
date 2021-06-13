////////////////////////////////////////////
// 
// ステージ番号を渡す用
// 
////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageInformation : MonoBehaviour {
    public int stageNumber;     // unity側でステージ番号の設定
    static int stageInfo;       // ステージ番号の格納用

	// Use this for initialization
	void Start () {
        stageInfo = stageNumber;
        ResultClearMenu.SetInformationStage(stageInfo);
        ResultGameOverMenu.SetInformationStage(stageInfo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static public int GetStageNumber()
    {
        return stageInfo;
    }
}
