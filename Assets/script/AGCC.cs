using UnityEngine;
using System.Collections;

public class AGCC : MonoBehaviour {
	
	public ArcaletGame ag=null;
	
	private const string gguid="dcabfab0-cc3c-ac48-8ce2-69239ebb7052";
	private const string sguid="457d40d4-4b3f-9740-ae70-cc8e7350a091";
	private byte[] gcert={0xcd,0x39,0xda,0x3b,0x74,0xe3,0x3,0x40,0xa3,0xbb,0xa9,0xbc,0x5e,0x4c,0x49,0xc8,0xdc,0xf0,0xa4,0xde,0xf6,0xc8,0x54,0x4d,0x9f,0x6d,0xed,0x4e,0x6c,0xa5,0xcc,0xfb,0x3d,0xe7,0x3e,0x7a,0x59,0xc8,0xea,0x48,0x95,0xd2,0x54,0xc4,0x31,0xc2,0x7f,0xc9,0xe7,0xe3,0x50,0xac,0x35,0xc9,0xaf,0x49,0x80,0x4d,0xbd,0xd9,0xc9,0x5d,0xe6,0x4c,0x8,0x69,0x58,0xca,0xf7,0xce,0xc0,0x4b,0x99,0x21,0x86,0xc4,0xf0,0xec,0x28,0x5b,0x91,0x97,0x8a,0x50,0x10,0xcb,0xc9,0x47,0x8b,0x18,0x40,0x82,0xbb,0xa3,0x88,0x6a,0xb5,0xcd,0xe5,0x29,0x9f,0x9e,0x1a,0x4d,0xad,0x49,0x5,0x3e,0x8b,0x23,0x5e,0x14,0xa6,0xb2,0xc0,0xea,0xef,0x44,0x58,0x4c,0x8f,0xbd,0xff,0xf5,0xd3,0x46,0x26,0x8a};
	
	
	private bool hadLaunched=false;
	
	void Awake()
	{
		DontDestroyOnLoad(this);
		hadLaunched=false;
	}
	
	// Use this for initialization
	void Start () {
		Application.LoadLevel(1);
	}
	void OnApplicationQuit()
	{
		ag.Dispose();
	}
	
	// Update is called once per frame
	void Update () {
		if(hadLaunched) ag.EventDispatcher();
	}
	public void waitCall(string userId,string password)
	{
		Debug.Log("tessssssss");
		ag=new ArcaletGame(userId,password,gguid,sguid,gcert);
		//this.userid=userId;
		ag.onCompletion=myComplete;
		ag.onStateChanged=stateChange;
		ag.onMessageIn=myMessage;
#if UNITY_WEBPLAYER
        ag.WebLaunch();
#else
        ag.STALaunch();
#endif
		
		hadLaunched=true;
	}
	
	void myComplete(int code,ArcaletGame game)
	{
		if(code==0) 
		{
			Debug.Log("ok");
			ag.Send("come");
			Application.LoadLevel("test");
		}
		else
		{
			Debug.Log(code.ToString());
			
		}
		
	}
	void stateChange(int state,int code,ArcaletGame game)
	{
		//if(code==0)
			Debug.Log(state);
	}
	void myMessage(string msg,int delay,ArcaletGame game)
	{
			Debug.Log(msg);
	}
	
}