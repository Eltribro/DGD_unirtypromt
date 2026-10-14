using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

    //veriables
    public TextMeshProUGUI text;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the time text go up by 1 every second
        
        text.text = "Time: " + Time.deltaTime;
    }
}
