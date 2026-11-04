using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void GoToSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(1);
    }

}
