using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    private BigExplosion _explosion;
    [SerializeField]
    private Mine _mine;
    [SerializeField]
    private float _force;
    [SerializeField]
    private AudioSource _audioBoom;
    [SerializeField]
    private GameObject _audioSourceObject;

    private void Awake()
    {
        _audioBoom = _audioSourceObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Player"))
      {
            _audioBoom.Play();
            other.gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * -1 * _force);
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * _force * 2);
            var a = Instantiate(_mine, transform.position, transform.rotation);
            var b = Instantiate(_explosion, transform.position, transform.rotation);
            Destroy(b.gameObject, 1);
            other.gameObject.SetActive(false);
            gameObject.SetActive((false));
        }
    }
}
