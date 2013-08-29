using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour {
	public float speed=50f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x=Time.deltaTime*speed;
		transform.Translate(x,0,0,Space.World);
		
		
	}
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag=="enemy")
			Destroy(this.gameObject);
	}
}
