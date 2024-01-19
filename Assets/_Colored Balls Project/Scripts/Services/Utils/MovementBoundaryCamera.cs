using Unity.Mathematics;
using UnityEngine;

public class MovementBoundaryCamera
{
    private Vector3 _pointZero;
    private Vector3 _pointMax;
    private ScreenData _screenData;

    public MovementBoundaryCamera()
    {
        _pointMax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        _pointZero = Camera.main.ScreenToWorldPoint(Vector3.zero);

        _screenData = new ScreenData()
        {
            PointMax = _pointMax,
            PointZero = _pointZero
        };
    }

    public void CheckBoundaryMovement(Transform transform)
    {
        float3 pos = transform.position;

        if (transform.position.y > _screenData.PointMax.y)
            pos.y = _screenData.PointZero.y;

        if (transform.position.y < _screenData.PointZero.y)
            pos.y = _screenData.PointMax.y;

        if (transform.position.x > _screenData.PointMax.x)
            pos.x = _screenData.PointZero.x;

        if (transform.position.x < _screenData.PointZero.x)
            pos.x = _screenData.PointMax.x;

        transform.position = pos;
    }
}