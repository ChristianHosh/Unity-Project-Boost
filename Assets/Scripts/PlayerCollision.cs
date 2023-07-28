using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Finish":
                Debug.Log("You Finished The Level!");
                break;
            
            case "Respawn":
                Debug.Log("You Started The Level");
                break;
            
            case "Friendly":
                Debug.Log("This is a friendly");
                break;
            
            case "Fuel":
                Debug.Log("You picked up fuel");
                break;
            
            default:
                Debug.Log("You Blew Up!");
                ReloadLevel();
                break;
        }

    }

    private void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
