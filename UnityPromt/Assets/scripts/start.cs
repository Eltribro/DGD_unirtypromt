using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    //Variables

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
}