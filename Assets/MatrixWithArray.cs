using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixWithArray
{
    //int[] arrOfNum = { 2, 3, 4, 1, 5, 6, 3, 2, 12 };
    int numOfRows;
    int numOfCols;
    int rowSize;
    int colSize;


    int[,] a;
        //{
//   {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
//   {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
//   {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
//};



    //void InitializedArray()
    //{
    //    int[,] a = new int[0,0];
    //}
    public MatrixWithArray()
    {
        //InitializedArray();
    }

    public MatrixWithArray(int rows, int cols)
    {
        numOfRows = rows;
        numOfCols = cols;
        a = new int[numOfRows, numOfCols];   // Note: this will be filled with zeros!
    }

    public void SetMatrix(int[,] newArr2d)
    {
        newArr2d = a;    
    }


    public void Print()
    {     
        string displayString = "";
        for(int row = 0; row < numOfRows; row++)
        {
            for(int col = 0; col < numOfCols; col++)
            {
                displayString += a[row,col] + " ";
            }
            displayString += '\n';
        }
        Debug.Log(displayString);       
    }

    public void SetElement(int r , int c , int value)
    {
        if(r < numOfRows && c < numOfCols)
        {
            a[r,c] = value;
        }
        else
        {
            Debug.LogError("Cannot set matrix element");
        }
    }

    public int GetElement(int r, int c)
    {
        if(r < numOfRows && c< numOfCols)
        {
            return a[r, c];
        }
        else
        {
            Debug.LogError("Cannot Get matrix element");
            return 0;
        }
    }

    public void SetRow(int rowNum, int[] arr)
    {
        if(arr.Length == numOfRows && rowNum < numOfRows)
        {
            for(int x = 0; x< numOfRows; x++)
            {
                a[rowNum, x] = arr[x];
            }
        }
        else
        {
            Debug.LogError("Row cannot be set");
        }
    }

    public void SetCol(int colNum, int[] arr)
    {
        if (arr.Length == numOfCols && colNum < numOfRows)
        {
            for (int x = 0; x < numOfCols; x++)
            {
                a[x, colNum] = arr[x];
            }
        }
        else
        {
            Debug.LogError("Col cannot be set");
        }
    }

    public void SwapRow(int r1, int r2)
    {
        if(r1 < numOfRows && r2 < numOfRows)
        {
            for(int x = 0; x < numOfRows; x++)
            {
                int temp = a[r1, x];
                a[r1, x] = a[r2, x];
                a[r2, x] = temp;
            }

        }
        else
        {
            Debug.LogError("Rows cannot swaps");
        }
    }

    public void SwapCol(int c1, int c2)
    {
        if (c1 < numOfCols && c2 < numOfCols)
        {
            for (int x = 0; x < numOfCols; x++)
            {
                int temp = a[c1, x];
                a[c1, x] = a[c2, x];
                a[c2, x] = temp;
            }

        }
        else
        {
            Debug.LogError("Cols cannot swaps");
        }
    }

    public void SetAllElements(int num)
    {
        for(int row = 0; row <numOfRows; row++)
        {
            for(int col = 0; col< numOfCols; col++)
            {
                a[row, col] = num;
            }
        }
    }

}