using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeGrid : Matrices
{
    bool checkMatrixValue = false;
    bool checkWin = false;
    bool rowSame = false;
    bool columnSame = false;
    //bool diagnolSame = false;
    //bool matchDraw = false;
    bool gameFinished = false;

    List<List<Cell>> cellsGrid;

    public delegate void OnCellCreated(Cell cell);
    public OnCellCreated onCellCreated;

    Cell.Status currentTurn = Cell.Status.circle;


    public TicTacToeGrid(int rows, int columns) : base(rows, columns)
    {
        cellsGrid = new List<List<Cell>>();
    }

    public void IntializedCell()
    {       
        for(int r = 0; r < rows; r++)
        {
            cellsGrid.Add(new List<Cell>());
            for(int c=0; c < columns; c++)
            {
                Cell tempCell = new Cell(r, c);
                cellsGrid[r].Add(tempCell);
                onCellCreated?.Invoke(tempCell);
                tempCell.onCellInteration += CellStatusSetRequest;
            }   
        }
    }

    public void CellStatusSetRequest(int row, int col)
    {
        if (gameFinished == false)
        {
            if (checkWin == false)
            {
                if (getElementInMatrix(row, col) == 0)
                {
                    if ((int)currentTurn == (int)Cell.Status.circle)
                    {
                        setElementsInMatrix(row, col, (int)Cell.Status.cross);
                        cellsGrid[row][col].SetStatus(Cell.Status.circle);
                        cellsGrid[row][col].GetStatus();
                        Debug.Log("Next Turn: " + cellsGrid[row][col].GetStatus());
                        currentTurn = Cell.Status.cross;
                        CheckWinRows();
                        CheckWinColumns();
                    }
                    else if ((int)currentTurn == (int)Cell.Status.cross)
                    {
                        setElementsInMatrix(row, col, (int)Cell.Status.circle);
                        cellsGrid[row][col].SetStatus(Cell.Status.cross);
                        cellsGrid[row][col].GetStatus();
                        Debug.Log("Next Turn: " + cellsGrid[row][col].GetStatus());
                        currentTurn = Cell.Status.circle;
                        CheckWinRows();
                        CheckWinColumns();                                             
                    }                 
                }
                            
            }
            //else if (checkWin == true)
            //{

               
            //}
        }
    }
    public void CheckWinRows()
    {

       // Debug.LogError("checking ...  checkwinRows method");
        for (int i = 0; i < rows; i++)
        {            
            rowSame = IsRowSame(i);
            if (rowSame == true)
            {
                checkWin = true;
                SetRow(i, (int)Cell.Status.win);
                gameFinished = true;
                if ((int)currentTurn == (int)Cell.Status.circle)
                {
                    Debug.Log("Circle Won!");

                }
                else if ((int)currentTurn == (int)Cell.Status.cross)
                {
                    Debug.Log("Cross Won!");

                }
                OnMatricesUpdate();
                break;
            }
            else
            {
                checkWin = false;
            }
        }
      
    }
    public void CheckWinColumns()
    {
       // Debug.LogError("checking ...  checkwinColumns method");
        for (int i = 0; i < columns; i++)
        {
            {
                columnSame = IsColumnSame(i);
                if (columnSame == true)
                {
                    checkWin = true;
                    SetColumn(i, (int)Cell.Status.win);
                    gameFinished = true;
                    if ((int)currentTurn == (int)Cell.Status.circle)
                    {
                        Debug.Log("Circle Won!");

                    }
                    else if ((int)currentTurn == (int)Cell.Status.cross)
                    {
                        Debug.Log("Cross Won!");

                    }
                    OnMatricesUpdate();
                    break;
                }
                else
                {
                    checkWin = false;
                }
            }
        }
         
        
    }
     


        //diagnolSame = CheckDiagnolMatrix();
        //if (diagnolSame)
        //{
        //    checkWin = true;
        //    setDiagnolMatrix((int)Cell.Status.win);
        //    OnMatricesUpdate();
        //}
        //else
        //    checkWin = false;
    

    public void CheckingMatrix()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i][j] == 0)
                {
                    checkMatrixValue = false;
                    break;
                }
                else
                    checkMatrixValue = true;
            }
        }
    }

    public override void OnMatricesUpdate()
    {
        for(int x = 0; x < rows; x++)
        {
            for(int y = 0; y< columns; y++)
            {
                cellsGrid[x][y].SetStatus((Cell.Status)getElementInMatrix(x, y));
            }
        }
    }

}
