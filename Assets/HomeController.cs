using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NultBolts
{
    using SingleApp;

    public class HomeController : Singleton<HomeController>
    {
        public GameObject home;

        public void PlayGame()
        {
            home.SetActive(false);
        }

        public void BackToHome()
        {
            home.SetActive(true);
        }
    }
}
