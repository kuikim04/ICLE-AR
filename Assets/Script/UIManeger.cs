using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script
{
    public class UIManeger : MonoBehaviour
    {
        [Header("First Page")]
        public GameObject uiFirst;
        public GameObject uiLogin;

        [Header("Login Page")]
        public GameObject uiMainMenu;
        [Header("Register Page")]
        public GameObject uiRegister;

        [Header("MainMenu")]
        public GameObject uiSetting;
        public GameObject uiCredit;
        public GameObject uiHowtoPlay;

        [Header("Select Level & Select Scene")]
        public GameObject uiSelectLevel;
        public GameObject uiSelectScene;

        public GameObject selectSceneP1;
        public GameObject selectSceneP2;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void FirstPage()
        {
            uiFirst.SetActive(false);
            uiLogin.SetActive(true);
        }

        #region Login & Register Page
        public void LoginPage()
        {
            uiLogin.SetActive(false);
            uiMainMenu.SetActive(true);
        }

        public void RegisterPage()
        {
            uiLogin.SetActive(false);
            uiRegister.SetActive(true);
        }
        public void RegisterBtn()
        {
            uiRegister.SetActive(false);
            uiLogin.SetActive(true);
        }
        #endregion

        #region Main Menu
        public void PlayGame()
        {
            uiSelectLevel.SetActive(true);
        }

        public void Setting()
        {
            uiSetting.SetActive(true);
        }
        public void CloseSetting()
        {
            uiSetting.SetActive(false);
        }

        public void Credit()
        {
            uiCredit.SetActive(true);
        }
        public void CloseCredit()
        {
            uiCredit.SetActive(false);
        }

        public void HowtoPlay()
        {
            uiHowtoPlay.SetActive(true);
        }
        public void CloseHowtoPlay()
        {
            uiHowtoPlay.SetActive(false);
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        #endregion

        #region Select Level & Scene

        public void SelectLevelBack()
        {
            uiSelectLevel.SetActive(false);
        }
        public void SelectSceneBack()
        {
            uiSelectScene.SetActive(false);
        }

        public void SelectLevel1()
        {
            if (selectSceneP2.activeSelf)
            {
                selectSceneP1.SetActive(true);
                selectSceneP2.SetActive(false);
            }

            Singleton.Instance.levelNumSelect = 1;

            uiSelectScene.SetActive(true);
        }
        public void SelectLevel2()
        {
            if (selectSceneP2.activeSelf)
            {
                selectSceneP1.SetActive(true);
                selectSceneP2.SetActive(false);
            }

            Singleton.Instance.levelNumSelect = 2;

            uiSelectScene.SetActive(true);
        }
        public void SelectLevel3()
        {
            if (selectSceneP2.activeSelf)
            {
                selectSceneP1.SetActive(true);
                selectSceneP2.SetActive(false);
            }

            Singleton.Instance.levelNumSelect = 3;

            uiSelectScene.SetActive(true);
        }

        #region Select Map
        public void SelectMap1()
        {
            if(Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if(Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 1;
        }
        public void SelectMap2()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 2;
        }
        public void SelectMap3()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }
            
            Singleton.Instance.mapNumSelect = 3;
        }
        public void SelectMap4()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 4;
        }
        public void SelectMap5()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if(Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 5;
        }
        public void SelectMap6()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if(Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 6;
        }
        public void SelectMap7()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 7;
        }
        public void SelectMap8()
        {
            if (Singleton.Instance.mapNumSelect == 1)
            {
                SceneManager.LoadScene(1);
            }
            if (Singleton.Instance.mapNumSelect == 2)
            {
                SceneManager.LoadScene(2);
            }
            if (Singleton.Instance.mapNumSelect == 3)
            {
                SceneManager.LoadScene(3);
            }

            Singleton.Instance.mapNumSelect = 8;
        }
        #endregion

        public void SLSnextPage()
        {
            selectSceneP1.SetActive(false);
            selectSceneP2.SetActive(true);
        } 
        public void SLSbackPage()
        {
            selectSceneP1.SetActive(true);
            selectSceneP2.SetActive(false);
        }

        #endregion
    }
}