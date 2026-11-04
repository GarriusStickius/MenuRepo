using UnityEngine;
using UnityEngine.SceneManagement;

public class BackOut : MonoBehaviour
{
    public void GoToConfirm()
    {
        SceneManager.LoadScene(5);
    }

}