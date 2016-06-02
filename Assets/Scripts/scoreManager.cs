using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {
	
	void Update () {
		GetComponent<TextMesh>().text=canvasManager.score.ToString();
	}
}
