using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShellSetting : MonoBehaviour
{
    [SerializeField] private float shellSpeed;
    [SerializeField] private int shellDamage;
    [SerializeField] private bool isEnemy;
    private Rigidbody2D rb2d;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb2d.AddForce(transform.up * shellSpeed, ForceMode2D.Impulse);
        Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Fuil"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isEnemy && collision.gameObject.tag == ("Player"))
        {
            collision.gameObject.GetComponent<PlayerTankSetting>().TakeDamaga(shellDamage);
            Destroy(gameObject);
        }

        if (isEnemy == false && collision.gameObject.tag == ("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyHP>().TakeDamaga(shellDamage);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == ("Shell"))
        {
            Destroy(gameObject);
        }
    }
}
