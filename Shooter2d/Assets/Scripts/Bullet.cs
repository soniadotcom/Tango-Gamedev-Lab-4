using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;


    public float speed = 30f;
    public float lifetime = 0.5f;
    public float distance = 0.5f;
    public int damage = 10;
    public LayerMask whatIsSolid;


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Player>().TakeDamage(damage);
        }

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);

        Destroy(effect, 0.5f); // Знищує анімацію зіткнення через кількість секунд
        Destroy(gameObject);
    }
}
