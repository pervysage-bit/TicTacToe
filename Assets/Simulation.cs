using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    MatrixWithArray a1 = new MatrixWithArray(3, 3);
    int[,] newSetMatrix = new int[3, 3];

    // Start is called before the first frame update
    void Start()
    {
        a1.Print();

        newSetMatrix[0, 0] = 4;
        newSetMatrix[0, 1] = 2;
        newSetMatrix[0, 2] = 5;
        newSetMatrix[1, 0] = 7;
        newSetMatrix[1, 1] = 9;
        newSetMatrix[1, 2] = 1;
        newSetMatrix[2, 0] = 8;
        newSetMatrix[2, 1] = 6;
        newSetMatrix[2, 2] = 3;

        a1.SetMatrix(newSetMatrix);
        a1.Print();

    }

}
