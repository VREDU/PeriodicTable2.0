using UnityEngine;
using System.Collections;

public class canvasManager : MonoBehaviour {
	public GameObject congrats;
	public static bool gameOver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Game Over:" + gameOver);
		if (gameOver) {
			congrats.SetActive (true);
		}
	
	}
}
