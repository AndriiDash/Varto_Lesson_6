using UnityEngine;
namespace HomeWork7.Script.Runtime.Characters

{
    public class Dragon : Person
    {
        public override void TakeDamage(int damageValue)
        {
            Health -= damageValue;
            Debug.Log($"I, the mighty dragon, have lost:{damageValue} hitpoints from a hunter's shot");  
        }
        
        }
    }
