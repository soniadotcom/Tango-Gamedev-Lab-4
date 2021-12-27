using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPosion : MonoBehaviour
{

    private float destroyTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

}
