using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 7.0f;

    [SerializeField]
    private float jumpHeight = 1.0f;

    [SerializeField]
    private float gravityValue = -9.81f;

    [SerializeField]
    private float rotationSpeed = 4f;

    [SerializeField]
    public Animator playerAnimator;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private PlayerControls playerInput;
    private Transform cameraMain;
    private Transform child;

    private void Awake()
    {
        playerInput = new PlayerControls();
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }


    private void Start()
    {
        cameraMain = Camera.main.transform;
        child = transform.GetChild(0).transform;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
            playerAnimator.SetBool("isJumping", false);
        }

        Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();

        if (movementInput != Vector2.zero)
        {
            playerAnimator.SetBool("isRunning", true);
        }
        else
        {
            playerAnimator.SetBool("isRunning", false);
        }

        //Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y); //Works with mouse
        Vector3 move = (cameraMain.forward * movementInput.y + cameraMain.right * movementInput.x);
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);

        // Changes the height position of the player..
        if (playerInput.PlayerMain.Jump.triggered && groundedPlayer)
        {
            playerAnimator.SetBool("isJumping", true);
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        // Emote 1
        if (playerInput.PlayerMain.Emote1.triggered)
        {
            playerAnimator.SetBool("emote-1", true);
        }
        else
        {
            playerAnimator.SetBool("emote-1", false);
        }

        // Emote 2
        if (playerInput.PlayerMain.Emote2.triggered)
        {
            playerAnimator.SetBool("emote-2", true);
        }
        else
        {
            playerAnimator.SetBool("emote-2", false);
        }

        // Emote 3
        if (playerInput.PlayerMain.Emote3.triggered)
        {
            playerAnimator.SetBool("emote-3", true);
        }
        else
        {
            playerAnimator.SetBool("emote-3", false);
        }

        // Emote 4
        if (playerInput.PlayerMain.Emote4.triggered)
        {
            playerAnimator.SetBool("emote-4", true);
        }
        else
        {
            playerAnimator.SetBool("emote-4", false);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);


        if (movementInput != Vector2.zero)
        {
            Quaternion rotation = Quaternion.Euler(new Vector3(child.localEulerAngles.x, cameraMain.localEulerAngles.y, child.localEulerAngles.z));
            child.rotation = Quaternion.Lerp(child.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
    }

}
