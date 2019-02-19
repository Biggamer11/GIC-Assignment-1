using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject Options_MainMenu;
    public GameObject Options_OptionsMenu;

    public void Back()
    {
        Options_OptionsMenu.SetActive(false);
        Options_MainMenu.SetActive(true);
    }


}
