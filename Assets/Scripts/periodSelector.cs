using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class periodSelector : MonoBehaviour {
	public GameObject elements;
	public Transform target;
	public int levelNumber;
	public float speed;
	private float step;

	void Start() {
			SaveLoad.saveLoad.Load ();

	}
		

	public void periodHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.black;
	}

	public void levelLoad() {
			SceneManager.LoadScene (levelNumber);
	}
}
