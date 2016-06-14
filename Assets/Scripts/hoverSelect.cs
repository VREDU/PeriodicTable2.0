using UnityEngine;
using System.Collections;

public class hoverSelect : MonoBehaviour {


	public void nextStepsHover(bool gazedAt) {
		GetComponent<Renderer> ().material.color = gazedAt ? Color.green : Color.black;
	}
}
