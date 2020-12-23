using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheeseCube : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<RollingBall>().points++;
            other.GetComponent<RollingBall>().CheckThreshold();
            Destroy(gameObject);
        }
    }
}
