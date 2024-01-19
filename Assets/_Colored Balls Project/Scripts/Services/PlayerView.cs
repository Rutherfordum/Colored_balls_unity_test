using System;
using UnityEngine;

public class PlayerView : MonoBehaviour, IPlayerMoveView
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float speed;
    private MovementBoundaryCamera _movementBoundaryCamera;

    public float Speed
    {
        get => speed;
        set
        {
            if(value <= 0)
                throw new ArgumentException("The speed value cannot be less than or equal to zero");

            speed = value;
        }
    }

    private void Awake()
    {
        _movementBoundaryCamera = new MovementBoundaryCamera();
    }

    public void Move(Vector2 direction)
    {
        playerTransform.Translate(new Vector2(direction.x * Speed * Time.deltaTime, 0));
        _movementBoundaryCamera.CheckBoundaryMovement(playerTransform);
    }
}