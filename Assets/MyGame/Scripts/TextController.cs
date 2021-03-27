using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Image _img;

    private void Awake()
    {
        _img.gameObject.SetActive(true);
    }

    private void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D)
            || Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.Space))
        {
            _img.gameObject.SetActive(false);
        }
    }
}
