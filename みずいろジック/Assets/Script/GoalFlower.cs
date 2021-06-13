using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFlower : MonoBehaviour
{
    public static int GFlower;
    Animation Flower;

    void Start()
    {
        Flower = this.gameObject.GetComponent<Animation>();
        GFlower = 0;
    }

    void Update()
    {
        if (GFlower == 1) 
        {
            Flower.Play("ゴール演出");
        }
    }
}
