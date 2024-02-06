using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject statusButton;
    public GameObject Items_Buttons;
    public GameObject itemPanel; // 인벤토리 아이템을 담고 있는 패널
    public GameObject equipIndicator; // 아이템 장착시 표시되는 인디케이터
    public GameObject itemsImgPop; // 아이템을 장착할 때 표시되는 팝업창

    public List<string> itemNames = new List<string>()
    {
        "일하기 싫은 공주의 주술서",
        "죽기 싫은 공주의 방어구",
        "공주의 인생 역작, 전투복",
        "프로포즈 받고싶은 공주의 마법반지"
    };

    private bool isEquippingItem = false;
    private GameObject selectedItem = null;

    void Start()
    {
        statusButton.SetActive(false);
        Items_Buttons.SetActive(false);

        // 아이템 생성
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
        // Resources 폴더에 있는 해당 이름의 이미지를 로드합니다.
        Sprite itemSprite = Resources.Load<Sprite>("Items/" + itemNames);

        // 새로운 아이템 GameObject를 생성하고 ItemPanel에 추가합니다.
        GameObject newItem = new GameObject(itemNames);
        newItem.transform.SetParent(itemPanel.transform, false);

        // 아이템의 이미지를 추가합니다.
        Image itemImage = newItem.AddComponent<Image>();
        itemImage.sprite = itemSprite;

        // 아이템을 클릭했을 때의 동작을 설정합니다.
        Button itemButton = newItem.AddComponent<Button>();
        itemButton.onClick.AddListener(() => OnItemClick(itemNames));
    }

    void OnItemClick(string itemNames)
    {
        // 클릭된 아이템에 해당하는 팝업창을 활성화합니다.
        GameObject popUp = GameObject.Find("itemsImgPop/" + itemNames);
        if (popUp != null)
        {
            popUp.SetActive(true);
        }
    }


    // 아이템 장착 확인 팝업 표시 메소드
    void ShowEquipConfirmationPopup(string message, GameObject item)
    {
        selectedItem = item;
        Debug.Log(message + " 팝업을 표시합니다.");

        // 팝업창 활성화
        itemsImgPop.SetActive(true);
    }

    // 아이템 장착 상태 변경 메소드
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
