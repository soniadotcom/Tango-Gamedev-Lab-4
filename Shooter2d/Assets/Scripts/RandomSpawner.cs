using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject[] coldObject;

    int random;

    int generatorTimer = 10;

    int destroyTime = 5;

    GameObject potion;

    void Start()
    {
        StartGenerator();
    }


    private IEnumerator PosionGenerator()
    {
        while (true)
        {
            if(Random.Range(0, 4) == 1)
            {
                random = Random.Range(0, coldObject.Length);
                potion = Instantiate(coldObject[random], transform.position, Quaternion.identity);
                Debug.Log("random " + random);
            }
            Destroy(potion, destroyTime);
            yield return new WaitForSeconds(generatorTimer);
        }
    }

    public void StartGenerator()
    {
        StartCoroutine(PosionGenerator());
    }

    public void StopGenerator()
    {
        StopAllCoroutines();
    }
}
