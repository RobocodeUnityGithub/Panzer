using UnityEngine;

public class RepairSetting : MonoBehaviour
{
    [SerializeField] private int sparePartsCapacity;

    public int GetSparePartsCapacity()
    {
        return sparePartsCapacity;
    }
}