using UnityEngine;
using UnityEngine.InputSystem;

public class ArrowsMove : MonoBehaviour
{
    //variables
    public Rigidbody2D rb;

    public Gamemanager gm;

    public float forceamount = 3f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move up when up arrow is pressed 
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * forceamount);
        }

        //move down when down arrow is pressed 
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector2.down * forceamount);
        }

        //move right when right arrow is pressed 
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * forceamount);
        }

        //move left when left arrow is pressed
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * forceamount);
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //When the player/square hits any object/sprite on the game
        Debug.Log("hit");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy whatever I run into
        Destroy(collision.gameObject);
        //increase the score by 1
        gm.score += 1;
        //recreate the collectable
        gm.Respawn();
        
    }
 
}