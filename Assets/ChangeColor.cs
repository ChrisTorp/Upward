using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public Color color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer> ().color = color;
	}
}
