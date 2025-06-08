using System;
using UnityEngine;

namespace Runtime.Character
{
    public class Person : MonoBehaviour
    {
      public MeshRenderer meshRenderer;
        public Transform myTransform;
        public Rigidbody rigidbody;
        public string name = "Undefined";
        public int age;
        public int health;
        
       
        private void Start()
        {
           //  myTransform.position = new Vector3(6, 7, 4);
           //  meshRenderer = GetComponent<MeshRenderer>();
           //  meshRenderer.enabled = false;
           // rigidbody.useGravity = false;
        }
    }
}
