using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad:MonoBehaviour {

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

	public void increaseCurrentLevel() {
		++currentLevel;
	}

	public int getCurrentLevel() {
		return currentLevel;
	}

	public void Save() {
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.OpenOrCreate);

		PlayerData data = new PlayerData ();
		data.currentLevel = currentLevel;

		bf.Serialize (file, data);
		file.Close ();
	}

	public void Load() {
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat")) 
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();
			currentLevel = data.currentLevel;
		}
	}
}


[Serializable]
class PlayerData {
	public int currentLevel;
}
