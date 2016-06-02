using UnityEngine;
using System.Collections;


public class AsteroidsScript : MonoBehaviour
{
	public float speed = 10;
	public float health = 100;
	private float damageTaken = 25;
	public int numberOfEnemyShots = 4;
	public Transform shotEnemy;
	public Transform asteroid;
	public Transform HpB;
	private int random;
	public Transform SSB;
	private Rigidbody rb;
	public GameController gameController;
	public Transform flashBonusPick;

	void Start (){
		rb = GetComponent<Rigidbody>();
	}


	void FixedUpdate (){
		rb.velocity = -transform.forward * speed * Time.deltaTime;

	}

	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "Shot" || collision.gameObject.tag == "EnemyShot") {
			health = health - damageTaken;
			if (health <= 0) {
				random = Random.Range (0, 20);
				Destroy (gameObject);
				Singleton.Instance.CountingPoints ();
				creatingShots ();

				if (random == 0) {
					Instantiate (HpB, asteroid.position, asteroid.rotation);
				} else if (random == 1) {
					Instantiate (SSB, asteroid.position, asteroid.rotation);
				}else if (random == 2) {
					Instantiate (flashBonusPick, asteroid.position, asteroid.rotation);
				}
			}

		} else if (collision.gameObject.tag == "Boundary") {
			Destroy (gameObject);
		}
	}

	void creatingShots (){
		for (int i = 0, rotationObject = 0; i < numberOfEnemyShots; i++) {

			Quaternion angle = Quaternion.AngleAxis (rotationObject, Vector3.up);
			Instantiate (shotEnemy, asteroid.position, angle);
			rotationObject += (360 / numberOfEnemyShots);
		}
	}
}