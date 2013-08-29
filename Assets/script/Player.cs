using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
	public GameObject tile;
	private List<Transform> gunPort;
	private tk2dCamera m_camera;
	
	public int totalHP;
	public float speed;
	public int attack;
	public float coldTime=0.3f;
	
	private int score;
	private int curHP;
	private float preFireTime;
	

	// Use this for initialization
	void Start () {
		score=0;
		curHP=totalHP;
		preFireTime=Time.time;
		m_camera=(tk2dCamera)FindObjectOfType(typeof(tk2dCamera));
		gunPort=GetComponent<tk2dSpriteAttachPoint>().attachPoints;
	}
	
	// Update is called once per frame
	void Update () {
		float x=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
		float y=Input.GetAxis("Vertical")*Time.deltaTime*speed;
		
		Vector3 tmp=new Vector3(transform.position.x+x,transform.position.y+y,transform.position.z);
		transform.position=Environment.checkedPos(tmp);
		
		if(Input.GetKey(KeyCode.X)&&canFire())
		{
			for(int i=0;i<gunPort.Count;i++)
			Instantiate (tile,gunPort[i].position,Quaternion.identity);
		}
		
	}
	
	public void changeHP(int num)
	{
		curHP-=num;
		if(curHP<=0) {}
		float rate=1.0f*curHP/totalHP;
		m_camera.SendMessage("showHP",rate);
		
	}
	public void changeScore(int num)
	{
		score+=num;
		m_camera.SendMessage("showScore",score);
	}
	
	private bool canFire()
	{
		if(Time.time-preFireTime<coldTime)
			return false;
		else {
			preFireTime=Time.time;
			return true;
		}
	}
	void OnTriggerEnter(Collider other)
	{
		
		if(other.tag=="enemy")
			changeHP(10);
	}
		
}
