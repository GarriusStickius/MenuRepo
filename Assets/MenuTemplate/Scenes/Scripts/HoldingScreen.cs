using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;
public class HoldingScreen : MonoBehaviour
{

    public InputActionReference anykey;

    void Update ()
    {
       if (Input.anyKey)
        {
            SceneManager.LoadScene(2);
        }


       
    }
        

}
