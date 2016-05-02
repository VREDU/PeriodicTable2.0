using UnityEngine;
using System.Collections;

public class craftingManager : MonoBehaviour {
	public float speed;
	private bool enter;
	private float step;
	public GameObject craftingPlanePrefab, landingPoint;
	private Collider atom;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		step = speed * Time.deltaTime;
		if (enter == true) {
			atom.transform.position = Vector3.MoveTowards (atom.transform.position, landingPoint.transform.position, step);
		}
	
	}

	public void createGazePlane() {
		Instantiate (craftingPlanePrefab, new Vector3 (-1, 0, 5), Quaternion.Euler (90, 0, 0));
	}

	void OnTriggerEnter (Collider other) {
		other.GetComponent<atomManager> ().moveMode (false);
		//elementManager.atomSelected = false;
		Destroy(GameObject.FindGameObjectWithTag ("craftingPlane"));
		atom = other;
		enter = true;
	}
}
