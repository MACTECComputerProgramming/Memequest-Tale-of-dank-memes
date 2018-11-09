using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour {

    public enum PerformAction
    {
        Wait,
        Takeaction,
        Action
    }
    public PerformAction fighting;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { 
        
        Debug.Log(fighting);
	switch(fighting)
    {
       

        
            case (PerformAction.Wait):

            break;

            case (PerformAction.Takeaction):

            break;

            case (PerformAction.Action):

            break;

          


        
    }
	


	}
}
