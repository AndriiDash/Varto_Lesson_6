using UnityEngine;

namespace Runtime.Character
{
    public class Person : MonoBehaviour
    {
    public int health;
    private int armor;

    void TakeDamage(int value)
    {
        if(value < 0 || value > 100) return;
        health -= value;
    }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
