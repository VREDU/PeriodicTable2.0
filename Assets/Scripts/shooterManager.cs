using UnityEngine;
using System.Collections;

public class shooterManager : MonoBehaviour {
	public float gazeSpeed; //speed object approaches gaze
	public int atomicNumber;
	private int fireSpeed;
	private float step; //step = speed * Time.deltaTime
	private bool fired, shooter;
	private Vector3 hitPoint; //hitPoint is where the user is looking at

	void Start () {
		fired = false; //atom should move with gaze
		step = gazeSpeed * Time.deltaTime;
		fireSpeed = 10;
		shooter = true;
	}

	void Update () {
		Debug.Log (fired);
		if (fired == false) {
			transform.position = Vector3.MoveTowards (transform.position, rayCastManager.hitPoint + rayCastManager.direction, step);

			if (GameObject.FindWithTag ("gazeObject") == null) {
				gameObject.GetComponent<Rigidbody> ().AddForce (fireSpeed * rayCastManager.direction, ForceMode.Impulse);
				fired = true;
			}
		}
	}
		
	public void OnCollisionEnter(Collision c) {
		//if it is another hydrogen atom that it is not a compound connect the atoms and add a random force
		if (c.rigidbody != null && gameObject.GetComponent<AtomManager>().isDiatomic() && c.gameObject.GetComponent<AtomManager>().isDiatomic() && !gameObject.GetComponent<AtomManager> ().isCompound() && !c.gameObject.GetComponent<AtomManager>().isCompound()) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			gameObject.GetComponent<AtomManager> ().setCompound (true);
			c.gameObject.GetComponent<AtomManager> ().setCompound (true);
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);
			//if it was shot it will increase the score
			if (shooter) {
				++canvasManager.score;
			}
			shooter = false;
		}
	}

	//Getters and Setters


	public void setShooter(bool isShooter) {
		shooter = isShooter;
	}
		
	public int getAtomicNumber() {
		return atomicNumber;
	}
}
