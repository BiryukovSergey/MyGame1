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

    
    private void Awake()
    {
        _img.gameObject.SetActive(false);
        
    }

    private void Start()
    {
       // var keyDoor = Instantiate(_keys, _pos);
    }

    private void OnTriggerStay(Collider other)
    {
        _img.gameObject.SetActive(true);
        if (Input.GetKeyDown((KeyCode.E)))
        {
          Destroy(_keys);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        _img.gameObject.SetActive(false);
    }
}
