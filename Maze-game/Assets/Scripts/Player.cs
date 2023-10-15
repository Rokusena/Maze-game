using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            transform.position = new Vector3(-20f, 0.1f, -18f);
        }
    }
}
