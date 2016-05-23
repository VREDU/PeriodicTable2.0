using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	public int atomicNumber;
	private int fireSpeed;
	private float step; //step = speed * Time.deltaTime
	public bool fired; //flag if atom should move where user is looking
	public bool compound, shooter; //compound is to see if hydrogen is attached to another hydrogen, shooter atoms are shot by user
	private Vector3 hitPoint; //hitPoint is where the user is looking at

	void Start () {
		fired = false;
		step = speed * Time.deltaTime;
		fireSpeed = 10;
	}

	void Update () {

		if (fired == false) {
			if (GameObject.FindWithTag ("gazeObject") == null) {
				gameObject.GetComponent<Rigidbody> ().AddForce (fireSpeed * rayCastManager.direction, ForceMode.Impulse);
				fired = true;
			}
			if (shooter) {
				transform.position = Vector3.MoveTowards (transform.position, rayCastManager.hitPoint + rayCastManager.direction, step);
			}
		}
	}
		
	public void OnCollisionEnter(Collision c) {
		//if it is another hydrogen atom that it is not a compound connect the atoms and add a random force
		if (c.rigidbody != null && atomicNumber==1 && c.gameObject.GetComponent<atomManager>().getAtomicNumber()==1 && !compound && !c.gameObject.GetComponent<atomManager>().isCompound()) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			compound = true;
			c.gameObject.GetComponent<atomManager> ().setCompound (true);
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);
			//if it was shot it will increase the molecules the user made
			if (shooter) {
				canvasManager.score++;
			}
			shooter = false;
			c.gameObject.GetComponent<atomManager> ().setShooter (false);
		}
	}

	//Getters and Setters

	public bool isCompound() {
		return compound;
	}

	public void setCompound(bool isCompound) {
		compound = isCompound;
	}

	public void setShooter(bool isShooter) {
		shooter = isShooter;
	}
		
	public int getAtomicNumber() {
		return atomicNumber;
	}
}
