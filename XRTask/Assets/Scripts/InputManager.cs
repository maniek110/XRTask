using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputManager : IInitializable,IDisposable
{
    private PlayerInput _playerInput;

    public Action OnForkUp;
    public Action OnForkDown;
    public Action OnInputForward;
    public Action OnInputBackward;

    private bool _getForwardInput,_getSidesInput,_getForkUp,_getForkDown;
    private float _ForwardVal, _SidesVal;

    public InputManager()
    {
        _playerInput = new PlayerInput();
        _playerInput.Input.ForkUp.performed += _ => _getForkUp=true;
        _playerInput.Input.ForkUp.canceled += _ => _getForkUp=false;
        _playerInput.Input.ForkDown.performed += _ => _getForkDown=true;
        _playerInput.Input.ForkDown.canceled += _ => _getForkDown=false;
        _playerInput.Input.MovementForward.performed += _ => _getForwardInput=true;
        _playerInput.Input.MovementForward.performed += _ => SetForward();
        _playerInput.Input.MovementForward.canceled += _ => SetForward();
        _playerInput.Input.MovementSides.performed += _ => _getSidesInput=true;
        _playerInput.Input.MovementSides.performed += _ => SetSides();
        _playerInput.Input.MovementSides.canceled += _ => SetSides();
    }

    public bool GetForkDown
    {
        get => _getForkDown;
        set => _getForkDown = value;
    }

    public bool GetForkUp
    {
        get => _getForkUp;
        set => _getForkUp = value;
    }

    public bool GetSidesInput
    {
        get => _getSidesInput;
        set => _getSidesInput = value;
    }

    public bool GetForwardInput
    {
        get => _getForwardInput;
        set => _getForwardInput = value;
    }

    public float SidesVal
    {
        get => _SidesVal;
        set => _SidesVal = value;
    }

    public float ForwardVal
    {
        get => _ForwardVal;
        set => _ForwardVal = value;
    }

    public void SetForward()
    {
        ForwardVal = _playerInput.Input.MovementForward.ReadValue<float>();
    }

    public void SetSides()
    {
        _SidesVal = _playerInput.Input.MovementSides.ReadValue<float>();
    }

    public void Initialize()
    {
        _playerInput.Enable();
    }

    public void Dispose()
    {
        _playerInput.Disable();
    }
}
