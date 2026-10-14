using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Gamemanager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI text;

    public GameObject collectable;


    private int score = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //make the text say that the game started
        text.text = "Game Started";
        //set our score to 0
        score = 0;
        
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        //if the score is greater than or equal to 0, have the text say the score
        if (score >= 0)
        {
            text.text = "Score: " + score;
        }else if(score < 0)
        {
            text.text = "Game Over";
        }
        
        
    

//if the score is greater than or equal to 10, change the text color to khaki, otherwise change it to turquoise
        if(score >= 10)
        {
            text.color = Color.khaki;
        }else
        {
            text.color = Color.turquoise;
        }
        
    }
    public void Respawn()
    {
        //spawn a colllectable at a random location 
        Instantiate(collectable, new Vector2(Random.Range(-6f, 6f), Random.Range(-3f, 3f)), collectable.transform.rotation);
    }
}