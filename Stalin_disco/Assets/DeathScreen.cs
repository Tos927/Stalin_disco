<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
=======
using UnityEngine;
using UnityEngine.SceneManagement;
>>>>>>> Stashed changes

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;

<<<<<<< Updated upstream
    public static GameOverManager instance;

    public void OnPlayerDeath()
    {
        deathScreen.setActive(true);
=======
    public static DeathScreen instance;

    public void OnPlayerDeath()
    {
        deathScreen.SetActive(true);
>>>>>>> Stashed changes
    }

    public void RetryButton()
    {
<<<<<<< Updated upstream

=======
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        deathScreen.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
>>>>>>> Stashed changes
    }

}
