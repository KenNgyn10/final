using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //declare explosion variable
    public ParticleSystem explosionParticle;

    // Reference to the player's score
    public static int score = 0;

    public TextMeshProUGUI starText;

    void Start()
    {
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("star"))
        {
            // Increment the score and destroy the star object
            score += 1;
            Destroy(other.gameObject);
            starText.text = "StarCount:" + score.ToString();
            Debug.Log("Score: " + score);
            
        }
       
        else if (other.gameObject.CompareTag("Obstacle"))
        {
           
            Destroy(gameObject);
            Destroy(other.gameObject);

            //instantiate the explosion
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

           
        }
    }
}
