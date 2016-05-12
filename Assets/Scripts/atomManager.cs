using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	public int atomicNumber;
	private int fireSpeed;
	private float step; //step = speed * Time.deltaTime
	private bool fired; //flag if atom should move where user is looking
	public bool compound, shooter; //compound is to see if hydrogen is attached to another hydrogen, shooter atoms are shot by user
	private Vector3 hitPoint; //hitPoint is where the user is looking at

	void Start () {
		fired = false;
		step = speed * Time.deltaTime;
		fireSpeed = 18;
	}

	void Update () {
		if (shooter) {
			transform.position = Vector3.MoveTowards (transform.position, rayCastManager.hitPoint + rayCastManager.direction*2, step);
		}
		if (GameObject.FindWithTag ("gazePlane") == null && fired == false) {
				gameObject.GetComponent<Rigidbody> ().AddForce (fireSpeed*rayCastManager.direction, ForceMode.Impulse);
				fired = true;
		}
	}
		
	public void OnCollisionEnter(Collision c) {
		if (c.rigidbody != null && atomicNumber==1 && c.gameObject.GetComponent<atomManager>().getAtomicNumber()==1 && !compound && !c.gameObject.GetComponent<atomManager>().isCompound()) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			compound = true;
			c.gameObject.GetComponent<atomManager> ().setCompound (true);
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);

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

	public bool isShooter() {
		return shooter;
	}

	public void setShooter(bool isShooter) {
		shooter = isShooter;
	}

	public int getAtomicNumber() {
		return atomicNumber;
	}
}
