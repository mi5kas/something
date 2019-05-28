using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttons : MonoBehaviour
{
    [SerializeField] string function;
    [SerializeField] GameObject[] forFunction;
    TextMeshPro component;
    // Start is called before the first frame update
    void Start()
    {
        component = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    private void OnMouseEnter()
    {
        component.color = new Color32(255, 255, 255, 255);
    }
    private void OnMouseExit()
    {
        component.color = new Color32(161, 161, 97, 255);
    }
    private void OnMouseDown()
    {
        Invoke(function, 0f);
    }
    void OpenSettings()
    {
        forFunction[0].GetComponent<Animator>().CrossFadeInFixedTime("flipAnim", 2f);
        forFunction[1].GetComponent<Animator>().CrossFadeInFixedTime("flipAnim", 2f);
        forFunction[2].SetActive(false);
        forFunction[3].SetActive(true);
    }
    void BackToMenu()
    {
        forFunction[0].GetComponent<Animator>().CrossFadeInFixedTime("Empty", 2f);
        forFunction[1].GetComponent<Animator>().CrossFadeInFixedTime("Empty", 2f);
    }
}
