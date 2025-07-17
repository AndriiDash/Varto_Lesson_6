using UnityEngine;

    public class Player : Person
    {
        public int experience;

        private void Start()
        {
            ShowStat();
        }

        public int Experience => experience;

        protected override void ShowStat()
        {
            Debug.Log($"Name={Name} Experience={experience}");
        }
    }

