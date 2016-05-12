using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float speed; //speed object approaches gaze
	public int atomicNumber;
	private float step;
	private bool moveControl;
	public bool stable, compound, shooter;
	private Vector3 hitPoint, offset;

	void Start () {
		moveControl = true;
		step = speed * Time.deltaTime;
		offset = new Vector3 (0, 0, 1);
	}

	void Update () {
		if (moveControl == true && shooter) {
			transform.position = Vector3.MoveTowards (transform.position, rayCastManager.hitPoint + offset, step);
		}
		if (stable == false && moveControl == false) {
			Destroy (gameObject);
		}
		if (GameObject.FindWithTag ("gazePlane") == null) {
			if (moveControl == true) {
				//gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), 10, ForceMode.Impulse);
				gameObject.GetComponent<Rigidbody> ().AddForce (10*rayCastManager.direction, ForceMode.Impulse);
				moveControl = false;
			}
		}
	}
			

	public void changeStable(bool isStable) {
		stable = isStable;
	}

	public void moveMode(bool enabled) {
		moveControl = enabled;
	}
		
	public void OnCollisionEnter(Collision c) {
		if (c.rigidbody != null && atomicNumber==1 && c.gameObject.GetComponent<atomManager>().getAtomicNumber()==1 && !compound && !c.gameObject.GetComponent<atomManager>().isCompound()) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			moveControl = false;
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

	public bool isCompound() {
		return compound;
	}

	public void setCompound(bool isCompound) {
		compound = isCompound;
	}

	public int getAtomicNumber() {
		return atomicNumber;
	}

	public bool isShooter() {
		return shooter;
	}

	public void setShooter(bool isShooter) {
		shooter = isShooter;
	}
}
