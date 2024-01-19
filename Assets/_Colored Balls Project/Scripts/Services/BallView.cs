using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour, IBallMoveView
{
    [SerializeField] private Transform ballTransform;
    [SerializeField] priva
    public void Move()
    {
        ballTransform.transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }
}

public interface IBallMoveView
{
    public void Move();
}
