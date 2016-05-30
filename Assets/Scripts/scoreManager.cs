using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	

	void Update () {
		GetComponent<TextMesh>().text=canvasManager.score.ToString();
	}
}
