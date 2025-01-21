using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject m_Menu;
    [SerializeField] GameObject overMenu;

    RampManager rampLower;

    void Start()
    {
        rampLower = FindFirstObjectByType<RampManager>();
        m_Menu.SetActive(true);
        overMenu.SetActive(false);
    }

    public void StartGame()
    {
        rampLower.LowerRamp();
        m_Menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
