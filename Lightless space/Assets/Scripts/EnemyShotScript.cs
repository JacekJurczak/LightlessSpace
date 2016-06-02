using UnityEngine;
using System.Collections;

public class EnemyShotScript : MonoBehaviour
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
		if (collision.gameObject.tag == "EnemyShot" || collision.gameObject.tag == "Shot" ||
			collision.gameObject.tag == "HPBonus" || collision.gameObject.tag == "SSBonus" ||  
			collision.gameObject.tag == "FlashBonus") {
			Physics.IgnoreCollision (collision.collider, GetComponent<Collider> ());
		} else {
			Destroy (gameObject);
		}
	}
}
