using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Anima2D;

public class GOALanime : MonoBehaviour
{
    Animation Goal;


    void Start()
    {
        Goal = this.gameObject.GetComponent<Animation>();
        Goal.Play("完成画像版ゴール");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Goal.Play("消えるゴール");
        }
            if (Input.GetKeyDown(KeyCode.L))
            {
                Goal.Play("完成画像版ゴール");
            }
        }
    }

