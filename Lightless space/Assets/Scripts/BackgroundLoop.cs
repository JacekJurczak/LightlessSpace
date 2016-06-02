using UnityEngine;
using System.Collections;

public class BackgroundLoop : MonoBehaviour {
	public float speed;
	private Renderer rend;

	void Start (){
		rend = GetComponent<Renderer> ();
	
	}
	void FixedUpdate () {
		rend.material.mainTextureOffset = new Vector2 (0.0f, Time.time * -speed);
	}
}
