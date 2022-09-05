using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float Jump;
    private Rigidbody2D playerRig;
    private bool isGrounded;


    public void Awake()
    {
        playerRig = GetComponent<Rigidbody2D>();
    }

    public void Start()
    {
        
    }


    void Update()
    {
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerRig.AddForce(Vector2.up * Jump);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
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
