using UnityEngine;
using System.Collections;

public class periodManager : MonoBehaviour {

	public int levelNumber;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Renderer> ().material.color = Color.white;
		if (SaveLoad.saveLoad.getCurrentLevel() <= levelNumber) {
			GetComponent<Renderer> ().material.color = Color.white;
		}
	}
}
