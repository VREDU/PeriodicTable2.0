using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public int atomicNumber;
	public string elementName;
	public Text elementText;
	public Rigidbody atomPrefab;
	private Transform element;
	public bool atomSelected;
	// Use this for initialization
	void Start () {
		element = GetComponent<Transform> ();
		atomSelected = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public int getAtomicNumber() {
		return atomicNumber;
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.white;
		elementText.text = elementName;
	}

	public void selectElement(){
		if (atomSelected == false) {
			Rigidbody atomInstance;
			atomInstance = Instantiate (atomPrefab, element.position, element.rotation) as Rigidbody;
			atomSelected = true;
		}
	}

}
