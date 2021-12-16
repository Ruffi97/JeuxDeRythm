using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwapScenes : MonoBehaviour
{
    public string scene;
    
    public void LoadTheScene()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(scene);
    }
}
