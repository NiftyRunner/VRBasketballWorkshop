using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject m_Menu;
    [SerializeField] GameObject overMenu;

    EasyTimer easyTimer;
    RampManager rampLower;

    void Start()
    {
        easyTimer = FindFirstObjectByType<EasyTimer>();
        rampLower = FindFirstObjectByType<RampManager>();
        m_Menu.SetActive(true);
        overMenu.SetActive(false);
    }

    public void StartGame()
    {
        easyTimer.StartTimer(easyTimer.totalTime);
        rampLower.LowerRamp();
        m_Menu.SetActive(false);
    }

    public void GameOver()
    {
        m_Menu.SetActive(false);
        overMenu.SetActive(true);
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
