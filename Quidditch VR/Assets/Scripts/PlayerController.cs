using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 5;
    private float upSpeed = 1;
    private Rigidbody playerRigidbody;

    #region Unity Functions
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        Movement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ScorePoints")
        {
            Debug.Log("SCORE");
        }
    }

    #endregion

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressed W");
            playerRigidbody.AddForce(transform.forward * playerSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressed S");
            playerRigidbody.AddForce(-transform.forward * playerSpeed);
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180 * Time.fixedDeltaTime, transform.rotation.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A");
            playerRigidbody.AddForce(playerSpeed, 0, 0);
            transform.Rotate(0, Time.fixedDeltaTime * -90, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D");
            playerRigidbody.AddForce(-playerSpeed, 0, 0);
            transform.Rotate(transform.rotation.x, Time.fixedDeltaTime * 90, transform.rotation.z);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed space");
            playerRigidbody.AddForce(0, upSpeed, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Pressed shift");
            playerRigidbody.AddForce(0, -upSpeed, 0);
        }
    }
    
}
