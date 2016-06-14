using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class periodSelector : MonoBehaviour {
	public int levelNumber;
	public float speed;
	private float step;

	void Update() {
		if (SaveLoad.saveLoad.getCurrentLevel () >= levelNumber) {
			gameObject.SetActive (true);
		}
	}
		

	public void periodHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.black;
	}

	public void levelLoad() {
			SceneManager.LoadScene (levelNumber);
	}
}
