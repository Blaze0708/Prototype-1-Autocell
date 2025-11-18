using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocell_P1
{
    class Cell
    {


        private bool state;

        //contructor of the cell class - all cells are created dead
        public Cell()
        {
            state = false;
        }
        //public subroutine which changes the state of the cell by checking its current state, and changing it to the opposite
        public void changeState(Cell cell)
        {
            if (cell.state = true)
            {
                cell.state = false;
            }
            else
            {
                cell.state = true;
            }
        }

        public void checkAdajcentCells(Cell[,] grid)
        {
            int count = 0;
            int rows = grid.GetLength(1);
            int cols = grid.GetLength(0);
        }





    }
}