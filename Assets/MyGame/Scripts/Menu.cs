
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    [SerializeField] private Image _controllersText;
    private void Awake()
    {
        _canvas.gameObject.SetActive(false);
    }
    public void MenuButton()
    {
        _canvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        _canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Controllers()
    {
        _controllersText.gameObject.SetActive(true);
        _canvas.gameObject.SetActive(false);
        if (Input.GetKey(KeyCode.W))
            _controllersText.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
