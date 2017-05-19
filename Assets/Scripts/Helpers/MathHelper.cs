using UnityEngine;

public static class MathHelper
{
    public static Vector2 GetDirectionFromAngle(float angleInRadian)
    {
        return new Vector2(Mathf.Cos(angleInRadian),
            Mathf.Sin(angleInRadian));
    }
}