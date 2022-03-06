using System.Collections.Generic;
using UnityEngine;

public class Matrices
{
    protected int rows;
    protected int columns;
    protected List<List<int>> matrix;
    private List<List<int>> solutionOfMatrix;

    private List<int> columnList;
    private int[,] array2d;

    public Matrices(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        MakeMatrix(rows, columns);
        setMatrix();
    }

    private void MakeMatrix(int rows, int columns)
    {
        array2d = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {

            for (int j = 0; j < columns; j++)
            {
                array2d[i, j] = 0;
            }
        }
    }

    private int[,] getArray2d()
    {
        return array2d;
    }

    private void setMatrix()
    {
        matrix = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            columnList = new List<int>();
            for (int j = 0; j < columns; j++)
            {
                columnList.Add(array2d[i, j]);
            }
            matrix.Add(columnList);
        }
    }

    public void setElementsInMatrix(int row, int column, int number)
    {
        matrix[row][column] = number;
    }
    public int getElementInMatrix(int row, int column)
    {
        int returnElement;
        returnElement = matrix[row][column];
        return returnElement;
    }

    public void printMatrix()
    {
        string displayString = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                displayString += matrix[i][j];
                //Debug.Log(matrix[i][j]);
            }
            displayString += '\n';
        }
        Debug.Log(displayString);
    }

    public void printSum(Matrices matrix1, Matrices matrix2)
    {
        
        if (matrix1.rows == matrix2.rows && matrix1.columns == matrix2.columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Debug.Log(SumOfMatrix(matrix1, matrix2)[i][j]);
                }
            }
        }
        else
            Debug.Log("Can't Add");

    }

    private List<List<int>> SumOfMatrix(Matrices matrix1, Matrices matrix2)
    {

        solutionOfMatrix = new List<List<int>>();
        for (int i = 0; i <= rows - 1; i++)
        {
            columnList = new List<int>();
            for (int j = 0; j <= columns - 1; j++)
            {
                columnList.Add(matrix1.getElementInMatrix(i, j) + matrix2.getElementInMatrix(i, j));

            }
            solutionOfMatrix.Add(columnList);
        }

        return solutionOfMatrix;
    }
    private List<List<int>> DifferenceOfMatrix(Matrices matrix1, Matrices matrix2)
    {

        solutionOfMatrix = new List<List<int>>();
        for (int i = 0; i <= rows - 1; i++)
        {
            columnList = new List<int>();
            for (int j = 0; j <= columns - 1; j++)
            {
                columnList.Add(matrix1.getElementInMatrix(i, j) - matrix2.getElementInMatrix(i, j));

            }
            solutionOfMatrix.Add(columnList);

        }

        return solutionOfMatrix;
    }

    public void printDifference(Matrices matrix1, Matrices matrix2)
    {
        if (matrix1.rows == matrix2.rows && matrix1.columns == matrix2.columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Debug.Log(DifferenceOfMatrix(matrix1, matrix2)[i][j]);
                }
            }
        }
        else
            Debug.Log("Can't subtract");

    }

    //public void SwappingRows(Matrices matrix, int row, int swaprow)
    //{
    //    swappedRowMatrix = new List<List<int>>();
    //    swappedRowMatrix = matrix.matrix;
    //    List<int> dummyRow = new List<int>();
    //    dummyRow = swappedRowMatrix[row];

    //    swappedRowMatrix[row] = swappedRowMatrix[swaprow];
    //    swappedRowMatrix[swaprow] = dummyRow;

    //    for (int i = 0; i < matrix.rows; i++)
    //    {
    //        for (int j = 0; j < matrix.columns; j++)
    //        {
    //            Debug.Log(swappedRowMatrix[i][j]);
    //        }
    //    }
    //}
    public void SwapRow(int r1, int r2)
    {
        if(r1 < rows && r2 < rows)
        {
            for(int x = 0; x < rows; x++)
            {
                int temp = matrix[r1][x];
                matrix[r1][x] = matrix[r2][x];
                matrix[r2][x] = temp;
            }
        }
    }

    public void SwapCol(int c1, int c2)
    {
        if (c1 < columns && c2 < columns)
        {
            for (int x = 0; x < columns; x++)
            {
                int temp = matrix[x][c1];
                matrix[x][c1] = matrix[x][c2];
                matrix[x][c2] = temp;
            }
        }
    }

    public void setDiagnolMatrix(int num)
    {

        matrix = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            columnList = new List<int>();
            for (int j = 0; j < columns; j++)
            {
                if (i == j)
                    columnList.Add(getArray2d()[i, j] = num);
                else
                    columnList.Add(getArray2d()[i, j] = 0);
            }
            matrix.Add(columnList);
        }
    }
    public void InverseDiagnolMatrix(int num)
    {

        matrix = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            columnList = new List<int>();
            for (int j = columns - 1; j >= 0; j--)
            {
                if (j == i)
                    columnList.Add(getArray2d()[i, j] = num);
                else
                    columnList.Add(getArray2d()[i, j] = 0);
            }
            matrix.Add(columnList);
        }
    }
    public bool CheckDiagnolMatrix()
    {
        bool returnBool = false;
        int tempVar = matrix[0][0];
        for (int i = 0; i < rows; i++)
        {
            if (matrix[i][i] != tempVar)
                returnBool = false;
            else
                returnBool = true;
        }
        OnMatricesUpdate();
        return returnBool;
    }


    public bool IsColumnSame(int Colnum)
    {
        bool issame = false;
        if (Colnum < rows)
        {
            int a = matrix[0][Colnum];
            if (a != 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (a == matrix[i][Colnum])
                    {
                        issame = true;
                    }
                    else
                    {
                        issame = false;
                        break;
                    }
                }
            }
        }

        OnMatricesUpdate();
        return issame;        
    }

    public bool IsRowSame(int rownum)
    {
        bool issame = false;
        if (rownum < rows)
        {

            int a = matrix[rownum][0];
            if (a != 0)
            {
                for (int i = 0; i < columns; i++)
                {
                    if (a == matrix[rownum][i])
                    {
                        issame = true;
                    }
                    else
                    {
                        issame = false;
                        break;
                    }
                }
            }
        }
        OnMatricesUpdate();
        return issame;

       
    }
    public void SetRow(int row, int num)
    {
        for (int i = 0; i < columns; i++)
        {
            matrix[row][i] = num;
        }
    }
    public void SetColumn(int col, int num)
    {
        for (int i = 0; i < rows; i++)
        {
            matrix[i][col] = num;
        }
    }
    public bool CheckInverseDiagnolMatrix(Matrices matrix)
    {
        bool returnBool = false;
        int tempVar = matrix.matrix[0][0];
        for (int i = 0; i < matrix.rows; i++)
        {
            if (matrix.matrix[i][i] != tempVar)
                returnBool = false;
            else
                returnBool = true;
        }
        return returnBool;
    }

    public void MultiplyMatrices(Matrices matrix1, Matrices matrix2)
    {
        int sum = 0;
        solutionOfMatrix = new List<List<int>>();

        if (matrix1.matrix[0].Count == matrix2.matrix.Count)
        {

            for (int i = 0; i < matrix1.rows; i++)
            {

                for (int j = 0; j < matrix1.columns; j++)
                {
                    columnList = new List<int>();
                    for (int z = 0; z < matrix1.rows; z++)
                    {
                        sum = sum + matrix1.matrix[i][z] * matrix2.matrix[z][j];
                    }
                    columnList.Add(sum);
                    sum = 0;
                    solutionOfMatrix.Add(columnList);
                }

            }
            Debug.Log("multipliedTwoMatrices");

            for (int i = 0; i < solutionOfMatrix.Count; i++)
            {
                for (int j = 0; j < solutionOfMatrix[0].Count; j++)
                {
                    Debug.Log("Solution of Matrix =   " + solutionOfMatrix[i][j]);
                }
            }
        }
        else
        {
            Debug.LogWarning("cannot multiply");
        }

    }

    public virtual void OnMatricesUpdate()
    {

    }
}