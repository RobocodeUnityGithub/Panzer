using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    [SerializeField] private GameObject destroyParticle;
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip destroySound;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamaga(float value)
    {
        currentHealth -= value;

        if (currentHealth <= 0)
        {
            AudioSource.PlayClipAtPoint(destroySound, transform.position);
            Instantiate(destroyParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);

        }

    }
}
