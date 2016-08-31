using UnityEngine;
using System.Collections;

public class MissileController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void StartMoving()
	{
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-40, 0));
		Debug.Log ("Moving");

	}
}
