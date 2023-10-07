using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public Rigidbody2D hazard;
    public float speed = -3f;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -8)
        {
            Destroy(gameObject);
        }
    }
    public void SpawnHazard()
    {
        Rigidbody2D HazardInstance;
        HazardInstance = Instantiate(hazard, new Vector3(Random.Range(-6, 6), 7, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        HazardInstance.name = "Hazard(Clone)";
        HazardInstance.velocity = new Vector2(0, speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Spongy")
        {
            Destroy(gameObject);
        }
    }
}
