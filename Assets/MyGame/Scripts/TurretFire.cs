using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretFire : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Instantiate(_fire, transform.position, Quaternion.identity);
            Debug.Log("Player died");
            //_fire.SetActive(false);
        }
    }
}
