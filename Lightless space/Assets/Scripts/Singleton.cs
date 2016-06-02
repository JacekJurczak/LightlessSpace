using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{
	private static Singleton instance;
	public static GameObject singleton;
	public static Singleton Instance {
		get {
			
			if (instance == null) {
				GameObject singleton = new GameObject ("singleton");
				singleton.AddComponent<Singleton> ();
			} 
			return instance;
		}
	}

	public int points { get; set;}

	void Awake ()
	{
		instance = this;
		points = 0;
	}

	public void CountingPoints ()
	{
		points = points + 3;

	}
}
