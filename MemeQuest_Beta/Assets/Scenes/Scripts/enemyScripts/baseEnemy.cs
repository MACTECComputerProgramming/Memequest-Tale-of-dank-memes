using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class baseEnemy  {

	public string name;

    public enum Type
    {
        Grass,
        Water,
        Fire,
        Electric
    }

    public enum Rarity
    {
        Common,
        uncommon,
        Rare,
        SuperRare
    }

    public Type EnemyType;
    public Type rarity;

    public float baseHp;
    private float curHp;



    public float  baseMP;
    public float curMP;
    public float  baseDEF;
    public float curDEF;
   
    /*
    public float CurHp
{
  get { return curHp; }
  set { curHp = value; }
}
    */

}
