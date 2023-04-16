using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuilSetting : MonoBehaviour
{
    [SerializeField] private int fuilCapacity;
    [SerializeField] private AudioClip pickUpSound;

    public int GetFuilCapacity()
    {
        return fuilCapacity;
    }

    public void PlayePickUpSound()
    {
        AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
    }
}
