using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public GameObject bullet;
    public float spawnTimer = 0f;
    public float spawnInterval = 1f;
    public GameObject thisTower;

   /* public float lifeTime = 5f;
    public float timer = 0f;
    public float speed = 10f;
    public float bulletForce = 10f;*/

   // Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       // rb = bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            //rb.AddForce(Vector3.back * bulletForce);
            spawnTimer = 0f;

        }

       /* bullet.transform.position += new Vector3( 0, 0, 0) * speed;
        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            Destroy(bullet);
        }*/
    }
}
