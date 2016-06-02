using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour {


	public Button play;
	public Button options;
	public Button credits;



	public void OnPlay () {
		SceneManager.LoadScene ("mainGame");

	}

	public void OnCredits () {

		SceneManager.LoadScene ("credits");
	}

}