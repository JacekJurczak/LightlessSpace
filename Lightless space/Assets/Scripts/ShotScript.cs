using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour
{
	public float speed = 10;
	private Rigidbody rb;

	void Start (){
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate (){
		rb.velocity = (transform.forward * speed) * Time.deltaTime;
	}

	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "Boundary" || collision.gameObject.tag == "Asteroid") {
			Destroy (gameObject);
		}
	}
}