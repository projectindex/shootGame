using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	
	private tk2dSpriteAnimator ani;
	// Use this for initialization
	void Start () {
		ani=GetComponent<tk2dSpriteAnimator>();
		ani.AnimationCompleted+=completeAni;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void completeAni(tk2dSpriteAnimator ani,tk2dSpriteAnimationClip clipid)
	{
		Destroy(this.gameObject);
	}
}
