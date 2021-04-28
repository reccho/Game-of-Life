using System;
using System.Drawing;
using System.Windows.Forms;

namespace GoL
{
	public partial class Form1 : Form
	{
        Patterns BigBook;
		Board board;
        Board backup;
        Color cellColor;
        int generation;
        string SHAPE;
        bool RUNNING;
        Size size;

		public Form1() {
			InitializeComponent();
			cellColor = Color.LightBlue;
            Bttn_Run.Enabled = false;
            timer1.Enabled = true;
            RUNNING = true;
            SHAPE = ".";
            
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            BigBook = new Patterns();
            rBttn_Cell.Checked = true;
            Reset();
		}//constructor()
        
        private void timer1_Tick_1(object sender, EventArgs e) {
            board.SetNextState();   //set next state of board
            generation++;           //count next generation
            DrawBoard();            //Update board visually
		}

        #region GUI Interactions
        //
		private void Bttn_Run_Click(object sender, EventArgs e) {
            RUNNING = true;
			timer1.Enabled = true;
			Bttn_Run.Enabled = false;
			Bttn_Pause.Enabled = true;
		}

		private void Bttn_Pause_Click(object sender, EventArgs e) {
            RUNNING = false;
			timer1.Enabled = false;
			Bttn_Run.Enabled = true;
			Bttn_Pause.Enabled = false;
		}
        
        private void Bttn_Clear_Click(object sender, EventArgs e) {
            board = new Board(pictureBox1.Width, pictureBox1.Height, (int)UpDown_Size.Value);
            board.Randomize(0.00);  //Randomize w/ 0 live cells --> empty board
            
            Bttn_Run.Enabled = true;
            Bttn_Pause.Enabled = false;
            timer1.Enabled = false;
            generation = 0;     //reset generation counter
            DrawBoard();        //refresh board
		}

		private void Combo_Color_SelectedIndexChanged(object sender, EventArgs e) {
			string selected = Combo_Color.Text;     //Selected Color
			cellColor = Color.FromName(selected);   //Set color
            DrawBoard();                            //Refresh board
		}
        
        private void Combo_Preset_SelectedIndexChanged(object sender, EventArgs e) {
            string selected = Combo_Preset.Text;        //Selected list item
            string pattern = BigBook.Fetch(selected);   //corresponding pattern
            Bttn_Pause.Enabled = false;
            Bttn_Run.Enabled = true;
            timer1.Enabled = false;
            RUNNING = false;
            Reset(pattern);                             //Apply pattern
		}

		private void UpDown_Delay_ValueChanged(object sender, EventArgs e) {
            timer1.Interval = (int)UpDown_Delay.Value;
		}

        private void check_Grid_CheckedChanged(object sender, EventArgs e) { 
            DrawBoard(); 
        }

        private void tool_Save_Click(object sender, EventArgs e) {
            backup = board;
		}

		private void tool_Load_Click(object sender, EventArgs e) {
            if (backup != null) board = backup;
            DrawBoard();
		}
        
        private void tool_Info_Click(object sender, EventArgs e) {
            Form_Info Info = new Form_Info();
            Info.Show();
		}

        void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.S) {      // Ctrl-S Save
                tool_Save.PerformClick();
                tool_Save.BackColor = Color.LightGray;
            } else if (e.Control && e.KeyCode == Keys.L) {  // Ctrl-L Load
                tool_Load.PerformClick();
                tool_Load.BackColor = Color.LightGray;
			} else if (e.Control && e.KeyCode == Keys.I) {  // Ctrl+I Info
                tool_Info.PerformClick();
                tool_Info.BackColor = Color.LightGray;
			}

            //Reset button colors
            System.Threading.Thread.Sleep(0010);
            tool_Save.BackColor = toolStrip1.BackColor;
            tool_Load.BackColor = toolStrip1.BackColor;
            tool_Info.BackColor = toolStrip1.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var mouseArgs = (MouseEventArgs)e; // coordinates are now available in mouseArgs.X and mouseArgs.Y
            Bttn_Run.Enabled = true;
            Bttn_Pause.Enabled = false;
            timer1.Enabled = false;
            RUNNING = false;
            
