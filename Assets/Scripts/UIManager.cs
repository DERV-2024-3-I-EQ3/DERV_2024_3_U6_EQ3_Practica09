using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    void Start()
    {
        setPanelsActive(false);
    }

    void Update()
    {

    }

    public void setPanelsActive(bool active)
    {
        panel.SetActive(active);
    }
}
