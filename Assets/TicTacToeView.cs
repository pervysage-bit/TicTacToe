using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeView : MonoBehaviour
{
    public int rows;
    public int cols;
    public float horizontalSpacing = 1.5f;
    public float verticalSpacing = 1.5f;
    public TicTacToeGrid TTTGrid;
    public GameObject cube;
    public List<List<UnityCell>> cellView;
    int counter;


    public TicTacToeView(int rows , int cols)
    {
        this.rows = rows;
        this.cols = cols;
    }

    void Start()
    {
        //cellView = new List<List<UnityCell>>();
        IntializedGrid();
    }

    public void IntializedGrid()
    {
        TTTGrid = new TicTacToeGrid(rows, cols);
        TTTGrid.onCellCreated += InstantiateTest;
        TTTGrid.IntializedCell();
    }
    public void InstantiateTest(Cell cell) // cell created function
    {
        TransformPosition();
        GameObject temp = Instantiate(cube, new Vector3(horizontalSpacing ,0 , verticalSpacing) , cube.transform.rotation);
        counter++;
        temp.GetComponent<UnityCell>().SetCell(cell);
    }

    void TransformPosition()
    {
        if(counter == rows)
        {
            verticalSpacing += 1.5f;
            counter = 0;
            horizontalSpacing = 1.5f;
        }
        else
        {
            horizontalSpacing += 1.5f;
        }
    }
}