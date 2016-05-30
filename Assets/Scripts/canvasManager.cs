using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public GameObject congratsTitle, congratsBackground, scoreTitle, timeTitle, instructionsTop, instructionsBottom, tryAgain;
	public static bool playing;
	public static int score;

	void Start () {
		playing = false;
	}

	void Update () {
		Debug.Log (scoreManager.score);
		if (playing) {
			scoreTitle.SetActive (true);
			timeTitle.SetActive (true);
			instructionsTop.SetActive (false);
			instructionsBottom.SetActive (false);
		}

		if (scoreManager.score > 4) {
			congratsTitle.SetActive (true);
			congratsBackground.SetActive (true);
		}

		if (timeManager.gameOver) {
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
		if (scoreManager.score > 4) {
			SceneManager.LoadScene (2);
		} else {
			SceneManager.LoadScene (1);
		}
	}

}
