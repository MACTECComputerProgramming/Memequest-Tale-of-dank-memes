using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public int i = 0;

	public List<Enemy> E = new List<Enemy> ();
	public bool heroTurn = true;



	[SerializeField]
	private GameObject tile;

	[SerializeField]
	private Enemy[] enemy = new Enemy[3];

	private int difficulty = 50;

	public float TileSize{
		get{ return tile.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;}
	}
	// Use this for initialization
	void Start () {
		createLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return) || heroTurn == false){
			heroTurn = false;
			enemyTurn ();
			Debug.Log (heroTurn + " Pressed Enter" );
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit ();
		}
	}

	//builds the actual areas that the characters battle in.
	private void createLevel(){

		Vector3 worldStart = Camera.main.ScreenToWorldPoint (new Vector3 (0,130,-5 ));

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
	
		if (difficulty >= 0) {
			if (x > 6) {
				if (Random.Range (0.0f, 10.0f) > 3) {
					spawnEnemy (newTile);
				}
			}
		}
	}

	private void spawnEnemy(GameObject t){
		float rand = Random.Range (0.0f, enemy.Length);

		Enemy e = Instantiate (enemy[(int)rand]);

		int count = e.getDiff ();

		e.name = "enemy " + i;

		difficulty -= count;
		e.transform.position = new Vector3 (t.transform.position.x, t.transform.position.y, 0);

		E.Add (e);
		Debug.Log (e.name);

		i += 1;
	}

	public void enemyTurn(){
		heroTurn = false;
		Debug.Log ("Start");

		if (heroTurn == false) {
			foreach(Enemy ee in E){
				ee.turn = true;
				Debug.Log (ee.name);

			}
		}
	}



	public static void KillEnemy(Enemy enemy){
		
		Destroy (enemy.gameObject);

	}

	public static void killPlayer(basePlayer player){
		Destroy (player);
		basePlayer bp = LevelManager.FindObjectOfType<basePlayer> ();
		if (bp.stats.curHealth == 0) {
			SceneManager.LoadScene ("gameOver");
		}
}
}
