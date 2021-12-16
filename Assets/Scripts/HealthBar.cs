using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
  public Image healthBarImage;
  private float health = 1f;
  private float maxHealth = 1f;

  public void UpdateHealthBar() 
  {
    healthBarImage.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1f);
  }

  public float HealthBarModifier()
  {
    if ()
    {
      health = 1f;
      UpdateHealthBar();
    } else if ()
    {
      health += maxHealth * 1.10f;
      UpdateHealthBar();
    }else if ()
    {
      health -= maxHealth / 10f;
      UpdateHealthBar();
    }
  }
}