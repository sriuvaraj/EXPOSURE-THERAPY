using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }
    public void switchscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
