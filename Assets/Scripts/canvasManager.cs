using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public static bool playing; //flag for if user is in a round
	public static float timeLeft; //timeLeft before the round is over
	public static int score; //users score
	private int goal; //the score the user needs to obtain
	Animator anim; //controls when instructions, time, score and playagain/next level

	void Start () {
		score = 0;
		goal = 5;
		timeLeft = 60f;
		anim = GetComponent<Animator> ();
	}

	void Update () {
		Debug.Log (timeLeft);
		if (playing) {
			timeLeft -= Time.deltaTime;
			anim.SetTrigger ("playing"); //score and timeLeft are shown to user
		}

		if (score >= goal) {
			anim.SetTrigger ("gameOver"); 
			playing = false;
		}

		if (timeLeft<=0) {
			anim.SetTrigger ("gameOver");
			playing = false;
		}
	}

	public void playAgain() {
		SceneManager.LoadScene(0);
	}
		
	public void home() {
		SceneManager.LoadScene (0);
	}

	//if won go to next level else try again
	public void nextSteps() {
		if (score >= goal) {
			SceneManager.LoadScene (2);
		} else {
			SceneManager.LoadScene (1);
		}
	}
}
