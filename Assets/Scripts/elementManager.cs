using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public int atomicNumber;
	public string elementName;
	public Text elementText;
	public Rigidbody atomPrefab;
	public GameObject craftingPlanePrefab, craftingZonePrefab;
	private Transform element;
	private bool atomSelected;
	private Vector3 offset;

	void Start () {
		element = GetComponent<Transform> ();
		atomSelected = false;
		offset = new Vector3 (0, 0, -1);
	}
		
	void Update () {
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.white;
		elementText.text = elementName;
	}

	public void selectElement() {
		if (atomSelected == false) {
			Instantiate (atomPrefab, element.position + offset, element.rotation);
			Instantiate (craftingPlanePrefab, new Vector3 (0, 0, 4.8f), Quaternion.Euler (90, 0, 0));
			Instantiate (craftingZonePrefab, new Vector3 (0, -1.8f, 6), Quaternion.Euler (270, 0, 0));

			atomSelected = true;
			gazeMovementManager.gazeMovement = true;
		}
	}
}
