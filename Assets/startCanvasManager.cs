using UnityEngine;
using System.Collections;

public class startCanvasManager : MonoBehaviour {
	public GameObject Period2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (SaveLoad.saveLoad.getCurrentLevel () >= 2) {
			Period2.SetActive (true);
		}

		Debug.Log (1.0f / Time.deltaTime);
	
	}
}
