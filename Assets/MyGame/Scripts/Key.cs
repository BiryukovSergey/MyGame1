using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Key : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Image _img;
    [SerializeField] private GameObject _keys;
    [SerializeField] private Transform _pos;
    private AudioSource _keepKey;

    
    private void Awake()
    {
        _img.gameObject.SetActive(false);
        _keepKey = GetComponent<AudioSource>();
        _keepKey.playOnAwake = false;
        _keepKey.volume = 0.1f;

    }

   private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _img.gameObject.SetActive(true);
            if (Input.GetKey((KeyCode.E)))
            {
                _keepKey.Play();
                Destroy(_keys);
            } 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _img.gameObject.SetActive(false);
        }
        
    }
}
