using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{


    private PlayerMovement playerMovement;
    private PlayerTankSetting tankSetting;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        tankSetting = GetComponent<PlayerTankSetting>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Fuil"))
        {
            playerMovement.AddFuil(collision.GetComponent<FuilSetting>().GetFuilCapacity());
            collision.GetComponent<FuilSetting>().PlayePickUpSound();
            Destroy(collision.gameObject);
        }
        else if(collision.CompareTag("Repair"))
        {
            tankSetting.Repair(collision.GetComponent<RepairSetting>().GetSparePartsCapacity());
            collision.GetComponent<RepairSetting>().PlayePickUpSound();
            Destroy(collision.gameObject);
        }
    }
}
