using UnityEngine;

namespace Runtime.Character
{
    public class PlayerMovement : MonoBehaviour
    {
        private float horizontalInput;
        private float verticalInput;
        private float turnSpeed = 10f;

        void Update()
        {
            //read values from keyboard 
            horizontalInput = Input.GetAxis("Horizontal");

            //move the object
            transform.Translate(-Vector3.right * (Time.deltaTime * horizontalInput * turnSpeed), Space.World);
        }
    }
}