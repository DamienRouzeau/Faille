using Unity.VisualScripting;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [Tooltip("Move speed of the character in m/s")]
    [Range(0, 10)]
    public float MoveSpeed = 4.0f;
    [Tooltip("Sprint speed of the character in m/s")]
    [Range(0, 20)]
    public float SprintSpeed = 6.0f;
    private bool canSprint = true;


    [Header("Rotation")]
    [Tooltip("Rotation speed of the character")]
    [Range(0, 5)]
    public float RotationSpeed = 1.0f;
    [SerializeField] private float MouseRotationSpeed = 1.0f;
    [SerializeField] private float GamepadRotationSpeed = 0.4f;
    [Tooltip("Acceleration and deceleration")]
    public float SpeedChangeRate = 10.0f;
    public bool canMove = true;
    public bool canRotate = true;
    [SerializeField]
    private PlayerInput playerInput;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (canMove) Move();

    }

    private void FixedUpdate()
    {

    }

    public void OnMove()
    {
        Debug.Log("Move detected : ");
    }

    public void OnLook()
    {
        Debug.Log("Look detected : ");
    }


}