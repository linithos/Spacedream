using UnityEngine;
using System.Collections;

public class Enemigos : MonoBehaviour
{
    public GameObject enemy;
    public float maxPos = 4.33f;
    public float minPos;
    float timer;
    public float delayTimer = 0f;
    public float velocity = 1f;

    // Use this for initialization
    void Start()
    {
        timer = delayTimer;

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 enemyPos = new Vector3(transform.position.x, Random.Range(-3.38f, 4.68f), transform.position.z);

            Instantiate(enemy, enemyPos, transform.rotation);
            timer = delayTimer;
          
        }
      

    }
}
