using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourelleGun : MonoBehaviour
{
    [SerializeField] private Transform muzzle;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private float gunReload;
    private bool canShoot = true;


    public void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            GameObject shell = Instantiate(shellPrefab, muzzle.transform.position, muzzle.transform.rotation);
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), shell.GetComponent<Collider2D>());

            Invoke("Relod", gunReload);
        }
    }

    private void Relod()
    {
        canShoot = true;
    }

}
