using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	

	[SerializeField]
	private StatusIndicator statusIndicator;
	[SerializeField]
	private int diff;
	[System.Serializable]
	public class Stats
	{

		private int _curHealth;
		public  int maxhealth = 100;

	

	public int curHealth{
		get{ return _curHealth;}
			set{ _curHealth = Mathf.Clamp(value, 0, maxhealth);}
	}

	


	public void Init(){
		curHealth = maxhealth;
	}
	}

	public Stats stats = new Stats();
	void Start(){
		stats.Init ();

		if (statusIndicator != null) {
			statusIndicator.SetHealth (stats.curHealth, stats.maxhealth );
		}
	}

	public int getDiff(){

		return diff;
	}

	public void DamageEnemy (int damage){
		stats.curHealth -= damage;
		if (stats.curHealth <= 0) {
			LevelManager.KillEnemy (this);
		}
		if (statusIndicator != null) {
			statusIndicator.SetHealth (stats.curHealth, stats.maxhealth);
		}

	}
}
