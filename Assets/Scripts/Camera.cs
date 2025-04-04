using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject followPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer != null)
        {
            transform.position = followPlayer.transform.position; 
        }
    }
}
