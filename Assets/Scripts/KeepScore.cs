using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if(score > 0)
        {
            GUI.Box(new Rect(100, 100, 100, 100), "Score: " + score.ToString());

        }
        //GUI.Box(new Rect(100, 100, 100, 100), "Score: " + score.ToString());  
    }
}
