using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public tk2dUIProgressBar HPBar;
	public GameObject boom;
	
	public int totalHP=10;
	public int attack=2;
	public float speed=0f;
	public int score=20;
	
	private int curHP;
	private Player tplayer;
	
	
	// Use this for initialization
	void Start () {
		curHP=totalHP;
		tplayer=(Player)FindObjectOfType(typeof(Player));
		
	}
	
	// Update is called once per frame
	void Update () {
		if(tplayer==null) tplayer=(Player)FindObjectOfType(typeof(Player));
	}
	void OnTriggerEnter(Collider other)
	{
		
		if(other.tag=="bullet")
		{
			curHP-=tplayer.attack;
			tplayer.changeScore(score);
		}
		if(other.tag=="Player")
		{
			curHP=0;
		}
		if(curHP<=0)
		{
			Instantiate(boom,transform.position,Quaternion.identity);
			Destroy(this.gameObject);			
		}
		HPBar.Value=curHP*1.0f/totalHP;
		
	}

}
