using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public GameObject congrats;
	public static bool gameOver;
	public static int score;

	void Start () {
		//score = 0;
	}

	void Update () {
		Debug.Log (score);
		/*if (score>2) {
			congrats.SetActive (true);
			score = 0;
		}*/
	}

	public void playAgain() {
		SceneManager.LoadScene(0);
	}

	public void startGame() {
		score = 0;
	}
}
