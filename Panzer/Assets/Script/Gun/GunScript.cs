using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    [SerializeField] private Transform muzzle;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private float gunReload;
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private AudioClip relodSound;
    private bool canShoot = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl) && canShoot)
        {
            canShoot = false;
            AudioSource.PlayClipAtPoint(shootSound, muzzle.position);
            Instantiate(shellPrefab, muzzle.transform.position, muzzle.transform.rotation);
            Invoke("Relod", gunReload);
        }
    }
    private void Relod()
    {
        AudioSource.PlayClipAtPoint(relodSound, transform.position);
        canShoot = true;
    }
}
