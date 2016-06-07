using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {
	
	void Update () {
		GetComponent<TextMesh>().text= "Homonuclear diatomic \n molecules formed:" + canvasManager.compoundsFormed.ToString();
	}
}
