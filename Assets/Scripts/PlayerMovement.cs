using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    PlayerControls controls;

    void Awake()
    {
        // instantiate the actions wrapper class
        controls = new PlayerControls();

        // for the "jump" action, we add a callback method for when it is performed
        controls.Moving.Move.performed += OnMove;
    }

    void OnEnable()
    {
        controls.Moving.Enable();
    }

    void OnDisable()
    {
        controls.Moving.Disable();
    }

    private void OnMove(InputAction.CallbackContext context) {
        float direction = 0;
        if (context.ReadValue<float>() == -1) {
            direction = transform.position.x == -2.5 ? 0 : -2.5f;
        } else {
            direction = transform.position.x == 2.5 ? 0 : 2.5f;
        }

        transform.position = new Vector3(transform.position.x + direction, transform.position.y, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
