using UnityEngine;

namespace HomeWork7.Script.Runtime.Characters
{
    public abstract class Person : MonoBehaviour
    {
        [SerializeField] private string name;
        [SerializeField] protected int health;

        private void Start()
        {
            Debug.Log($"Person name={Name}");
            Health = health;
            Debug.Log($"Person health={Health}");
            ShowStat();
        }

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    Debug.Log("Name is null or empty, please try again");
                    return "Unknown";
                }

                return name;
            }
        }

        public int Health
        {
            set
            {
                if (value < 0 || value > 100)
                    Debug.Log("Health is out of range, please try again");
                else
                    health = value;
            }
            get { return health; }
        }

        protected abstract void TakeDamage(int damageValue);
        

        protected virtual void ShowStat()
        {
            Debug.Log($"Name={Name}");
        }
    }
}