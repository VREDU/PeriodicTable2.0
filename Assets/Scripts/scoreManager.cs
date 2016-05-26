using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

	public static int score;
	// Use this for initialization
	void Start () {
		//canvasManager.score = score;
	
	}
	

	void Update () {
		GetComponent<TextMesh>().text=score.ToString();
	}
}
