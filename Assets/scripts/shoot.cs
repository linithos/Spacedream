using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public GameObject bulletPrefab;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left"))
        {

            var bullet = (GameObject)Instantiate(bulletPrefab);
        }
}


}