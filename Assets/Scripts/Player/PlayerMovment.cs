using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private int speed = 30;
    [SerializeField] private float rotationSpeed = 200;
    private Vector3 movment;
    Rigidbody playerRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        movment.Set(horizontalMove, 0, verticalMove);
        movment = movment.normalized * speed * Time.deltaTime;
        transform.Translate(movment * speed * Time.deltaTime);

        float rotationInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up,rotationInput * rotationSpeed * Time.deltaTime);
    }
}
