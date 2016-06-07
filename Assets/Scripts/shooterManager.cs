using UnityEngine;
using System.Collections;

public class shooterManager : MonoBehaviour {
	public float gazeSpeed; //speed object approaches gaze
	private int fireSpeed;
	private float step; //step = speed * Time.deltaTime
	private bool fired, shooter;
	private Vector3 hitPoint; //hitPoint is where the user is looking at
	private elementManager parentElementManager;

	void Start () {
		fired = false; //atom should move with gaze
		step = gazeSpeed * Time.deltaTime;
		fireSpeed = 10;
		shooter = true;
		parentElementManager = transform.parent.GetComponent<elementManager> ();
	}

	void Update () {
		Debug.Log (shooter);
		if (fired == false) {
			transform.position = Vector3.MoveTowards (transform.position, rayCastManager.hitPoint + rayCastManager.direction, step);

			if (GameObject.FindWithTag ("gazeObject") == null) {
				gameObject.GetComponent<Rigidbody> ().AddForce (fireSpeed * rayCastManager.direction, ForceMode.Impulse);
				fired = true;
			}
		}
	}
		
	public void OnCollisionEnter(Collision c) {

		if (gameObject.tag == "shooter") {
			canvasManager.shotsLeft--;
			gameObject.GetComponent<shooterManager> ().setShooter (false);
			gameObject.tag = "Untagged";
		}

		//if it is another hydrogen atom that it is not a compound connect the atoms and add a random force
		if (c.rigidbody != null && gameObject.GetComponent<atomManager>().isDiatomic() && c.gameObject.GetComponent<atomManager>().isDiatomic() && !gameObject.GetComponent<atomManager> ().isCompound() && !c.gameObject.GetComponent<atomManager>().isCompound() && gameObject.GetComponent<atomManager>().getAtomicNumber()== c.gameObject.GetComponent<atomManager>().getAtomicNumber()) {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
			gameObject.GetComponent<atomManager> ().setCompound (true);
			c.gameObject.GetComponent<atomManager> ().setCompound (true);
			gameObject.GetComponent<Rigidbody> ().AddForce (Random.Range(-5,5), Random.Range(-5,5), Random.Range(-5,5), ForceMode.Impulse);
			//if it was shot it will increase the score
			if (shooter) {
				++canvasManager.compoundsFormed;
				parentElementManager.incrementCompounds ();
			}
			shooter = false;
		}
	}

	//Getters and Setters


	public void setShooter(bool isShooter) {
		shooter = isShooter;
	}
}
