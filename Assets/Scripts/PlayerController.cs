using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private ControllerInputs _controllerInputs;
    
    public delegate void NoParameters();

    public NoParameters InputGot;
        
    
    // Start is called before the first frame update
    void Awake()
    {
        _controllerInputs = new ControllerInputs();
        _controllerInputs.InGame.Enable();
    }

    public void OnEnable()
    {
        _controllerInputs.InGame.PlayerMovement.performed += PlayerMovementOnperformed;
        _controllerInputs.InGame.PlayerMovement.canceled += PlayerMovementOnperformed;


    }
    void PlayerMovementOnperformed(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector2>());
        InputGot?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDisable()
    {
        _controllerInputs.InGame.PlayerMovement.performed -= PlayerMovementOnperformed;
        _controllerInputs.InGame.PlayerMovement.canceled -= PlayerMovementOnperformed;
    }
}
