using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject settingsMenu;

    public void OpenSettingsMenu()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

        public void CloseSettingsMenu()
    {
        startMenu.SetActive(true);
        settingsMenu.SetActive(false);
    }
}
