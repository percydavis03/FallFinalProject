using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    public InputActionReference jumpAction;

    bool lastJumpPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        jumpAction.action.performed += (a) => SimilarFunction(0);
    }

    void SimilarFunction(int option)
    {
        Debug.Log($"Similar functino happened with: {option}"); 
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 40;
        float rotateSpeed = 100;

        Vector2 moveInput = moveAction.action.ReadValue<Vector2>();
        transform.position += transform.forward * moveInput.y * Time.deltaTime * moveSpeed;
        transform.rotation = Quaternion.Euler(Vector3.up * moveInput.x * rotateSpeed * Time.deltaTime) * transform.rotation;

        if (jumpAction.action.IsPressed() && !lastJumpPressed)
        {
            transform.position += new Vector3(0, 1, 0);
        }

        lastJumpPressed = jumpAction.action.IsPressed();
    }
}
