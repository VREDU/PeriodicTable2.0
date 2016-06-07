using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class periodSelector : MonoBehaviour {
	public GameObject elements;
	public int levelNumber;

	void Start() {
			Debug.Log ("periodSelector:SaveLoad.load()");
			SaveLoad.saveLoad.Load ();
	}

	public void period1Hover(bool gazedAt) {
		if (SaveLoad.saveLoad.getCurrentLevel () >= levelNumber) {
			elements.SetActive (gazedAt);
		}
	}

	public void levelLoad() {
		if (SaveLoad.saveLoad.getCurrentLevel () >= levelNumber) {
			SceneManager.LoadScene (levelNumber);
		}
	}
}
