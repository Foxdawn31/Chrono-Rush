using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float Speed = 0.05f;
    private PlayerInput inputs;

    private InputAction movementAction;

    // Start is called before the first frame update
    void Awake()
    {
        inputs = GetComponent<PlayerInput>();

        movementAction = inputs.actions["Mouvements"];
        inputs.actions["Jump"].performed += Jump;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = movementAction.ReadValue<Vector2>();
        Vector3 movementV3 = new Vector3(movement.x, movement.y);

        transform.Translate(movement * Speed);
    } 
    void Jump(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jump");
    }
}
