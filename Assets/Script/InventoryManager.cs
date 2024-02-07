using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject statusButton;
    public GameObject itemsImgPop; // 팝업창
   

 
    private GameObject selectedItem = null;

    void Start()
    {
        statusButton.SetActive(false);
        
    }

    void Update()
    {
       
    }

    // 아이템 클릭 시 호출되는 메소드
    public void OnItemClick(GameObject item)
    {
        selectedItem = item;
        itemsImgPop.SetActive(true); // 팝업창 활성화
        Itemslot itemslot = item.GetComponent<Itemslot>();
        // 아이템 슬롯에서 불러오기
        //이미지 팝업이랑 장착팝업 키기(set
        itemslot.PopUpImage.SetActive(true);// 팝업 이미지 키기
        itemslot.Image.SetActive(true); // 장착 이미지 키기

    }

    // 아이템 장착 상태 변경 메소드
  
}