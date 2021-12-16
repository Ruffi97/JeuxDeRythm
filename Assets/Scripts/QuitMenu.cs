using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Hub");
    }
}