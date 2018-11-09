using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basePlayer : MonoBehaviour 
{
[SerializeField]
private StatusIndicator statusIndicator;
[System.Serializable]
public class Stats
{
 
	private int _curHealth;
	public  int maxhealth = 100;



	public int curHealth
    {
		get{ return _curHealth;}
		set{ _curHealth = Mathf.Clamp(value, 0, maxhealth);}
	}




	public void Init()
    {
		curHealth = maxhealth;
	}
}

public Stats stats = new Stats();
void Start()
{
	stats.Init ();

	if (statusIndicator != null) 
    {
		statusIndicator.SetHealth (stats.curHealth, stats.maxhealth );
	}
}
	public void DamagePlayer (int damage)
    {
		stats.curHealth -= damage;
		if (stats.curHealth <= 0) 
        {
			
		}
		if (statusIndicator != null) 
        {
			statusIndicator.SetHealth (stats.curHealth, stats.maxhealth);
		}  
    
        

	}
}

