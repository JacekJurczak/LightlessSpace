using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
	public Singleton singleton;
	public AsteroidsScript asteroidScript;
	public Text countedPoints;


	public void Awake ()
	{
		QualitySettings.vSyncCount = 0;  // VSync must be disabled
		Application.targetFrameRate = 60;
	}
		
	public void FixedUpdate () 
	{

		countedPoints.text = "Points  : " + Singleton.Instance.points;

	}
		
}

