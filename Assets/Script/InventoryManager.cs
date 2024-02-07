using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject statusButton;
    public GameObject itemsImgPop; // �˾�â
   

 
    private GameObject selectedItem = null;

    void Start()
    {
        statusButton.SetActive(false);
        
    }

    void Update()
    {
       
    }

    // ������ Ŭ�� �� ȣ��Ǵ� �޼ҵ�
    public void OnItemClick(GameObject item)
    {
        selectedItem = item;
        itemsImgPop.SetActive(true); // �˾�â Ȱ��ȭ
        Itemslot itemslot = item.GetComponent<Itemslot>();
        // ������ ���Կ��� �ҷ�����
        //�̹��� �˾��̶� �����˾� Ű��(set
        itemslot.PopUpImage.SetActive(true);// �˾� �̹��� Ű��
        itemslot.Image.SetActive(true); // ���� �̹��� Ű��

    }

    // ������ ���� ���� ���� �޼ҵ�
  
}