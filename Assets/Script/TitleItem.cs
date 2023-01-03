using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class TitleItem : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    private Text title;
    public bool isFold = true;//ÊÇ·ñÕÛµþ×´Ì¬
    public Transform foldPanel;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isFold)
        {
            isFold = false;
            if (foldPanel != null)
            {
                foldPanel.gameObject.SetActive(true);
                foldPanel.DOScaleY(1, 0.1f);
            }
        }
        else
        {
            isFold = true;
            if (foldPanel != null)
            {
                foldPanel.DOScaleY(0, 0.1f).OnComplete(() =>
                 {
                     foldPanel.gameObject.SetActive(false);
                 });
            }
        }
    }
    public void SetTitle(string _titleName)
    {
        title.text = _titleName;
    }
    public void SetFoldPanel(GameObject panel)
    {
        foldPanel = panel.transform;
    }
}
