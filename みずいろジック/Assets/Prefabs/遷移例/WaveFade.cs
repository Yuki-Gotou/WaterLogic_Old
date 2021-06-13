using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveFade : MonoBehaviour {

    public float PosX;      // 座標移動X(イン)
    public float PosY;      // 座標移動Y(イン)
    public float RevPosX;   // 座標移動X(アウト)
    public float RevPosY;   // 座標移動Y(アウト)

	void Start () {

	}

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            this.transform.position += 
                new Vector3(PosX * Time.deltaTime, PosY * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.G))
        {
            this.transform.position += 
                new Vector3(RevPosX * Time.deltaTime, RevPosY * Time.deltaTime, 0);
        }
    }

}
