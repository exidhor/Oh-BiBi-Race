using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CarPhysics : MonoBehaviour
{
    public float OrientationInDegree
    {
        get { return _rigidbody.rotation; }
        set { _rigidbody.rotation = value; }
    }

    public float OrientationInRadian
    {
        get { return OrientationInDegree * Mathf.Deg2Rad; }
        set { OrientationInDegree = value * Mathf.Rad2Deg; }
    }

    public float Speed;

    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _angularVelocity;

    private Rigidbody2D _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();

        Accelerate(Time.fixedDeltaTime);

        CapSpeed();
    }

    public void Turn(float axis)
    {
        _rigidbody.angularVelocity = _angularVelocity*-axis;
    }

    void Move()
    {
        _rigidbody.velocity = GetOrientationAsVector() * Speed;
    }

    void Accelerate(float deltaTime)
    {
        Speed += _acceleration*deltaTime;
    }

    void CapSpeed()
    {
        if (Speed > _maxSpeed)
        {
            Speed = _maxSpeed;
        }
    }

    public Vector2 GetOrientationAsVector()
    {
        return MathHelper.GetDirectionFromAngle(OrientationInRadian);
    }
}
