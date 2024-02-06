using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject statusButton;
    public GameObject Items_Buttons;
    public GameObject itemPanel; // �κ��丮 �������� ��� �ִ� �г�
    public GameObject equipIndicator; // ������ ������ ǥ�õǴ� �ε�������
    public GameObject itemsImgPop; // �������� ������ �� ǥ�õǴ� �˾�â

    public List<string> itemNames = new List<string>()
    {
        "���ϱ� ���� ������ �ּ���",
        "�ױ� ���� ������ ��",
        "������ �λ� ����, ������",
        "�������� �ް���� ������ ��������"
    };

    private bool isEquippingItem = false;
    private GameObject selectedItem = null;

    void Start()
    {
        statusButton.SetActive(false);
        Items_Buttons.SetActive(false);

        // ������ ����
        foreach (string itemName in itemNames)
        {
            CreateItem(itemName);
        }
    }

    void Update()
    {
        if (isEquippingItem && Input.GetKeyDown(KeyCode.E))
        {
            ToggleEquipState();
        }
    }

    void CreateItem(string itemNames)
    {
        // Resources ������ �ִ� �ش� �̸��� �̹����� �ε��մϴ�.
        Sprite itemSprite = Resources.Load<Sprite>("Items/" + itemNames);

        // ���ο� ������ GameObject�� �����ϰ� ItemPanel�� �߰��մϴ�.
        GameObject newItem = new GameObject(itemNames);
        newItem.transform.SetParent(itemPanel.transform, false);

        // �������� �̹����� �߰��մϴ�.
        Image itemImage = newItem.AddComponent<Image>();
        itemImage.sprite = itemSprite;

        // �������� Ŭ������ ���� ������ �����մϴ�.
        Button itemButton = newItem.AddComponent<Button>();
        itemButton.onClick.AddListener(() => OnItemClick(itemNames));
    }

    void OnItemClick(string itemNames)
    {
        // Ŭ���� �����ۿ� �ش��ϴ� �˾�â�� Ȱ��ȭ�մϴ�.
        GameObject popUp = GameObject.Find("itemsImgPop/" + itemNames);
        if (popUp != null)
        {
            popUp.SetActive(true);
        }
    }


    // ������ ���� Ȯ�� �˾� ǥ�� �޼ҵ�
    void ShowEquipConfirmationPopup(string message, GameObject item)
    {
        selectedItem = item;
        Debug.Log(message + " �˾��� ǥ���մϴ�.");

        // �˾�â Ȱ��ȭ
        itemsImgPop.SetActive(true);
    }

    // ������ ���� ���� ���� �޼ҵ�
    void ToggleEquipState()
    {
        isEquippingItem = !isEquippingItem;
        if (isEquippingItem)
        {
            equipIndicator.SetActive(true);
        }
        else
        {
            equipIndicator.SetActive(false);
        }
    }
}
