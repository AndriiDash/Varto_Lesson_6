using UnityEngine;

public class AddCollide : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " starts colliding with us");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " is colliding with us");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " ends colliding with us");
    }
}
