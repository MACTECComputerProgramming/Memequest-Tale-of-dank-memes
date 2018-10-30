using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class basePlayer : MonoBehaviour  {


    public string name;

    public float baseHp = 100;
    public float curHp;

    public float  baseMp;
    public float curMp;

    public int stam;
    public int intel;
    public int dex;
    public int agi;

  //  bool isDead = false;
  //  bool hurt;

    public string current_health;
    public string base_health;

    public float HurtPlayer = 10;
/*
    void hurt()
    {
        curHp = curHp - HurtPlayer;
    }

    */
   /* void Update()
    {
        current_health =  curHp.ToString();
        base_health = baseHp.ToString();

        Debug.Log(curHp);

        if (curHp <= 0)
        {
            Debug.Log("Something died");

        }
    */
    //}
}
