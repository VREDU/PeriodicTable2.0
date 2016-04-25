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
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		element = GetComponent<Transform> ();
		atomSelected = false;
		offset = new Vector3 (0, 0, -1);
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
			atomInstance = Instantiate (atomPrefab, element.position + offset, element.rotation) as Rigidbody;
			atomSelected = true;
		}
	}

}
