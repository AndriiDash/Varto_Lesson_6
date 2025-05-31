using UnityEngine;

namespace Runtime.Character
{
    public class Publicinthealth: MonoBehaviour
    {

    public int health;

    void TakeDamage(int value)
    {
        if(value < 0) return;
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
