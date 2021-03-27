using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnMine : MonoBehaviour
{
    [SerializeField]
    private GameObject _mine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.E))
            {
                _mine.SetActive(true);
            }
        
    }
}
