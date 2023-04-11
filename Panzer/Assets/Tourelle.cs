using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    [SerializeField] private Transform weaponTransform;
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] float range = 15f;
    private Transform playerTransform;

    private float distanceToTarget;
    private TourelleGun tourelleGun;

    private void Start()
    {
        tourelleGun = GetComponent<TourelleGun>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        distanceToTarget = Vector2.Distance(transform.position, playerTransform.position);
        if ( distanceToTarget < range)
        {
            RotationToTarget();
            tourelleGun.Shoot();
        }
    }

    private void RotationToTarget()
    {
        Vector3 direction = playerTransform.position - weaponTransform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        weaponTransform.rotation = Quaternion.Slerp(weaponTransform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}