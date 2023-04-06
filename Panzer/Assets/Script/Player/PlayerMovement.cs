using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float tankFuil;
    [SerializeField] private float tankSpeed = 50f;
    [SerializeField] private float rotateSpeed = 1f;
    private Rigidbody2D rb2d;
    private bool isMovement;

    private Vector3 direction;
    private float rotationValue;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        tankFuil = 100;
        InvokeRepeating("EngineWorking", 0.5f, 1f);
    }
    private void Update()
    {
        MovementInput();
    }
    public void AddFuil(float value)
    {
        tankFuil += value;
        if (tankFuil > 100) tankFuil = 100;
    }
    private void MovementInput()
    {
        if (Input.GetKey(KeyCode.W))
            direction = (transform.up * tankSpeed) * Time.fixedDeltaTime;

        else if (Input.GetKey(KeyCode.S))
            direction = (-transform.up * tankSpeed) * Time.fixedDeltaTime;

        else direction = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
            rotationValue = rb2d.rotation + rotateSpeed;

        if (Input.GetKey(KeyCode.D))
            rotationValue = rb2d.rotation - rotateSpeed;
    }

    private void FixedUpdate()
    {
        rb2d.velocity = direction;
        rb2d.MoveRotation(rotationValue);
    }
    private void EngineWorking()
    {
        if(tankFuil >= 0)
        {
            if (rb2d.velocity != Vector2.zero)
            {
                tankFuil -= 2f;
            }
            else
            {
                tankFuil -= 0.5f;
            }
        }

    }
}
