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
	public static Vector3 moveTowards;

	void Start () {
		element = GetComponent<Transform> ();
		atomSelected = false;
		offset = new Vector3 (0, 0, -1);
	}
		
	void Update () {
	}
		
	public int getAtomicNumber() {
		return atomicNumber;
	}

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.white;
		elementText.text = elementName;
	}

	public void selectElement() {
		float step, speed;
		speed = 1.0f;
		step = speed * Time.deltaTime;

		if (atomSelected == false) {
			Rigidbody atomInstance;
			Object craftingPlane, craftingZone;
			atomInstance = Instantiate (atomPrefab, element.position + offset, element.rotation) as Rigidbody;
			craftingPlane = Instantiate (craftingPlanePrefab, new Vector3 (0, 0, 4.8f), Quaternion.Euler (90, 0, 0));
			craftingZone = Instantiate (craftingZonePrefab, new Vector3 (0, -1.8f, 6), Quaternion.Euler (270, 0, 0));
			atomSelected = true;
			raycastTest.gazeMovement = true;
		}

		/*if(raycastTest.gazeMovement == true) {
			//Debug.Log (raycastTest.hitPoint);
			transform.position = Vector3.MoveTowards (transform.position, raycastTest.hitPoint, step);
		}*/
	}
}
