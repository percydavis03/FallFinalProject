using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference moveAction;
    public InputActionReference jumpAction;
    public List<GameObject> dialogs = new List<GameObject>();
    private bool dialogActive;

    bool lastJumpPressed = false;
   [SerializeField] float moveSpeed = 25;
    float rotateSpeed = 180;

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
        foreach (GameObject dialog in dialogs)
            {
            if (dialog.activeInHierarchy)
            {
                dialogActive = true;
                return;
            }
            else
            {
                dialogActive = false;
            }
        }


        Vector2 moveInput = moveAction.action.ReadValue<Vector2>();
        if (dialogActive == false)
        {
            transform.position += -transform.forward * moveInput.y * Time.deltaTime * moveSpeed;
            transform.rotation = Quaternion.Euler(Vector3.up * moveInput.x * rotateSpeed * Time.deltaTime) * transform.rotation;

            if (jumpAction.action.IsPressed() && !lastJumpPressed)
            {
                transform.position += new Vector3(0, 1, 0);
            }

            lastJumpPressed = jumpAction.action.IsPressed();
        }
            

       
    }
}
