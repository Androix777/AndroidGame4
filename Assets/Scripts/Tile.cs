using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour
{
    public GameObject selectTowerPanel;
    bool withTower = false;

    private GameObject manager;
    private BuidTowerManager BuidTowerManager;
    private UIManager UIManager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager");
        BuidTowerManager = manager.GetComponent<BuidTowerManager>();
        UIManager = manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (!withTower)
            {
                UIManager.SelectTowerPanel(true);
                BuidTowerManager.SelectedTile = this;
            }
        }
    }

    public void BuildTower(int num)
    {
        Instantiate(BuidTowerManager.Towers[num], this.transform.position + new Vector3(0,0,1), Quaternion.identity);
        withTower = true;
    }

    public void BuildTower(GameObject tower)
    {
        Instantiate(tower, this.transform.position + new Vector3(0, 0, 1), Quaternion.identity);
        withTower = true;
    }
}
