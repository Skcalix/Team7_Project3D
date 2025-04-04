using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; //inspector visible float for player
    bool isWalking; // bool to see if the players moving

    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>(); //calls the animator to use animations on code
        isWalking = false; //at the games start the player isnt walking until input is given
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // left right arrow key and AD key input
        float verticalInput = Input.GetAxis("Vertical"); // up down arrow and WS key input

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput); // the players horzontal and vertical movement is equal to players input
        transform.Translate(movement * speed * Time.deltaTime); // ensures game moves at fps allowed by players setting

        if (horizontalInput != 0 || verticalInput != 0) //if vertical or horizontal movement is more than 0
        {
            isWalking = true;
            animator.Play("Walk");
        }
        else
        {
            isWalking = false;
            animator.Play("IdlePlayer"); 
        }
    }



}
