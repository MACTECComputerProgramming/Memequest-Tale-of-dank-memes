using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {


	basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
	LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();

	public void Attack1(){
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
		LevelManager lm = LevelManager.FindObjectOfType<LevelManager> ();
		if (lm.heroTurn == true) {
			bp.playerAttack1 ();
		} else {
			lm.enemyTurn ();
		}
	}

	public void Attack2(){
		
	}

	public void Defend(){
		
	}
}
