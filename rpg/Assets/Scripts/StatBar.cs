using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBar : MonoBehaviour
{
    public bool health, stamina, mana;
    public Text text;
    private PlayerStats playerStats;
    private Slider slider;

    private void Start () {
        playerStats = FindObjectOfType<PlayerStats>();
        slider = GetComponent<Slider>();
    }

    private void Update () {
        StatController();
    }

    private void StatController () {
        if(health)
        {
            slider.value = playerStats.health;
            slider.maxValue = playerStats.maxHealth;

            text.text = playerStats.health.ToString("0") + "/" + slider.maxValue;

            return;
        }

        if(stamina)
        {
            slider.value = playerStats.stamina;
            slider.maxValue = playerStats.maxStamina;

            text.text = playerStats.stamina.ToString("0") + "/" + slider.maxValue;

            return;
        }

        if(mana)
        {
            slider.value = playerStats.mana;
            slider.maxValue = playerStats.maxMana;

            text.text = playerStats.mana.ToString("0") + "/" + slider.maxValue;
        }
    }
}
