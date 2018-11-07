using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager1 : MonoBehaviour 
{
	public void StartGame()
	{
		SceneManager.LoadScene ("Test_CombatScreen");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}

