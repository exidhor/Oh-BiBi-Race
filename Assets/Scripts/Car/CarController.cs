using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CarPhysics))]
public class CarController : MonoBehaviour
{
    private AxisTrigger _horizontalInput;
    private ActionTrigger _useBonusInput;

    private CarPhysics _carPhysics;

    void Awake()
    {
        _horizontalInput = new AxisTrigger();
        _useBonusInput = new ActionTrigger();

        _carPhysics = GetComponent<CarPhysics>();
    }
	
	// Update is called once per frame
	void Update () {
		HandleInputs();

        _carPhysics.Turn(_horizontalInput.Axis);
	}

    void HandleInputs()
    {
        _horizontalInput.Axis = Input.GetAxis("Horizontal");
        _useBonusInput.Value = Input.GetButtonDown("UseBonus");
    }
}
