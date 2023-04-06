using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    [Range(1f, 10f)]
    [SerializeField] private float cameraMoveSpeed;
    [SerializeField] private Transform target;
    private float zOffset = -10f;


    private void Update()
    {
        Vector3 destination = new Vector3(target.position.x, target.position.y, zOffset);
        transform.position = Vector3.Lerp(transform.position, destination, cameraMoveSpeed * Time.deltaTime);
    }
}
