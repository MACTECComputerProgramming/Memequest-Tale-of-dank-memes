using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStuff : MonoBehaviour {


	public void PlayGame()
	{
    SceneManager.LoadScene("Test_CambatScreen");
	}
    

    public void Quit()
    {
        Application.Quit();
		Debug.Log ("You pussy");

    }

    public void BackToTheMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

	public void Restart()
	{
		SceneManager.LoadScene ("Menu 1");
	}
	
    //make skript to cause blackness should the slider get changed



}
