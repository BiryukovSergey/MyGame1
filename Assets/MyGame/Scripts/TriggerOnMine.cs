using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnMine : MonoBehaviour
{
    [SerializeField]
    private GameObject _mine;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
                _mine.SetActive(true);
        }

    }
   
}
