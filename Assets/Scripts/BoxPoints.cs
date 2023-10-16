using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//if the gem collide on the box, we increase the score
public class BoxPoints : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "SphereGemSmall" || collision.transform.name == "Hexgon" || collision.transform.name == "HardStar")
        {
  
            CalculateScore(collision.gameObject);
        }
    }

    // score based on the distance between the thrown object and the target box
    private void CalculateScore(GameObject thrownObject)
    {

        float distance = Vector3.Distance(thrownObject.transform.position, transform.position);
        int finalScore = Mathf.RoundToInt(10 / distance);

        
        KeepScore.score += finalScore;

    }
}


