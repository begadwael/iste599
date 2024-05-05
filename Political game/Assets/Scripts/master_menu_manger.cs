using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class master_menu_manger : MonoBehaviour
{
    [SerializeField] private List<Canvas> menus;

    private void Start()
    {
        foreach (Canvas menu in menus)
        {
            menu.enabled = false;
        }
        menus[0].enabled = true;

    }

    public void ChangeMenu(int menuIndex)
    {
        foreach (Canvas menu in menus)
        {
            menu.enabled = false;
            menu.gameObject.SetActive(false);
        }
        menus[menuIndex].enabled = true;
        menus[menuIndex].gameObject.SetActive(true);
    }

    public void CloseAllMenus()
    {
        foreach (Canvas menu in menus)
        {
            menu.enabled = false;
            menu.gameObject.SetActive(false);
        }
        this.gameObject.SetActive(false);
    }


}
