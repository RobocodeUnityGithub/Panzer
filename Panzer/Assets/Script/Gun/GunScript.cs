using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{

    [SerializeField] private Transform muzzle;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField] private float gunReload;
    private TankGunAudio tankAudio;
    private bool canShoot = true;

    private void Start()
    {
        tankAudio = GetComponent<TankGunAudio>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl) && canShoot)
        {
            canShoot = false;
            Instantiate(shellPrefab, muzzle.transform.position, muzzle.transform.rotation);
            //tankAudio.PlayFierClip(muzzle.position);
            Invoke("Relod", gunReload);
        }
    }
    private void Relod()
    {
        //tankAudio.PlayFierClip(transform.position);
        canShoot = true;
    }
}
