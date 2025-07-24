using UnityEngine;

namespace HomeWork7.Script.Runtime.Characters
{
    public class Player : Person
    {
        public int experience;

        private void Start()
        {
            ShowStat();
        }

        protected override void TakeDamage(int damageValue)
        {
            Health -= damageValue;
            Debug.Log($"My name is {Name}: After hitting with force: {damageValue}, I have: health {Health}");
        }

        public int Experience => experience;

        protected override void ShowStat()
        {
            Debug.Log($"Name={Name} Experience={experience}");
        }
    }
}

