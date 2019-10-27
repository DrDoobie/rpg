using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health, stamina, mana;
    [HideInInspector] public float maxHealth = 100.0f, maxStamina = 100.0f, maxMana = 10.0f;

    private void Start () {
        health = GameController.instance.health;
        stamina = GameController.instance.stamina;
        mana = GameController.instance.mana;
    }
}
