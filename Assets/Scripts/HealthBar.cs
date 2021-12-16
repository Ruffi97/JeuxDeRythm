using System;
using UnityEngine;
using UnityEngine.UI;

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
    } else if (healthbarInfluencer == 150f)
    {
      health += maxHealth / 10f;
      UpdateHealthBar();
    }else if (healthbarInfluencer == 100f)
    {
      health -= maxHealth / 10f;
      UpdateHealthBar();
    }
  }
}