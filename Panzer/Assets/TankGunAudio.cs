using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGunAudio : MonoBehaviour
{
    [SerializeField] private AudioClip fierClip;
    [SerializeField] private AudioClip reloudClip;

    public void PlayFierClip(Vector3 positionGun)
    {
        AudioSource.PlayClipAtPoint(fierClip, positionGun);

    }

    public void PlayRelod(Vector3 positionGun)
    {
       AudioSource.PlayClipAtPoint(fierClip, positionGun);
    }
}
