using UnityEngine;

public interface IUserInputMoveDataProvider
{
    Vector2 MoveDirection { get; }
    bool IsMoved { get; }
}