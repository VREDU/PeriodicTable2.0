using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public int atomicNumber;
	public string elementName;
	public Text elementText;
	public GameObject atomPrefab;
	private Transform element;
	public static bool atomSelected;
	private Vector3 offset;

	void Start () {
		element = GetComponent<Transform> ();
		atomSelected = false;
		offset = new Vector3 (0, 0, -1);
		elementText.text = "";
	}
		
	void Update () {
		/*if (atomSelected == true) {
			elementText.text = elementName;
		}*/
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.white;
		elementText.text = gazedAt ? elementName : "";
	}

	public void selectElement() {
		if (atomSelected == false) {
			Instantiate (atomPrefab, element.position + offset, element.rotation);
			GameObject.FindGameObjectWithTag("craftingZone").GetComponent<craftingManager>().createGazePlane();
			atomSelected = true;
			atomPrefab.GetComponent<atomManager>().moveMode(true);
		}
	}
}
