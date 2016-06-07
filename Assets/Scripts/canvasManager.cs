using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour {
	public static bool playing; //flag for if user is in a round
	public static float timeLeft; //timeLeft before the round is over
	public static int compoundsFormed, levelCount, shotsLeft; //users score and number of levels in the game
	public int compoundGoal, initialShots;
	Animator anim; //controls when instructions, time, score and playagain/next level

	void Start () {
		playing = false;
		shotsLeft = initialShots;
		timeLeft = 60f;
		compoundsFormed = 0;
		levelCount = 3;//this will change with SaveLoad
		anim = GetComponent<Animator> ();
	}

	void Update () {
		Debug.Log (compoundsFormed);

		if (playing) {
			anim.SetTrigger ("playing"); //score and timeLeft are shown to user
		}

		if (compoundsFormed >= compoundGoal) {
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
		if (compoundsFormed >= compoundGoal) {
			SceneManager.LoadScene ((SceneManager.GetActiveScene().buildIndex+1)%3);
			if (SaveLoad.saveLoad.getCurrentLevel () <= SceneManager.GetActiveScene ().buildIndex) {
				SaveLoad.saveLoad.increaseCurrentLevel ();
				SaveLoad.saveLoad.Save ();
			}
		} else {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}

	public int getCompoundGoal() {
		return compoundGoal;
	}
}
