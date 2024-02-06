using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UI_Main_PopUp : MonoBehaviour
{
   
    [SerializeField]  private GameObject _menu;
    [SerializeField]  private GameObject _statPopup;
    [SerializeField]  private GameObject _ItemsPopup;
    [SerializeField]  private GameObject _StorePopup;
    [SerializeField]  private GameObject _HanYoog_BankPopup;
    
    public void OnStatPopUp()
    {
        _menu.SetActive(false);
        _statPopup.SetActive(true);
    }
    public void OffStatPopUp()
    {
        _menu.SetActive(true);
        _statPopup.SetActive(false);
    }

    public void OnItemsPopup()
    {
        _menu.SetActive(false);
        _ItemsPopup.SetActive(true);
    }
    public void OffItemsPopup()
    {
        _menu.SetActive(true);
        _ItemsPopup.SetActive(false);
    }

    public void OnStorePopup()
    {
        _menu.SetActive(false);
        _StorePopup.SetActive(true);
    }
    public void OffStorePopup()
    {
        _menu.SetActive(true);
        _StorePopup.SetActive(false);
    }

    public void OnHanYoog_BankPopup()
    {
        _menu.SetActive(false);
        _HanYoog_BankPopup.SetActive(true);
    }
    public void OffHanYoog_BankPopup()
    {
        _menu.SetActive(true);
        _HanYoog_BankPopup.SetActive(false);
    }
}
