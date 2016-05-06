using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	[Header ("Add Players")]
	public addplayers[] addPlayers;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	[System.Serializable]
	public class addplayers {
		public int playerID;
	}
}
