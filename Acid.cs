using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid : MonoBehaviour
{
    // Start is called before the first frame update


    public Rigidbody2D acid;
    public float speed = -3f;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -8)
        {
            Destroy(gameObject);
        }
    }
    public void SpawnAcid()
    {
        Rigidbody2D grimeInstance;
        grimeInstance = Instantiate(acid, new Vector3(Random.Range(-6, 6), 7, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        grimeInstance.name = "Acid(Clone)";
        grimeInstance.velocity = new Vector2(0, speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Spongy")
        {
            Destroy(gameObject);
        }
    }
}
