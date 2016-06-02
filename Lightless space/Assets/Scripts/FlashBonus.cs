using UnityEngine;
using System.Collections;

public class FlashBonus : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	void Start (){
		rb = GetComponent<Rigidbody> ();
	}
	void FixedUpdate (){
		rb.velocity = transform.forward * speed * Time.deltaTime;

	}

	public void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "EnemyShot" || collision.gameObject.tag == "Shot" ||
		    collision.gameObject.tag == "Asteroid" || collision.gameObject.tag == "HPBonus" || collision.gameObject.tag == "SSBonus") {
			Physics.IgnoreCollision (collision.collider, GetComponent<Collider> ());
		}
		if (collision.gameObject.tag == "Boundary") {
			Destroy (gameObject);
		}
	}

}
