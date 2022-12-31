//Jan Kopejtko, 2022

using UnityEngine;

public class pohyb : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField] private Animator animator;
    public Rigidbody rb;
    
    [SerializeField] private float movementSpeed, rotationSpeed, jumpSpeed, gravity;
    private Vector3 movementDirection = Vector3.zero;
    private bool playerGrounded;
    private Vector3 inputMovement = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.visible = false;
    }
    void Update()
    {
        playerGrounded = characterController.isGrounded;
        //movement
        if (playerGrounded)
        { 
            inputMovement = transform.forward * movementSpeed * Input.GetAxisRaw("Vertical");
        }
        characterController.Move(inputMovement * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * rotationSpeed);

        //jumping 
        if (Input.GetButton("Jump") && playerGrounded)
        {
            movementDirection.y =+ jumpSpeed;
            animator.SetBool("isJumping", true);
            animator.SetBool("isRunning", false);
            animator.SetBool("isIdle", false);
            animator.SetBool("isBackRunning", false);
        }
        else 
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", true);   
            animator.SetBool("isBackRunning", true);
        }
        
        //move one frame
        movementDirection.y -= gravity * Time.deltaTime;
        characterController.Move(movementDirection * Time.deltaTime);

        //animations
        animator.SetBool("isRunning", Input.GetAxisRaw("Vertical") > 0);
        animator.SetBool("isBackRunning", Input.GetAxisRaw("Vertical") < 0);
        animator.SetBool("isIdle", Input.GetAxisRaw("Vertical") == 0);

        if (rb.position.y <= -15f)
        {
            FindObjectOfType<event_manager>().EndGame();
        }
    }
}