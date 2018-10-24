using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManger : MonoBehaviour {

    public basePlayer player;

    public enum TurnState
    {
        Enemy_Turn,
        Waiting,
        Action,
        Dead,
        Selecting
    }

    public TurnState state;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(state);

        switch (State)
        {
            case (TurnState.Enemy_Turn):

            break;

            case (TurnState.Waiting):

            break;

            case (TurnState.Action):

            break;

            case (TurnState.Dead):

            break;

            case (TurnState.Selecting):

            break;



        }







	}
}
