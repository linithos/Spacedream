using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour 
{
	bool startMoving = false;
	float lerpPosition = 0.0f;
	float lerpTime  = 2.5f; // This is the number of seconds the Lerp will take
	Vector3 start;
	Vector3 end;
	public int life;

	float timeLeft = 5.0f;
	bool startShoot = false;

	public GameObject missile;

	// Use this for initialization
	void Start () 
	{
		startMoving = true;
		start = transform.position;
		end = new Vector3 (transform.position.x - 10.0f, transform.position.y, transform.position.z);
	}

	// Update is called once per frame
	void Update () 
	{
		if (startMoving) 
		{
			lerpPosition += Time.deltaTime/lerpTime;
			transform.position = Vector3.Lerp(start,end,lerpPosition);
		}

		if (lerpPosition >= 0.5f)
		{
			startMoving = false;
			startShoot = true;
		}
			
		if (startShoot) 
		{
			
			Instantiate (missile, transform.position, transform.rotation);
			missile.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-40, 0));
			timeLeft = -Time.deltaTime;
		}

		if (timeLeft < 0)
			startShoot = false;


	}
}
