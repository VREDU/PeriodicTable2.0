using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {

	public bool background, diatomic;
	public int atomicNumber;
	private bool compound;
	private int x, y;
	private Vector3 force;

	void Start () {
		compound = false;
		int x = -3;
		int y = 3;

		if (background) {
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range (x,y) ,Random.Range (x,y),Random.Range (x,y), ForceMode.Impulse);
			gameObject.GetComponent<Rigidbody> ().AddTorque (Random.Range (x,y),Random.Range (x,y),Random.Range (x,y));
		}
	}
		

	public bool isCompound() {
		return compound;
	}

	public bool isDiatomic() {
		return diatomic;
	}

	public int getAtomicNumber() {
		return atomicNumber;
	}

	public void setCompound(bool isCompound) {
		compound = isCompound;
	}
}
