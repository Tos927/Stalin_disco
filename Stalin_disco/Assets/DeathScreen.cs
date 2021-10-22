using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;

    public static DeathScreen instance;

    public void OnPlayerDeath()
    {
        deathScreen.SetActive(true);
    }

    public void RetryButton()
    {
        LoadScene(SceneManager.GetActiveScene().buldIndex);
        deathScreen.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
