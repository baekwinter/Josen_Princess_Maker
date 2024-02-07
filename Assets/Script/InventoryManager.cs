using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject statusButton;
    public GameObject Items_Buttons;
    public GameObject itemsImgPop; // �˾�â
    public GameObject equipIndicator; // ���� �̹���

    private bool isEquippingItem = false;
    private GameObject selectedItem = null;

    void Start()
    {
        statusButton.SetActive(false);
        Items_Buttons.SetActive(false);
    }

    void Update()
    {
        if (isEquippingItem && Input.GetKeyDown(KeyCode.E))
        {
            ToggleEquipState();
        }
    }

    // ������ Ŭ�� �� ȣ��Ǵ� �޼ҵ�
    public void OnItemClick(GameObject item)
    {
        selectedItem = item;
        itemsImgPop.SetActive(true); // �˾�â Ȱ��ȭ
        equipIndicator.SetActive(true); // ���� �̹��� Ȱ��ȭ
    }

    // ������ ���� ���� ���� �޼ҵ�
    void ToggleEquipState()
    {
        isEquippingItem = !isEquippingItem;
        equipIndicator.SetActive(isEquippingItem);
    }
}