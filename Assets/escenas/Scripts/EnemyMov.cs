using UnityEngine;
using System.Collections;

public class EnemyMov : MonoBehaviour {
    public GameObject enemy;
    float timeMissile = 0.5f;
    public GameObject missile;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        enemy.transform.Translate(new Vector3( -3*Time.deltaTime,0, 0));


        if (timeMissile < 0)
        {
            var newMissile = (GameObject)Instantiate(missile, transform.position, transform.rotation);

            newMissile.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400, 0));
            timeMissile = 0.5f;
          
        }
        else
        {
            timeMissile -= Time.deltaTime;
        }
    }
}
