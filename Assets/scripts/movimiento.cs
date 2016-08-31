using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

    public int force;


    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {

        force = 10;
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("up"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force));
           
}
    
         if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1*force));

        }

        if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-1 * force, 0));

        }

        if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0));

        }

    }

}