using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL
{
	public class Cell
	{
		public bool isLive;
		public bool willLive;
		public readonly List<Cell> Neighbors;
		
		public Cell() {
			Neighbors = new List<Cell>();
		}//constructor()
		
		public void SetNextState() { 
			isLive = willLive; 
		}
		
		public void GetNextState() {
			/// <Rules>
			/// 1. Any live cell with two or three live neighbours survives.
            /// 2. Any dead cell with three live neighbours becomes a live cell.
            /// 3. All other live cells die in the next generation. Similarly, all other dead cells stay dead.
			/// </Rules>
			int LiveNeighbors = Neighbors.Where(x => x.isLive).Count();
			
			if (isLive) {
				//Cell remains alive if it has 2 or 3 live neighbors, else it dies
				willLive = (LiveNeighbors == 2) || (LiveNeighbors == 3);
			} else {
				//Dead cell is revived by its (3) neighbors, else it stays dead
				willLive = (LiveNeighbors == 3);	
			}
		}
	}//Cell

	public class Board 
	{
		public Cell[,] Cells;
		public int col { get { return Cells.GetLength(0); } }
        public int row { get { return Cells.GetLength(1); } }
        public int Wd { get { return col * Size; } }
        public int Ht { get { return row * Size; } }
		public int Size;

        public Board(int w, int h, int s) {
            Cells = new Cell[w/s, h/s];
			Size = s;
            
			for (int x = 0; x < col; x++)
                for (int y = 0; y < row; y++)
                    Cells[x,y] = new Cell();

            SetNeighbors();
        }//constructor()
		

		private void SetNeighbors() {
            for (int x = 0; x < col; x++) {
                for (int y = 0; y < row; y++) {
                    //Cell [x,y] is: LEFT       TOP       RIGHT            BOTTOM
                    bool EdgeCell = x == 0 || y == 0 || x == col - 1 || y == row - 1;
                    int left = (x == 0) ? col - 1 : x - 1;			//
                    int right = (x == col-1) ? 0 : x + 1;			// Get the surrounding coords
                    int above = (y == 0) ? row - 1 : y - 1;			//
                    int below = (y == row-1) ? 0 : y + 1;			//

                    Cells[x,y].Neighbors.Add(Cells[left, y]);		//Neighbor to the left
                    Cells[x,y].Neighbors.Add(Cells[right, y]);		//   "     to the right
                    Cells[x,y].Neighbors.Add(Cells[x, above]);		//
                    Cells[x,y].Neighbors.Add(Cells[left, above]);	//Neighbors in row above
                    Cells[x,y].Neighbors.Add(Cells[right, above]);	//
                    Cells[x,y].Neighbors.Add(Cells[x, below]);		//
                    Cells[x,y].Neighbors.Add(Cells[left, below]);	//Neighbors in row below
                    Cells[x,y].Neighbors.Add(Cells[right, below]);	//
                }
            }
        }

        public void SetNextState() {
            foreach (Cell cell in Cells)
                cell.GetNextState();
            foreach (Cell cell in Cells)
                cell.SetNextState();
        }

		public void Randomize(double crowd = 0.15) {
			Random R = new Random();
            foreach (Cell cell in Cells) 
                cell.isLive = R.NextDouble() < crowd;
				//Random cells fill 15.0% of the board.
        }
	}//Board
}
