using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourelle : MonoBehaviour
{
    [SerializeField] private Transform weaponTransform;
    [SerializeField] private Transform muzzle;
    [SerializeField] private float rotationSpeed = 5f;
    private Transform playerTransform;


    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private float gunReload;
    private bool canShoot = true;


    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {

        if (playerTransform != null && playerTransform.gameObject.activeSelf)
        {
            Vector3 direction = playerTransform.position - weaponTransform.position;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            weaponTransform.rotation = Quaternion.Slerp(weaponTransform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

            if (canShoot)
            {
                canShoot = false;
                GameObject shell = Instantiate(shellPrefab, muzzle.transform.position, muzzle.transform.rotation);
                Physics2D.IgnoreCollision(GetComponent<Collider2D>(), shell.GetComponent<Collider2D>());

                Invoke("Relod", gunReload);
            }
        }
    }

    private void Relod()
    {
        canShoot = true;
    }

}