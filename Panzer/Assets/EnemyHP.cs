using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
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
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
