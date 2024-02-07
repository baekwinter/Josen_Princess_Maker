using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject statusButton;
    public GameObject Items_Buttons;
    public GameObject itemsImgPop; // 팝업창
    public GameObject equipIndicator; // 장착 이미지

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

    // 아이템 클릭 시 호출되는 메소드
    public void OnItemClick(GameObject item)
    {
        selectedItem = item;
        itemsImgPop.SetActive(true); // 팝업창 활성화
        equipIndicator.SetActive(true); // 장착 이미지 활성화
    }

    // 아이템 장착 상태 변경 메소드
    void ToggleEquipState()
    {
        isEquippingItem = !isEquippingItem;
        equipIndicator.SetActive(isEquippingItem);
    }
}