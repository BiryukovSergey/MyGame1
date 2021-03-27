using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextMission : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Image _img;

    private void Awake()
    {
        _img.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        _img.gameObject.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            _img.gameObject.SetActive(false);
    }

}
