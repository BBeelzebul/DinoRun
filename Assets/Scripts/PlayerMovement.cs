using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float Jump;
    private Rigidbody2D playerRig;
    public bool isGrounded;

    private Animator animDio;

    public void Awake()
    {
        animDio = gameObject.GetComponent<Animator>();
        playerRig = GetComponent<Rigidbody2D>();
    }
 


    void Update()
    {
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRig.AddForce(Vector2.up * Jump);
            isGrounded = false;
            animDio.SetBool("Jumping", true);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animDio.SetTrigger("Bending");
            animDio.SetBool("Jumping", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animDio.Play("Run");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animDio.SetBool("Jumping", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(0);
        }
    }

}
