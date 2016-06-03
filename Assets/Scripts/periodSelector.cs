using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class periodSelector : MonoBehaviour {
	public GameObject elements;
	public int levelNumber;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
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
