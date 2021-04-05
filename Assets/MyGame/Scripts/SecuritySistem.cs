using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecuritySistem : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Image _img;

    private void Awake()
    {
        _img.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            _img.gameObject.SetActive(true);

    }

}

    
