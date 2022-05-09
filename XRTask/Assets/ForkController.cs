using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkController : MonoBehaviour
{
    public GameObject Fork;
    public GameObject TopFork;

    public float ForkSpeed;

    private InputManager _inputManager;

    private Vector3 ForkStartPos;
    public float ForkMaxY;

    private bool _canTopForkMove=true;
    
    // Start is called before the first frame update
    void Start()
    {
        _inputManager = new InputManager();
        _inputManager.Initialize();
        ForkStartPos = Fork.transform.position;
        // Debug.Log(_inputManager);
        // _inputManager.OnForkDown += ForkDown;
        // _inputManager.OnForkUp += ForkUp;
    } 

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_inputManager.GetForkDown)
        {
            Fork.transform.Translate(Vector3.down*ForkSpeed*Time.deltaTime);
            if(_canTopForkMove) TopFork.transform.Translate(Vector3.down*ForkSpeed*Time.deltaTime);
        }
        
        if (_inputManager.GetForkUp)
        {
            Fork.transform.Translate(Vector3.up*ForkSpeed*Time.deltaTime);
            if(_canTopForkMove) TopFork.transform.Translate(Vector3.up*ForkSpeed*Time.deltaTime);
        }

        if (Fork.transform.position.y < ForkStartPos.y + ForkMaxY)
        {
            _canTopForkMove = true;
        }

        if (Fork.transform.position.y > ForkStartPos.y)
        {
            _canTopForkMove = true;
        }

        if (Fork.transform.position.y >= ForkStartPos.y + ForkMaxY)
        {
            Fork.transform.position = new Vector3(Fork.transform.position.x, ForkStartPos.y + ForkMaxY,
                Fork.transform.position.z);
            _canTopForkMove = false;
        }
        if (Fork.transform.position.y <= ForkStartPos.y)
        {
            Fork.transform.position = new Vector3(Fork.transform.position.x, ForkStartPos.y,
                Fork.transform.position.z);
            _canTopForkMove = false;
        }

    }

    private void ForkUp()
    {
        Debug.Log("Fork up");
        Fork.transform.Translate(Vector3.down * ForkSpeed * Time.deltaTime);
    }
    private void ForkDown()
    {
        Debug.Log("Fork down");
        Fork.transform.Translate(Vector3.up*ForkSpeed*Time.deltaTime);
    }
}
