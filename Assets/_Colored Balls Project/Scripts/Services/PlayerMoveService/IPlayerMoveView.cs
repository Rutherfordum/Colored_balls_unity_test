using UnityEngine;

public interface IPlayerMoveView
{
    float Speed { get; set; }
    void Move(Vector2 direction);
}