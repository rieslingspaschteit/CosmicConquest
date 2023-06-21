using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController character;
    public float speed = 10f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;
    public float jumpCooldown = 1.2f;
    float timeSinceAction = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceAction += Time.deltaTime;

        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right  * x + transform.forward * z;
        character.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        character.Move(velocity * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && timeSinceAction > jumpCooldown) {
            timeSinceAction = 0;
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
    }
}
