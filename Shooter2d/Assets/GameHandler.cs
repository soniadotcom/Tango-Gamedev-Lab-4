using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public Transform healthBarPoint;
    public GameObject healthBarPrefab;

    //public Transform pfHealthBar;

    // Start is called before the first frame update
    void Start()
    {
        /*
        HealthSystem healthSystem = new HealthSystem(100);

        // Додаємо полосу здоров'я
        //Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0, 1), Quaternion.identity);
        //HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();

        GameObject healthBarTransform = Instantiate(healthBarPrefab, healthBarPoint.position, healthBarPoint.rotation);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();

        healthBarTransform.transform.parent = healthBarPoint;

        healthBar.Setup(healthSystem);
        */

        /*
        Debug.Log("Health: " + healthSystem.GetHealthPercent());

        healthSystem.Damage(10);
        healthSystem.Damage(10);
        healthSystem.Damage(10);

        healthSystem.Heal(10);

        Debug.Log("Health: " + healthSystem.GetHealthPercent());
        */
    }
}
