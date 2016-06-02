using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float speed = 10;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 11;
	private float nextFire;
	public float health = 100;
	public float damageByOneHit = 33.4f;
	public Transform sshot;
	public Transform sshotSpawn;
	public Transform sshotSpawn1;
	private Rigidbody rb;
	public Text healthPoints;
	public GameObject flashBonus;
	public Transform bonusSpawn;
	private bool checkForSSB;


	void Start(){
		rb = GetComponent<Rigidbody>();
		HealthPointUI ();
		checkForSSB = false;
	}

	void Update (){
		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			if (checkForSSB == true) {
				Instantiate (sshot, shotSpawn.position, shotSpawn.rotation);
			}
		}
	}

	void FixedUpdate (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 move = new Vector3 (moveHorizontal, 0.0f, 0.0f);

		rb.velocity = move * speed;
	}

	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "Asteroid") {
			Destroy (gameObject);
			SceneManager.LoadScene ("gameOver");

		} else if (collision.gameObject.tag == "EnemyShot") {
			health -= damageByOneHit;
			HealthPointUI ();

			if (health <= 0) {
				Destroy (gameObject);
				SceneManager.LoadScene ("gameOver");
			}
		}			
		if (collision.gameObject.tag == "HPBonus") {
			health += 10;
			HealthPointUI ();
		}
		if (collision.gameObject.tag == "FlashBonus") {
			Instantiate (flashBonus, bonusSpawn.position, bonusSpawn.rotation);

		}
		if (collision.gameObject.tag == "SSBonus") {
			checkForSSB = true;
		}
	}

	void HealthPointUI (){

		healthPoints.text = "Health: " + health.ToString ();

	}


}