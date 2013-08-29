using UnityEngine;
using System.Collections;

public class Qcamera : MonoBehaviour {
	public tk2dTextMesh score;
	public tk2dUIProgressBar HPBar;
	
	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	
	public static int id;
	// Use this for initialization
	void Start () {
		switch(id)
		{
		case 0:Instantiate(player1/*,new Vector3(0,0,-1),Quaternion.identity*/);break;
			case 1:Instantiate(player2/*,new Vector3(0,0,-1),Quaternion.identity*/);break;
			case 2:Instantiate(player3/*,new Vector3(0,0,-1),Quaternion.identity*/);break;
		default:Instantiate(player1);break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void showHP(float HPrate)
	{
		HPBar.Value=HPrate;
	}
	public void showScore(int num)
	{
		score.text=num.ToString();
		score.Commit();
	}
	

}
