using UnityEngine;

//Create a sphere with standart components
namespace Runtime.Character
{
    public class LocationBuilder : MonoBehaviour
    {
        private GameObject cube;
        private Renderer cubeRenderer;
        private Material greenMat;
        private Material yellowMat;
        public float horizontalInput;
        public float verticalInput;
        private Rigidbody rb;
        public float turnSpeed = 2f;
        private void Start()
        {
            // Creating the cube
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 19, 0);
            cube.name = "Player Cube";
            cube.AddComponent<Rigidbody>();

            //Creating green material
            greenMat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            greenMat.color = Color.green;
            cube.GetComponent<Renderer>().material = greenMat;
            rb = cube.AddComponent<Rigidbody>();
          
        }

        private void Update()
        {

            //read values from keyboard 
            horizontalInput = Input.GetAxis("Horizontal");

            //move the object
            cube.transform.Translate(-Vector3.right * (Time.deltaTime * horizontalInput * turnSpeed), Space.World);
        }
    }
}