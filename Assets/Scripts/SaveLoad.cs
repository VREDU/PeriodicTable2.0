using UnityEngine;
using System.Collections;

public  class SaveLoad:MonoBehaviour {

	public static SaveLoad saveLoad;
	public int currentLevel;

	void Awake() {
		if (saveLoad == null) {
			DontDestroyOnLoad (gameObject);
			saveLoad = this;
		} else if (saveLoad != this){
			Destroy (gameObject);
		}
	}
}
