using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CameraMovment();
    }

    void CameraMovment()
    {
        Vector3 offset = transform.position - Player.position;
        Vector3 playerMovment = Player.position;
        Quaternion playerAim = Player.rotation;
        transform.position = playerMovment;
        transform.rotation = Quaternion.Lerp(transform.rotation, playerAim, 5 * Time.deltaTime); ;
        
    }
}
