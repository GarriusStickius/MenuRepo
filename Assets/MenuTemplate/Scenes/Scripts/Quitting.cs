using UnityEngine;
using UnityEngine.SceneManagement;

public class Quitting : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(2);
    }

}
