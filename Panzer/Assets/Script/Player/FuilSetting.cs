using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuilSetting : MonoBehaviour
{
    [SerializeField] private int fuilCapacity;

    public int GetFuilCapacity()
    {
        return fuilCapacity;
    }
}
