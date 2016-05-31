using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public GameObject congratsBackground, scoreTitle, timeTitle, instructionsTop, instructionsBottom, tryAgain;
	public static bool gameStart;
	public static int score;
	public static float timeLeft;

	Animator anim;

	void Start () {
		timeLeft = 60f;
		anim = GetComponent<Animator> ();
	}

	void Update () {
		Debug.Log (timeLeft);
		if (gameStart) {
			timeLeft -= Time.deltaTime;
			anim.SetTrigger ("playing");
		}

		if (score > 4) {
			anim.SetTrigger ("gameOver");
		}

		if (timeLeft<=0) {
			anim.SetTrigger ("gameOver");
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
			SceneManager.LoadScene (1);
			gameStart = false;
		}
	}
}
