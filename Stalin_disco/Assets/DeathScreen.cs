using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public GameObject deathScreen;

    public static GameOverManager instance;

    public void OnPlayerDeath()
    {
        deathScreen.setActive(true);
    }

    public void RetryButton()
    {

    }

}
