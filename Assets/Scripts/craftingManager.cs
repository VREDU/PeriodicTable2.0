using UnityEngine;
using System.Collections;

public class craftingManager : MonoBehaviour {
	private Collider atom;
	private bool enter, compound; //enter is true if atom is in crafting zone, compound is true if a stable compound is in crafting zone
	public float speed; //speed at which atom approaches landingPoint
	private float step;
	public GameObject landingPoint; //point in crafting zone atom moves towards

	void Start () {

	}

	//
	void Update () {
		step = speed * Time.deltaTime;
		if (enter == true) {
			compound = atom.GetComponent<atomManager> ().isCompound ();

			if (compound == false) {//this needs to change
				atom.transform.position = Vector3.MoveTowards (atom.transform.position, landingPoint.transform.position, step);
			}
		}
	}

	void OnTriggerEnter (Collider other) {
		atom = other;
		atom.GetComponent<atomManagerOld> ().moveMode (false);
		atom.GetComponent<atomManagerOld> ().changeStable (true);
		Destroy(GameObject.FindGameObjectWithTag ("gazePlane"));
		enter = true;
	}
}
