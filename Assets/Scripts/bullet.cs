using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float lifeTime;
    public float speed;
    public int damage;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().TakeDamage(damage);
            DestroyBullet();
        }
    }
}
