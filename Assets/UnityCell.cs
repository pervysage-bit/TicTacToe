using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCell : MonoBehaviour
{
    public GameObject[] cellState;
    Cell cell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetStatus(Cell.Status status)
    {
        for(int i = 0; i < cellState.Length; i++)
        {
            if(i == (int)status)
            {
                cellState[i].SetActive(true);
            }
            else
            {
                cellState[i].SetActive(false);
            }
        }
    }
    public void SetCell(Cell cell)
    {      
        this.cell = cell;
    }

    public void OnMouseDown()
    {
        cell.statusUpdated += SetStatus;
        cell.CellInteration();
        //SetStatus(cell.GetStatus());
    }
}