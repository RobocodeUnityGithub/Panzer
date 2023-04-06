using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankSetting : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamaga(float value)
    {
        currentHealth -= value;
        if(currentHealth <= 0)
        {
            Debug.Log("Tank Destroy");
        }
    }
    public void Repair(float value)
    {
        currentHealth += value;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
