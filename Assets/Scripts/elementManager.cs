using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class elementManager : MonoBehaviour {
	public int atomicNumber;
	public string elementName;
	public Text elementText;
	public Rigidbody atomPrefab;
	public GameObject craftingPlanePrefab;
	private Transform element;
	private bool atomSelected;
	private Vector3 offset;
	public static Vector3 moveTowards;
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
		float step, speed;
		speed = 1.0f;
		step = speed * Time.deltaTime;
		if (atomSelected == false) {
			Rigidbody atomInstance;
			Object craftingPlane;
			atomInstance = Instantiate (atomPrefab, element.position + offset, element.rotation) as Rigidbody;
			craftingPlane = Instantiate (craftingPlanePrefab, new Vector3 (0, 0, 5), Quaternion.Euler (90, 0, 0));
			atomSelected = true;
		} 
		else {
			//Debug.Log (raycastTest.hitPoint);
			transform.position = Vector3.MoveTowards (transform.position, raycastTest.hitPoint, step);
		}
			
	}

}
