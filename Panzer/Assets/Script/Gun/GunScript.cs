using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    [SerializeField] private Transform muzzle;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private float gunReload;
    private bool canShoot = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl) && canShoot)
        {
            canShoot = false;
            Instantiate(shellPrefab, muzzle.transform.position, muzzle.transform.rotation);
            Invoke("Relod", gunReload);
        }
    }
    private void Relod()
    {
        canShoot = true;
    }
}
