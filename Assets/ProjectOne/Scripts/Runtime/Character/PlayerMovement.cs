using UnityEngine;

namespace Runtime.Character
{
    public class PlayerMovement : MonoBehaviour
    {
        public float horizontalInput;
        public float verticalInput;
        public float turnSpeed = 10f;

        void Update()
        {
            //read values from keyboard 
            horizontalInput = Input.GetAxis("Horizontal");

            //move the object
            transform.Translate(-Vector3.right * (Time.deltaTime * horizontalInput * turnSpeed), Space.World);
        }
    }
}