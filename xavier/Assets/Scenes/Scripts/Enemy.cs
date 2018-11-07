using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	public bool turn = false;

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

	void Update(){
		if(turn == true){
			Debug.Log ("Enemy turn");
			Attack ();
			turn = false;
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

	public static void Attack(){
		  basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();
		Debug.Log ("Attack");
		bp.DamagePlayer (25);
		lm.heroTurn = true;


	}

	IEnumerable wait (){
		yield return new WaitForSeconds (3);
	}
}
