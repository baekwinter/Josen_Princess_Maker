using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemslot : MonoBehaviour
{
    public GameObject PopUpImage;
    public GameObject Image;

    private bool isEquipped = false;

    public void ToggleEquipStatus()
    {
        isEquipped = !isEquipped; // 현재 장착 상태의 반대로 변경

        // 장착 상태에 따라 이미지를 활성화 또는 비활성화
        Image.SetActive(!isEquipped);
        PopUpImage.SetActive(isEquipped);
    }
    //눌렀을때 뜨는 팝업 
    // 장착여부
    //bool값을 이용한 아이템 장착 여부 판별 setactive
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleEquipStatus();
        }
    }
}
