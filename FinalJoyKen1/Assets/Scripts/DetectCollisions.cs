using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{
    private bool isDead = false; 
    public GameoverManager gameManager; 
    public ParticleSystem explosionParticle; 
    public TextMeshProUGUI starText; 

    // Reference to the player's score
    public static int score = 0;

    void Start()
    {
        // Initialize the UI text
        if (starText != null)
        {
            starText.text = "StarCount: " + score.ToString();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("star"))
        {
            // Increment the score and destroy the star object
            score += 1;
            Destroy(other.gameObject);
            if (starText != null)
            {
                starText.text = "StarCount: " + score.ToString();
            }
            Debug.Log("Score: " + score);
        }
        else if (other.CompareTag("Obstacle") && !isDead)
        {
            isDead = true; // Set the death flag to true
            Destroy(gameObject); // Destroy the player object
            Destroy(other.gameObject); // Destroy the obstacle

            // Call the game over method
            if (gameManager != null)
            {
                gameManager.gameOver();
            }

            // Instantiate the explosion particle
            if (explosionParticle != null)
            {
                Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            }
        }
    }
}