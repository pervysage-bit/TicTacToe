using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    //private Matrices matrix1 = new Matrices(2, 2);
    //private Matrices matrix2 = new Matrices(2, 2);
    //private Matrices diagnolMatrix = new Matrices(5, 5);
    //private Matrices InverseDignolMatrix = new Matrices(3, 3);
    //private Matrices multiplyMatrices = new Matrices(2, 2);
    //private Matrices sumOfMatrices = new Matrices(2, 2);
    //private Matrices differenceOfMatrices = new Matrices(2, 2);

    private TicTacToeGrid cellCreated = new TicTacToeGrid(3,3);
    // Start is called before the first frame update
    void Start()
    {
        //matrix1.setElementsInMatrix(0, 0, 2);
        //matrix1.setElementsInMatrix(0, 1, 4);
        //matrix1.setElementsInMatrix(1, 0, 4);
        //matrix1.setElementsInMatrix(1, 1, 6);

        //matrix1.printMatrix();

        //matrix2.setElementsInMatrix(0, 0, 1);
        //matrix2.setElementsInMatrix(0, 1, 3);
        //matrix2.setElementsInMatrix(1, 0, 5);
        //matrix2.setElementsInMatrix(1, 1, 7);

        //matrix2.printMatrix();


        //diagnolMatrix.setDiagnolMatrix(1);
        //diagnolMatrix.printMatrix();

        //InverseDignolMatrix.InverseDiagnolMatrix(1);
        //InverseDignolMatrix.printMatrix();

        //sumOfMatrices.printSum(matrix1, matrix2);
        //differenceOfMatrices.printDifference(matrix1, matrix2);

        //multiplyMatrices.MultiplyMatrices(matrix1, matrix2);

        //matrix1.SwapRow(1, 0);
        //matrix1.printMatrix();

        cellCreated.IntializedCell();
        cellCreated.printMatrix();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
