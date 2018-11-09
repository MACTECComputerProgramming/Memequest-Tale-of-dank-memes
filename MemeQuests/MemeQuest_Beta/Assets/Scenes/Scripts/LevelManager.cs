using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	[SerializeField]
	private GameObject tile;

	[SerializeField]
	private Enemy enemy;

	private int difficulty = 3;

	public float TileSize{
		get{ return tile.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;}
	}
	// Use this for initialization
	void Start () {
		createLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//builds the actual areas that the characters battle in.
	private void createLevel(){

		Vector3 worldStart = Camera.main.ScreenToWorldPoint (new Vector3 (0,130 ));

		for (int y = 0; y < 3; y++) {
			for (int x = 0; x < 11; x++) {
				placeTile (x, y, worldStart);

			}
		}
	}

	//places the tiles in the needed position
	private void placeTile(int x, int y, Vector3 worldStart){
		GameObject newTile = Instantiate (tile);

		newTile.transform.position = new Vector3 (worldStart.x + (TileSize * x),worldStart.y + (TileSize * y), 0);
	

		if (x > 6) {
			if(Random.Range(0.0f, 10.0f) > 3){
			spawnEnemy (newTile);
			}
		}
	}

	private void spawnEnemy(GameObject t){
		Enemy sonic = Instantiate (enemy);


		sonic.transform.position = new Vector3 (t.transform.position.x, t.transform.position.y, 0);
	}
}
