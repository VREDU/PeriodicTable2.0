﻿using UnityEngine;
using System.Collections;

public class timeManager : MonoBehaviour {
	float timeLeft;
	// Use this for initialization
	void Start () {
		timeLeft = 60.0f;
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		GetComponent<TextMesh>().text=timeLeft.ToString("0");	
	}
}
