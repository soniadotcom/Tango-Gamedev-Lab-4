using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Camera camera;

    Vector2 movement;
    Vector2 mousePosition;

    public GameObject deathEffect;
    public int health = 100;


    public Transform healthBarPoint;
    public GameObject healthBarPrefab;
    HealthSystem healthSystem;


    void Start()
    {
        healthSystem = new HealthSystem(100);

        GameObject healthBarTransform = Instantiate(healthBarPrefab, healthBarPoint.position, healthBarPoint.rotation);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();

        healthBarTransform.transform.parent = healthBarPoint;

        healthBar.Setup(healthSystem);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);

        if(healthSystem.GetHealth() <= 0)
        {
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);

            Destroy(effect, 0.5f); // Знищує анімацію зіткнення через кількість секунд

            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePosition - rb.position;

        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

    
    public void TakeDamage(int damage)
    {
        healthSystem.Damage(damage);
    }

}
