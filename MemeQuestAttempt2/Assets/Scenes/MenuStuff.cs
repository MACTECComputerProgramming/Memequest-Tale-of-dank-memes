using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStuff : MonoBehaviour {


    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene(1));

    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }

	
}
