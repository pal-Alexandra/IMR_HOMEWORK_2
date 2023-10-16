using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTracker : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Box_02 (3)")
        {
            Debug.Log("semnalez");
        }
    }
}
