using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject Play;

    public void OnMouseDown()
    {
        Time.timeScale = 0; //���� �Ͻ�����
        menuPanel.SetActive(true);

    }

    
}
