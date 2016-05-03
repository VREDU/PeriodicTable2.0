using UnityEngine;
using System.Collections;

public class craftingManager2 : MonoBehaviour {
	private Collider atom;
	private bool enter, test1;
	public float speed;
	private float step;
	public GameObject landingPoint, landingPoint2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		step = speed * Time.deltaTime;
		if (enter == true && test1 == false) {
			atom.transform.position = Vector3.MoveTowards (atom.transform.position, landingPoint.transform.position, step);
			test1 = atom.GetComponent<atomManager> ().getTest1 ();
		}

		if (test1 == true) {
			Debug.Log ("test1safsa");
			atom.transform.position = Vector3.MoveTowards (atom.transform.position, landingPoint2.transform.position, step);

		}
	
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log ("Collision");
		atom = other;
		atom.GetComponent<atomManager> ().moveMode (false);
		enter = true;
		atom.GetComponent<atomManager> ().changeStable (true);
		Destroy(GameObject.FindGameObjectWithTag ("craftingPlane"));

	}
}
