using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basePlayer : MonoBehaviour {

	LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();

[SerializeField]
private StatusIndicator statusIndicator;
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
		_curHealth = maxhealth;
	}
}

public Stats stats = new Stats();
void Start(){
	stats.Init ();

	if (statusIndicator != null) {
		statusIndicator.SetHealth (stats.curHealth, stats.maxhealth );
	}
}
	public void DamagePlayer (int damage){
		stats.curHealth -= damage;
		if (stats.curHealth <= 0) {LevelManager.FindObjectOfType<LevelManager> ();
			LevelManager.killPlayer (this);
		}
		if (statusIndicator != null) {
			statusIndicator.SetHealth (stats.curHealth, stats.maxhealth);
		}

	}

	public void playerAttack1(){
		foreach(Enemy ee in lm.E){
			if(Random.Range(0f, lm.E.Count) > 0){
				if(ee == null){
					continue;
				}
				ee.DamageEnemy (25);
			}
		}

		lm.heroTurn = false;
	}

	public void playerAttack2(){
		
	}

	public void playerDefend(){
	
	}


}

