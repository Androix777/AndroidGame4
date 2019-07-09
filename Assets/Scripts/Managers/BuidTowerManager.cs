using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuidTowerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] towers;
    public GameObject[] Towers { get => towers; }
    private Tile selectedTile;
    public Tile SelectedTile { get => selectedTile; set => selectedTile = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildTower(int num)
    {
        selectedTile.BuildTower(towers[num]);
    }

    public void BuildTower(GameObject tower)
    {
        selectedTile.BuildTower(tower);
    }
}
