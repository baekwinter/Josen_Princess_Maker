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
        isEquipped = !isEquipped; // ���� ���� ������ �ݴ�� ����

        // ���� ���¿� ���� �̹����� Ȱ��ȭ �Ǵ� ��Ȱ��ȭ
        Image.SetActive(!isEquipped);
        PopUpImage.SetActive(isEquipped);
    }
    //�������� �ߴ� �˾� 
    // ��������
    //bool���� �̿��� ������ ���� ���� �Ǻ� setactive
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
