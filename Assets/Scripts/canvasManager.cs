using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public static bool playing; //flag for if user is in a round
	public static float timeLeft; //timeLeft before the round is over
	public static int score , levelCount, shotsLeft; //users score and number of levels in the game
	private int compoundGoal; //the score the user needs to obtain
	Animator anim; //controls when instructions, time, score and playagain/next level

	void Start () {
		playing = false;
		timeLeft = 60f;
		shotsLeft = 2;
		score = 0;
		levelCount = 3;//this will change with SaveLoad
		compoundGoal = 1;
		anim = GetComponent<Animator> ();
	}

	void Update () {
		if (playing) {
			//timeLeft -= Time.deltaTime;
			anim.SetTrigger ("playing"); //score and timeLeft are shown to user
		}

		if (score >= compoundGoal) {
			anim.SetTrigger ("gameOver"); //nextSteps button is shown
			playing = false;
		}

		if (shotsLeft==0) {
			anim.SetTrigger ("gameOver"); //nextSteps button is Shown
			playing = false;
		}
	}
		
	public void home() {
		SceneManager.LoadScene (0);
	}

	//if won go to next level else try again
	public void nextSteps() {
		if (score >= compoundGoal) {
			SceneManager.LoadScene ((SceneManager.GetActiveScene().buildIndex+1)%3);
			SaveLoad.saveLoad.increaseCurrentLevel();
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
