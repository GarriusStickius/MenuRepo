using UnityEngine;
using UnityEngine.SceneManagement;

public class Confirm : MonoBehaviour
{
    public void GoToSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(2);
    }

}
