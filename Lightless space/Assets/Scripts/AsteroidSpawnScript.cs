using UnityEngine;
using System.Collections;

public class AsteroidSpawnScript : MonoBehaviour
{
	public GameObject asteroid;
	public Vector3 spawnAsteroid;
	private float time;
	public float dropRate;
	public float spawnRate;

	void Update (){
		if (Time.time > time) {
			time = Time.time + spawnRate;
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnAsteroid.x, spawnAsteroid.x), spawnAsteroid.y, spawnAsteroid.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (asteroid, spawnPosition, spawnRotation);
		}
	}
}


