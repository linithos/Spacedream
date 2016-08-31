using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject spawner;

    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Jump"))
        {

            var bullet = (GameObject)Instantiate(bulletPrefab,spawner.transform.position, spawner.transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(500, 0));
        }

        
}


    
}