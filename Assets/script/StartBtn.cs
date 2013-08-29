using UnityEngine;
using System.Collections;

public class StartBtn : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public tk2dUITextInput account;
	public tk2dUITextInput pass;
	
	public tk2dUIToggleButtonGroup pgroup;
	private AGCC ag;
	// Use this for initialization
	void Start () {
		tk2dUIItem btn=GetComponent<tk2dUIItem>();
		btn.OnClick+=myClick;
		ag=(AGCC)FindObjectOfType(typeof(AGCC));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void myClick()
	{
		Qcamera.id=pgroup.SelectedIndex;
		ag.waitCall(account.Text,pass.Text);
		
	}
}
