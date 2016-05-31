using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class periodSelector : MonoBehaviour {
	public GameObject p1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void period1Hover(bool gazedAt) {
		p1.SetActive (gazedAt);
	}

	public void period1Select() {
		SceneManager.LoadScene(1);
	}
}
