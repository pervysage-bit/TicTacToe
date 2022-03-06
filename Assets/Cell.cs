public class Cell
{
    int row;
    int col;
    Status status;

    public delegate void StatusUpdated(Status status);
    public StatusUpdated statusUpdated;

    public delegate void OnCellInteration(int row, int col);
    public OnCellInteration onCellInteration;


    

    public Cell()
    {
        status = Status.none;
        row = 0;
        col = 0;

    }
    public Cell(int row, int col)
    {
        status = Status.none;
        this.row = row;
        this.col= col;
    }


    
    public void SetStatus(Status status)
    {
        this.status = status;
        statusUpdated?.Invoke(status);
    }

    public Status GetStatus()
    {
        return status;
    }
    public void SetRow(int r)
    {
        this.row = r;
    }
    public int GetRow()
    {
        return row;
    }

    public void SetCol(int c)
    {
        this.col = c;
    }
    public int GetCol()
    {
        return col;
    }

    public void CellInteration()
    {     
        onCellInteration?.Invoke(row, col);
    }

    public enum Status { none, circle, cross, win, loose }
}