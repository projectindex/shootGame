using UnityEngine;
using System.Collections;

public class MapMove : MonoBehaviour {
	public float speed=-20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x=speed*Time.deltaTime;
		transform.Translate(x,0,0,Space.World);
	}
}
