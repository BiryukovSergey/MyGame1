using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnMine : MonoBehaviour
{
    [SerializeField]
    private GameObject _mine;
    private AudioSource _audioActiv;

    private void Start()
    {
        _audioActiv = GetComponent<AudioSource>();
        _audioActiv.playOnAwake = false;
        _audioActiv.volume = 0.1f;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
                _audioActiv.Play();
                _mine.SetActive(true);
        }

    }
   
}
