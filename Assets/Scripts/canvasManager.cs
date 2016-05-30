using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public GameObject congratsBackground, scoreTitle, timeTitle, instructionsTop, instructionsBottom, tryAgain;
	public static bool gameStart;
	public static int score;
	public static float timeLeft;

	void Start () {
		timeLeft = 60f;
	}

	void Update () {
		Debug.Log (timeLeft);
		if (gameStart) {
			timeLeft -= Time.deltaTime;
			scoreTitle.SetActive (true);
			timeTitle.SetActive (true);
			instructionsTop.SetActive (false);
			instructionsBottom.SetActive (false);
		}

		if (score > 4) {
			congratsBackground.SetActive (true);
			scoreTitle.SetActive (false);
			timeTitle.SetActive (false);
		}

		if (timeManager.gameOver) {
			scoreTitle.SetActive (false);
			timeTitle.SetActive (false);
			congratsBackground.SetActive (true);
			tryAgain.SetActive (true);
		}
	}

	public void playAgain() {
		SceneManager.LoadScene(0);
	}

	public void startGame() {
		score = 0;
	}

	public void home() {
		SceneManager.LoadScene (0);
	}

	public void nextSteps() {
		if (score > 4) {
			SceneManager.LoadScene (2);
		} else {
			standardSettings ();
			SceneManager.LoadScene (1);
			gameStart = false;
		}
	}

	public void standardSettings() {
		instructionsTop.SetActive (true);
		instructionsBottom.SetActive (true);
		tryAgain.SetActive (false);
		timeManager.gameOver = false;
		score = 0;
	}

}