            int X = mouseArgs.X / board.Size;   //Adjust for pixel size
            int Y = mouseArgs.Y / board.Size;
            
            DrawShape(X, Y);
            DrawBoard();
		}

        //Reset() buttons
		private void pictureBox1_SizeChanged(object sender, EventArgs e) { Reset(); }
        private void UpDown_Size_ValueChanged(object sender, EventArgs e) { Reset(); }
		private void Bttn_Randomize_Click(object sender, EventArgs e) { Reset(); }

        //SHAPE BUTTONS
        // These buttons all set the SHAPE variable, 
        // which tells DrawShape() which shape to draw.
        private void rBttn_Cell_CheckedChanged(object sender, EventArgs e) {
            SHAPE = ".";
		}
        private void rBttn_Block_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "block";
		}
        private void rBttn_Tub_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "tub";
		}
        private void rBttn_Beehive_CheckedChanged(object sender, EventArgs e)
		{
            SHAPE = "beehive";
		}
		private void rBttn_Loaf_CheckedChanged(object sender, EventArgs e)
		{
            SHAPE = "loaf";
		}
		private void rBttn_Boat_CheckedChanged(object sender, EventArgs e)
		{
            SHAPE = "boat";
		}
        private void rBttn_Blinker_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "blinker";
		}
        private void rBttn_Toad_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "toad";
		}
        private void rBttn_Beacon_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "beacon";
		}
		private void rButton_Pulsar_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "pulsar";
		}
		private void rBttn_PentaD_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "pentaD";
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "glider";
		}
		private void rBttn_LShip_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "lightShip";
		}
		private void rBttn_MShip_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "medShip";
		}
		private void rBttn_HShip_CheckedChanged(object sender, EventArgs e) {
            SHAPE = "heavyShip";
		}
        //
        #endregion
        
		#region Board Functions
        //
		private void DrawBoard() {
            SolidBrush brush = new SolidBrush(cellColor);   //Paintbrush
            Bitmap bmp = new Bitmap(board.Wd, board.Ht);    //Bitmap of cells
            Graphics gfx = Graphics.FromImage(bmp);         //Drawing surface
            gfx.Clear(Color.Black);                     //start w/ empty board
            
            //Set size of squares (little smaller if grid lines are ON)
            if (check_Grid.Checked && board.Size > 1)
                size = new Size(board.Size - 1, board.Size - 1);
			else size = new Size(board.Size, board.Size);

            for (int col = 0; col < board.col; col++) {
                for (int row = 0; row < board.row; row++) {
                    Cell cell = board.Cells[col, row];
                    if (cell.isLive) {  //Draw+Fill square at location of live cells
                        Point coord = new Point(col * board.Size, row * board.Size);
                        Rectangle square = new Rectangle(coord, size);
                        gfx.FillRectangle(brush, square);
                    }
                }
            }
            
            //Display current generation
            label_Gen.Text = "Generation: " + generation.ToString().PadLeft(6, '0');
            label_Gen.Update();
            
            //Cleanup
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = (Bitmap)bmp.Clone();
            gfx.Dispose();
            bmp.Dispose();
            brush.Dispose();
        }

        private void DrawShape(int X, int Y) {
            try { 
                //This sets cells live according to the specified shape, based on the cursor location.
                switch(SHAPE) {
                case ".": //One cell, no shape boxes checked
                    if (board.Cells[X,Y].isLive) board.Cells[X,Y].isLive = false;
                    else board.Cells[X,Y].isLive = true;
                    break;
                case "block": //4x4 square
                    try { 
                        board.Cells[X,Y].isLive = true;
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X-1,Y-1].isLive = true;
                    } catch { break; }                
                    break;
                case "tub":
                    try { 
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X,Y-1].isLive = true;
                    } catch { break; }               
                    break;
                case "beehive":
                    try { 
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                        board.Cells[X-1,Y-1].isLive = true;
                    } catch { break; }               
                    break;
                case "loaf":
                    try { 
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X-1,Y-1].isLive = true;
                        board.Cells[X+1,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                        board.Cells[X,Y+2].isLive = true;
                    } catch { break; }               
                    break;
                case "boat": 
                    try { 
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X-1,Y-1].isLive = true;
                    } catch { break; }               
                    break;
                case "blinker": 
                    try { 
                        board.Cells[X,Y].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                    } catch { break; }               
                    break;
                case "toad": 
                    try { 
                        board.Cells[X,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X+1,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                    } catch { break; }               
                    break;
                case "beacon": 
                    try { 
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X-2,Y-1].isLive = true;
                        board.Cells[X-1,Y-1].isLive = true;
                        board.Cells[X+1,Y+1].isLive = true;
                        board.Cells[X,Y+2].isLive = true;
                        board.Cells[X+1,Y+2].isLive = true;
                    } catch { break; }               
                    break;
                case "pulsar": 
                    try { 
                        //Quadrant 1
                        board.Cells[X+1,Y-2].isLive = true;
                        board.Cells[X+1,Y-3].isLive = true;
                        board.Cells[X+1,Y-4].isLive = true;
                        board.Cells[X+2,Y-1].isLive = true;
                        board.Cells[X+2,Y-6].isLive = true;
                        board.Cells[X+3,Y-1].isLive = true;
                        board.Cells[X+3,Y-6].isLive = true;
                        board.Cells[X+4,Y-1].isLive = true;
                        board.Cells[X+4,Y-6].isLive = true;
                        board.Cells[X+6,Y-2].isLive = true;
                        board.Cells[X+6,Y-3].isLive = true;
                        board.Cells[X+6,Y-4].isLive = true;
                        //Quadrant 2
                        board.Cells[X-1,Y-2].isLive = true;
                        board.Cells[X-1,Y-3].isLive = true;
                        board.Cells[X-1,Y-4].isLive = true;
                        board.Cells[X-2,Y-1].isLive = true;
                        board.Cells[X-2,Y-6].isLive = true;
                        board.Cells[X-3,Y-1].isLive = true;
                        board.Cells[X-3,Y-6].isLive = true;
                        board.Cells[X-4,Y-1].isLive = true;
                        board.Cells[X-4,Y-6].isLive = true;
                        board.Cells[X-6,Y-2].isLive = true;
                        board.Cells[X-6,Y-3].isLive = true;
                        board.Cells[X-6,Y-4].isLive = true;
                        //Quadrant 3
                        board.Cells[X-1,Y+2].isLive = true;
                        board.Cells[X-1,Y+3].isLive = true;
                        board.Cells[X-1,Y+4].isLive = true;
                        board.Cells[X-2,Y+1].isLive = true;
                        board.Cells[X-2,Y+6].isLive = true;
                        board.Cells[X-3,Y+1].isLive = true;
                        board.Cells[X-3,Y+6].isLive = true;
                        board.Cells[X-4,Y+1].isLive = true;
                        board.Cells[X-4,Y+6].isLive = true;
                        board.Cells[X-6,Y+2].isLive = true;
                        board.Cells[X-6,Y+3].isLive = true;
                        board.Cells[X-6,Y+4].isLive = true;
                        //Quadrant 4
                        board.Cells[X+1,Y+2].isLive = true;
                        board.Cells[X+1,Y+3].isLive = true;
                        board.Cells[X+1,Y+4].isLive = true;
                        board.Cells[X+2,Y+1].isLive = true;
                        board.Cells[X+2,Y+6].isLive = true;
                        board.Cells[X+3,Y+1].isLive = true;
                        board.Cells[X+3,Y+6].isLive = true;
                        board.Cells[X+4,Y+1].isLive = true;
                        board.Cells[X+4,Y+6].isLive = true;
                        board.Cells[X+6,Y+2].isLive = true;
                        board.Cells[X+6,Y+3].isLive = true;
                        board.Cells[X+6,Y+4].isLive = true;
                    } catch { break; }               
                    break;
                case "pentaD": 
                    try { 
                        board.Cells[X,Y].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X-3,Y+1].isLive = true;
                        board.Cells[X-3,Y-1].isLive = true;
                        board.Cells[X-4,Y].isLive = true;
                        board.Cells[X-5,Y].isLive = true;
                        board.Cells[X+2,Y-1].isLive = true;
                        board.Cells[X+2,Y+1].isLive = true;
                        board.Cells[X+3,Y].isLive = true;
                        board.Cells[X+4,Y].isLive = true;
                    } catch { break; }               
                    break;
                case "glider": 
                    try { 
                        board.Cells[X,Y].isLive = true;
                        board.Cells[X-1,Y-1].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                    } catch { break; }               
                    break;
                case "lightShip": 
                    try { 
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X+1,Y-1].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X+2,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X+1,Y+1].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                        board.Cells[X-2,Y+1].isLive = true;
                        board.Cells[X-1,Y+2].isLive = true;
                        board.Cells[X,Y+2].isLive = true;
                    } catch { break; }               
                    break;
                case "medShip": 
                    try { 
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X+1,Y-1].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X+2,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X+1,Y+1].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                        board.Cells[X-2,Y+1].isLive = true;
                        board.Cells[X-1,Y+2].isLive = true;
                        board.Cells[X,Y+2].isLive = true;
                        board.Cells[X-3,Y].isLive = true;
                        board.Cells[X-3,Y+1].isLive = true;
                        board.Cells[X-2,Y+2].isLive = true;
                    } catch { break; }               
                    break;
                case "heavyShip": 
                    try { 
                        board.Cells[X,Y-1].isLive = true;
                        board.Cells[X+1,Y-1].isLive = true;
                        board.Cells[X+1,Y].isLive = true;
                        board.Cells[X+2,Y].isLive = true;
                        board.Cells[X-1,Y].isLive = true;
                        board.Cells[X-2,Y].isLive = true;
                        board.Cells[X+1,Y+1].isLive = true;
                        board.Cells[X,Y+1].isLive = true;
                        board.Cells[X-1,Y+1].isLive = true;
                        board.Cells[X-2,Y+1].isLive = true;
                        board.Cells[X-1,Y+2].isLive = true;
                        board.Cells[X,Y+2].isLive = true;
                        board.Cells[X-3,Y].isLive = true;
                        board.Cells[X-3,Y+1].isLive = true;
                        board.Cells[X-2,Y+2].isLive = true;
                        board.Cells[X-4,Y].isLive = true;
                        board.Cells[X-4,Y+1].isLive = true;
                        board.Cells[X-3,Y+2].isLive = true;
                    } catch { break; }               
                    break;
                default:
                    break;
			}
		    } catch {
                //Drew Out of Bounds of Bitmap/Array (do nothing)
            }
        }

        private void Reset(string preset) {
            string[] lines = preset.Split('\n');            //Turn string into array of lines
            int coordY = (board.row - lines.Length) / 2;
            int coordX = (board.col - lines[0].Length) / 2;
            Reset(false);
            for (int y = 0; y < lines.Length; y++)          // These loops set cells live if they 
                for (int x = 0; x < lines[y].Length; x++)   // correspond to a '+' in the starting pattern.
                    board.Cells[x + coordX, y + coordY].isLive = lines[y].Substring(x, 1) == "+";
            generation = 0; //Reset generation counter
            DrawBoard();
        }

        private void Reset(bool randomize = true) {
            board = new Board(pictureBox1.Width, pictureBox1.Height, (int)UpDown_Size.Value);
            if (randomize) board.Randomize();
            generation = 0;
            DrawBoard();
        }
		//
		#endregion
	}
}
