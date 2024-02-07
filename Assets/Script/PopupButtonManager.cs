using UnityEngine;
using UnityEngine.UI;

public class PopupButtonManager : MonoBehaviour
{
    public GameObject PopUpImage1;
    public GameObject PopUpImage2;
    public GameObject PopUpImage3;
    public GameObject PopUpImage4;

    public void OffButton1Click()
    {
        PopUpImage1.SetActive(false);
    }

    public void OffButton2Click()
    {
        PopUpImage2.SetActive(false);
    }

    public void OffButton3Click()
    {
        PopUpImage3.SetActive(false);
    }

    public void OffButton4Click()
    {
        PopUpImage4.SetActive(false);
    }
}
