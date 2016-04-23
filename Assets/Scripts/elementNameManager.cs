using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementNameManager : MonoBehaviour {
	Text elementName;

	void Start () {
		elementName = GetComponent<Text> ();
		elementName.text = "";
	}

	public void Hydrogen() {
		elementName.text = "Hydrogen";
	}

	public void Helium() {
		elementName.text = "Helium";
	}
		
}
