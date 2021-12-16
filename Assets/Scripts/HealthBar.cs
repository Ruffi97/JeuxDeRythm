using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
  public Image getHealthBar;
  public static Image healthBarImage;
  private static float health = 1f;
  private static float maxHealth = 1f;

  private void Start()
  {
    healthBarImage = getHealthBar;
  }

  public static void UpdateHealthBar() 
  {
    healthBarImage.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1f);
  }

  public static void HealthBarModifier(float healthbarInfluencer)
  {
    if (healthbarInfluencer == 300f)
    {
      health = 1f;
      UpdateHealthBar();
    } 
    else if (healthbarInfluencer == 150f)
    {
      health += 0.1f;
      UpdateHealthBar();
    }
    else if (healthbarInfluencer == 100f)
    {
      health -= 0.1f;
      UpdateHealthBar();
    }
    if(health <= 0)
        {
            PlayerPrefs.SetFloat("_score", GameManager._score);
            SceneManager.LoadScene("Defeat");
            HealthBarModifier(300f);
        }
  }
}