using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject play;
    public void OnMouseDown()
    {
        Time.timeScale = 1;
        menuPanel.SetActive(false);

    }// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
