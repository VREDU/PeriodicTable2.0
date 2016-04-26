using UnityEngine;
using System.Collections;

public class atomManager : MonoBehaviour {
	public float step, speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		speed = 1.0f;
		step = speed * Time.deltaTime;

			Debug.Log (raycastTest.hitPoint);
			transform.position = Vector3.MoveTowards (transform.position, raycastTest.hitPoint, step);
		}
	}
