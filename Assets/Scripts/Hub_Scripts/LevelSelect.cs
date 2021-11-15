using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Hub_Scripts
{
    public class LevelSelect : MonoBehaviour
    {
        public Button levelButton2, levelButton3;
        private int _levelPassed;


        private void Start()
        {
            _levelPassed = PlayerPrefs.GetInt("LevelPassed");
            levelButton2.interactable = false;
            levelButton3.interactable = false;

            switch (_levelPassed)
            {
                case 1:
                    levelButton2.interactable = true;
                    break;
                case 2:
                    levelButton3.interactable = true;
                    break;
            }
        }

        public void SelectLevel(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }

        public void ResetPlayerPrefs()
        {
            levelButton2.interactable = false;
            levelButton3.interactable = false; 
            PlayerPrefs.DeleteAll();
        }
    }
}