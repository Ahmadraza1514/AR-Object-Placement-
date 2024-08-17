using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class ButtonManager : MonoBehaviour
{
    private Button btn;
    public GameObject furniture;


    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(OnSelect);
    }
    private void Update()
    {
        if (UIManager.Instance.OnEntered(gameObject))
        {
            transform.DOScale(Vector3.one * 2,0.2f);
        }
        else
        {
            transform.DOScale(Vector3.one, 0.2f);
        }
    }
    private void OnSelect()
    {
        DataHolder.instance.furniture = furniture;
    }
}
