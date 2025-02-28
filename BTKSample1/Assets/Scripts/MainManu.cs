using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp("escape"))
        {
            AppMenu();
        }
    }
    public void PlayApp()
    {
        SceneManager.LoadScene("Level1");
    }
    public void AppQuit()
    {
        Application.Quit();
        Debug.Log("Çýkýþ Yapýldý");
         
    }

    public void AppMenu()
    {
        SceneManager.LoadScene(0);
    }
}
