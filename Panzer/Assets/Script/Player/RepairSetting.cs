using UnityEngine;

public class RepairSetting : MonoBehaviour
{
    [SerializeField] private int sparePartsCapacity;
    [SerializeField] private AudioClip pickUpSound;


    public int GetSparePartsCapacity()
    {
        return sparePartsCapacity;
    }

    public void PlayePickUpSound()
    {
        AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
    }
}