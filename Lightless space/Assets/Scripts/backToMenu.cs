using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour {

	public void backToMenuOnClick () {

		SceneManager.LoadScene ("startMenu");
	}


	public void restart () {
	
		SceneManager.LoadScene ("mainGame");
	}
}

