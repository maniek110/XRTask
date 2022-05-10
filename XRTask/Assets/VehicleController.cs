using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] private int _numOfWheels;
    [SerializeField] private SphereCollider[] _WheelColliders = new SphereCollider[4];
    [SerializeField] private GameObject[] _WheelGO = new GameObject[4];
    [SerializeField] private float _maxSteerAngle;
    [SerializeField] private float _wheelGrip;
    [SerializeField] private float _tractionControll;
    [SerializeField] private float _wheelTorque;
    [SerializeField] private float _downForce;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _steerRotBonus;


    private Quaternion[] _wheelRotations;
    private Rigidbody _rigidbody;
    private Quaternion _targetRot=Quaternion.identity;
    private Quaternion _targetWheelRot=Quaternion.identity;
    private float _prevYRot;
    
    private InputManager _inputManager;

    // Start is called before the first frame update
    void Start()
    {
        _inputManager = new InputManager();
        _inputManager.Initialize();
        _wheelRotations = new Quaternion[_numOfWheels];
        for (int i = 0; i < _numOfWheels; i++)
        {
            _wheelRotations[i] = _WheelColliders[i].transform.rotation;
        }

        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(_inputManager.ForwardVal, _inputManager.SidesVal);
    }

    private void Move(double inputManagerForwardVal, double inputManagerSidesVal)
    {
        // Debug.Log(inputManagerForwardVal);
        // Debug.Log(inputManagerSidesVal);
        //wheel rotation
        for (int i = 0; i < _numOfWheels; i++)
        {
            Quaternion quaternion;
            Vector3 vector3;
            vector3 = _WheelColliders[i].transform.position;
            quaternion = _WheelColliders[i].transform.rotation;
            _WheelGO[i].transform.rotation = quaternion;
            _WheelGO[i].transform.position = vector3;
        }

        float stearVal = Mathf.Clamp((float)inputManagerSidesVal, -1, 1);
        float acceleration = Mathf.Clamp((float)inputManagerForwardVal, -1, 1);

        float steringAngle = stearVal * _maxSteerAngle;
        _targetRot *= Quaternion.AngleAxis(steringAngle * Time.deltaTime, Vector3.up);
        // Debug.Log(0.1*_maxSteerAngle);
        if(Mathf.Abs(_targetRot.y)<0.01*_maxSteerAngle){
            _WheelGO[0].transform.rotation = _targetRot;
            _WheelGO[1].transform.rotation = _targetRot;
        }

        
        //vehicle rotation
        transform.rotation = _targetRot;

        //Acceleration
        _rigidbody.velocity = _rigidbody.velocity +(_rigidbody.mass*_wheelTorque*acceleration*transform.forward);
        
        //Speed Cap
        if (_rigidbody.velocity.magnitude * 3.6 > _maxSpeed)
        {
            _rigidbody.velocity = (_maxSpeed / 3.6f) * _rigidbody.velocity.normalized;
        }
        
        _WheelColliders[0].attachedRigidbody.AddForce(-transform.up*_downForce*_WheelColliders[0].attachedRigidbody.velocity.magnitude);
        
        //wheel rotation
        _targetWheelRot = Quaternion.AngleAxis(_rigidbody.velocity.x* acceleration * Time.deltaTime, Vector3.right);
        for (int i = 0; i < _numOfWheels; i++)
        {
            _WheelGO[i].transform.rotation=_targetWheelRot;
        }
    }
}