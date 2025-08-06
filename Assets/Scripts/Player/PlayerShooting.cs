using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject Gun;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletPrefab,Gun.transform.position,Gun.transform.rotation);
        }
    }
}
