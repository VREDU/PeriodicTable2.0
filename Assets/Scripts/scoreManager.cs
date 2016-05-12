using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

	public Text score;
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		score.text = canvasManager.score.ToString ();
	}
}
