using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private int speed = 30;
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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitObj;
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (Physics.Raycast(ray, out hitObj))
        {
            movment.Set(horizontalMove, 0, verticalMove);
            movment = movment.normalized * speed * Time.deltaTime;
            playerRB.MovePosition(transform.position + movment);

            Vector3 playerAim = hitObj.point - transform.position;
            playerAim.y = 0;
            Quaternion newRotation = Quaternion.LookRotation(playerAim);
            playerRB.MoveRotation(newRotation);
        }
    }
}
