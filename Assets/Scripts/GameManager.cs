using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Restart button
    public void RestartScene()
    {
        SceneManager.LoadScene("MainGame");
    }
}
