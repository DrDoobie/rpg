using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health, stamina, mana;
    [HideInInspector] public float maxHealth = 100.0f, maxStamina = 100.0f, maxMana = 10.0f;
}
