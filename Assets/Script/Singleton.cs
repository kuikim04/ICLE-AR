using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Singleton : MonoBehaviour
    {
        public static Singleton Instance { get; private set; }

        public int levelNumSelect { get; set; }
        public int mapNumSelect { get; set; }
        public int numQulity { get; set; }
        public float soundVolume { get; set; }
        public float musicVolume { get; set; }
        public bool isMute { get; set; }
       

        private void Awake()
        {
            if (Instance == null) { Instance = this; DontDestroyOnLoad(gameObject); }


            else
            {
                Destroy(gameObject);
            }

            soundVolume = 1;
            musicVolume = 1;

            mapNumSelect = 0;
            levelNumSelect = 0;
            numQulity = 0;
            isMute = false;
        }
       
        // Start is called before the first frame update
        void Start()
        {

        }

      
    }
}
