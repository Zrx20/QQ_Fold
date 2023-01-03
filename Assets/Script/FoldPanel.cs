using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �۵��˵�
/// </summary>
public class FoldPanel : MonoBehaviour
{
    [SerializeField]
    private GameObject panelItem;//�۵�ҳ
    [SerializeField]
    private TitleItem titleItem;
    [SerializeField]
    private DataItem dataItem;

    public List<FoldData> dataList = new List<FoldData>();
    // Start is called before the first frame update
    void Start()
    {
        Create();
    }
    public void Create()
    {
        for (int i = 0; i < dataList.Count; i++)
        {
            //��������
            TitleItem title = Instantiate(titleItem).GetComponent<TitleItem>();
            title.SetTitle(dataList[i].titleName);
            title.transform.SetParent(this.transform);
            title.gameObject.SetActive(true);

            //�������۵����
            GameObject panel = Instantiate(panelItem);
            panel.transform.SetParent(this.transform);
            title.SetFoldPanel(panel);
            panel.SetActive(false);

            //�����۵�ҳ����
            for (int j = 0; j < dataList[i].data.Count; j++)
            {
                DataItem item = Instantiate(dataItem).GetComponent<DataItem>();
                item.transform.SetParent(panel.transform);
                item.gameObject.SetActive(true);
                item.SetInfo(dataList[i].data[j]);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class FoldData
{
    public string titleName;
    public List<ItemData> data;
}
[System.Serializable]
public class ItemData
{
    public string userName;
}

