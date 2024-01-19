using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class UserInputService :
    IUserInputService,
    IUserInputMoveDataProvider,
    IInitializable, 
    IDisposable
{
    public Vector2 MoveDirection { get; private set; }
    public bool IsMoved { get; private set; }

    private UserInputActions _userInputActions;

    public void Initialize()
    {
        _userInputActions = new UserInputActions();
        _userInputActions.UserInputActionMap.Move.started += Move;
        _userInputActions.UserInputActionMap.Move.performed += Move;
        _userInputActions.UserInputActionMap.Move.canceled += Move;
        Enable();
    }

    public void Dispose()
    {
        Disable();
        _userInputActions.UserInputActionMap.Move.started -= Move;
        _userInputActions.UserInputActionMap.Move.performed -= Move;
        _userInputActions.UserInputActionMap.Move.canceled -= Move;
        _userInputActions.Dispose();
    }

    public void Enable()
    {
        _userInputActions.Enable();
    }

    public void Disable()
    {
        _userInputActions.Disable();
    }

    private void Move(InputAction.CallbackContext context)
    {
        MoveDirection = context.ReadValue<Vector2>();
        IsMoved = MoveDirection.x != 0 || MoveDirection.y != 0;
    }
}