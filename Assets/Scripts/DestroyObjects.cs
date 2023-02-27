using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    private int topRange = 30;
    private int bottomRange = -10; 
    void Update()
    {
        if (transform.position.z > topRange || transform.position.z < bottomRange)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }

}
