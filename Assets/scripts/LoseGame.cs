﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name=="Ball")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
