using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _key;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _text.gameObject.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player")&&_key == null)
        {
            if (Input.GetKey(KeyCode.E))
            {
                _text.gameObject.SetActive(true);
            }
        }
    }
}
