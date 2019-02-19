using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenu_MainMenu;
    public GameObject MainMenu_Options;
    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        MainMenu_Options.SetActive(true);
        MainMenu_MainMenu.SetActive(false);
    }

}
