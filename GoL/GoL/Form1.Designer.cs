
namespace GoL
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Bttn_Run = new System.Windows.Forms.Button();
			this.Bttn_Pause = new System.Windows.Forms.Button();
			this.Combo_Color = new System.Windows.Forms.ComboBox();
			this.label_Size = new System.Windows.Forms.Label();
			this.label_Delay = new System.Windows.Forms.Label();
			this.UpDown_Size = new System.Windows.Forms.NumericUpDown();
			this.UpDown_Delay = new System.Windows.Forms.NumericUpDown();
			this.label_Gen = new System.Windows.Forms.Label();
			this.Combo_Preset = new System.Windows.Forms.ComboBox();
			this.Bttn_Randomize = new System.Windows.Forms.Button();
			this.check_Grid = new System.Windows.Forms.CheckBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Bttn_Clear = new System.Windows.Forms.Button();
			this.label_StillLifes = new System.Windows.Forms.Label();
			this.label_Oscillators = new System.Windows.Forms.Label();
			this.label_Spaceships = new System.Windows.Forms.Label();
			this.rBttn_Cell = new System.Windows.Forms.RadioButton();
			this.rBttn_Block = new System.Windows.Forms.RadioButton();
			this.rBttn_Tub = new System.Windows.Forms.RadioButton();
			this.rBttn_Beehive = new System.Windows.Forms.RadioButton();
			this.rBttn_Loaf = new System.Windows.Forms.RadioButton();
			this.rBttn_Boat = new System.Windows.Forms.RadioButton();
			this.rBttn_Blinker = new System.Windows.Forms.RadioButton();
			this.rBttn_Toad = new System.Windows.Forms.RadioButton();
			this.rBttn_Beacon = new System.Windows.Forms.RadioButton();
			this.rButton_Pulsar = new System.Windows.Forms.RadioButton();
			this.rBttn_PentaD = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.rBttn_LShip = new System.Windows.Forms.RadioButton();
			this.rBttn_MShip = new System.Windows.Forms.RadioButton();
			this.rBttn_HShip = new System.Windows.Forms.RadioButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tool_Save = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tool_Load = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tool_Info = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.UpDown_Size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDown_Delay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// Bttn_Run
			// 
			this.Bttn_Run.Location = new System.Drawing.Point(12, 30);
			this.Bttn_Run.Name = "Bttn_Run";
			this.Bttn_Run.Size = new System.Drawing.Size(75, 23);
			this.Bttn_Run.TabIndex = 0;
			this.Bttn_Run.Text = "Run";
			this.Bttn_Run.UseVisualStyleBackColor = true;
			this.Bttn_Run.Click += new System.EventHandler(this.Bttn_Run_Click);
			// 
			// Bttn_Pause
			// 
			this.Bttn_Pause.Location = new System.Drawing.Point(95, 30);
			this.Bttn_Pause.Name = "Bttn_Pause";
			this.Bttn_Pause.Size = new System.Drawing.Size(75, 23);
			this.Bttn_Pause.TabIndex = 1;
			this.Bttn_Pause.Text = "Pause";
			this.Bttn_Pause.UseVisualStyleBackColor = true;
			this.Bttn_Pause.Click += new System.EventHandler(this.Bttn_Pause_Click);
			// 
			// Combo_Color
			// 
			this.Combo_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Combo_Color.FormattingEnabled = true;
			this.Combo_Color.Items.AddRange(new object[] {
            "LightBlue",
            "LightGreen",
            "LightCoral",
            "BurlyWood",
            "Crimson",
            "Orange",
            "Orchid",
            "White"});
			this.Combo_Color.Location = new System.Drawing.Point(180, 81);
			this.Combo_Color.Name = "Combo_Color";
			this.Combo_Color.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Combo_Color.Size = new System.Drawing.Size(139, 26);
			this.Combo_Color.TabIndex = 3;
			this.Combo_Color.Text = "Color";
			this.Combo_Color.SelectedIndexChanged += new System.EventHandler(this.Combo_Color_SelectedIndexChanged);
			// 
			// label_Size
			// 
			this.label_Size.AutoSize = true;
			this.label_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label_Size.Location = new System.Drawing.Point(22, 61);
			this.label_Size.Name = "label_Size";
			this.label_Size.Size = new System.Drawing.Size(70, 17);
			this.label_Size.TabIndex = 4;
			this.label_Size.Text = "Pixel size:";
			// 
			// label_Delay
			// 
			this.label_Delay.AutoSize = true;
			this.label_Delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label_Delay.Location = new System.Drawing.Point(2, 89);
			this.label_Delay.Name = "label_Delay";
			this.label_Delay.Size = new System.Drawing.Size(90, 17);
			this.label_Delay.TabIndex = 5;
			this.label_Delay.Text = "Interval (ms):";
			// 
			// UpDown_Size
			// 
			this.UpDown_Size.Location = new System.Drawing.Point(98, 59);
			this.UpDown_Size.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.UpDown_Size.Name = "UpDown_Size";
			this.UpDown_Size.Size = new System.Drawing.Size(60, 22);
			this.UpDown_Size.TabIndex = 6;
			this.UpDown_Size.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.UpDown_Size.ValueChanged += new System.EventHandler(this.UpDown_Size_ValueChanged);
			// 
			// UpDown_Delay
			// 
			this.UpDown_Delay.Location = new System.Drawing.Point(98, 87);
			this.UpDown_Delay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.UpDown_Delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.UpDown_Delay.Name = "UpDown_Delay";
			this.UpDown_Delay.Size = new System.Drawing.Size(60, 22);
			this.UpDown_Delay.TabIndex = 7;
			this.UpDown_Delay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.UpDown_Delay.ValueChanged += new System.EventHandler(this.UpDown_Delay_ValueChanged);
			// 
			// label_Gen
			// 
			this.label_Gen.AutoSize = true;
			this.label_Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Gen.Location = new System.Drawing.Point(176, 30);
			this.label_Gen.Name = "label_Gen";
			this.label_Gen.Size = new System.Drawing.Size(164, 20);
			this.label_Gen.TabIndex = 8;
			this.label_Gen.Text = "Generation: 0000000";
			// 
			// Combo_Preset
			// 
			this.Combo_Preset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.Combo_Preset.FormattingEnabled = true;
			this.Combo_Preset.Items.AddRange(new object[] {
            "OneRow",
            "GosperGun",
            "SimkinGun",
            "BlockLayer10",
            "BlockLayer5x5",
            "Cross2",
            "Crab",
            "CanadaGoose",
            "Brain",
            "B29",
            "Coeship",
            "BigGlider",
            "Copperhead",
            "Loafer",
            "Weekender",
            "Cloverleaf",
            "Hammerhead",
            "HoneyFarm",
            "..."});
			this.Combo_Preset.Location = new System.Drawing.Point(389, 34);
			this.Combo_Preset.Name = "Combo_Preset";
			this.Combo_Preset.Size = new System.Drawing.Size(134, 24);
			this.Combo_Preset.TabIndex = 9;
			this.Combo_Preset.Text = "Presets";
			this.Combo_Preset.SelectedIndexChanged += new System.EventHandler(this.Combo_Preset_SelectedIndexChanged);
			// 
			// Bttn_Randomize
			// 
			this.Bttn_Randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Bttn_Randomize.Location = new System.Drawing.Point(389, 62);
			this.Bttn_Randomize.Name = "Bttn_Randomize";
			this.Bttn_Randomize.Size = new System.Drawing.Size(134, 23);
			this.Bttn_Randomize.TabIndex = 10;
			this.Bttn_Randomize.Text = "Randomize";
			this.Bttn_Randomize.UseVisualStyleBackColor = true;
			this.Bttn_Randomize.Click += new System.EventHandler(this.Bttn_Randomize_Click);
			// 
			// check_Grid
			// 
			this.check_Grid.AutoSize = true;
			this.check_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.check_Grid.Location = new System.Drawing.Point(180, 53);
			this.check_Grid.Name = "check_Grid";
			this.check_Grid.Size = new System.Drawing.Size(139, 22);
			this.check_Grid.TabIndex = 11;
			this.check_Grid.Text = "Show Grid Lines";
			this.check_Grid.UseVisualStyleBackColor = true;
			this.check_Grid.CheckedChanged += new System.EventHandler(this.check_Grid_CheckedChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(12, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1038, 466);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Bttn_Clear
			// 
			this.Bttn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Bttn_Clear.Location = new System.Drawing.Point(389, 86);
			this.Bttn_Clear.Name = "Bttn_Clear";
			this.Bttn_Clear.Size = new System.Drawing.Size(134, 23);
			this.Bttn_Clear.TabIndex = 12;
			this.Bttn_Clear.Text = "Clear";
			this.Bttn_Clear.UseVisualStyleBackColor = true;
			this.Bttn_Clear.Click += new System.EventHandler(this.Bttn_Clear_Click);
			// 
			// label_StillLifes
			// 
			this.label_StillLifes.AutoSize = true;
			this.label_StillLifes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label_StillLifes.Location = new System.Drawing.Point(543, 36);
			this.label_StillLifes.Name = "label_StillLifes";
			this.label_StillLifes.Size = new System.Drawing.Size(84, 20);
			this.label_StillLifes.TabIndex = 14;
			this.label_StillLifes.Text = "Still Lifes:";
			// 
			// label_Oscillators
			// 
			this.label_Oscillators.AutoSize = true;
			this.label_Oscillators.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label_Oscillators.Location = new System.Drawing.Point(532, 61);
			this.label_Oscillators.Name = "label_Oscillators";
			this.label_Oscillators.Size = new System.Drawing.Size(95, 20);
			this.label_Oscillators.TabIndex = 15;
			this.label_Oscillators.Text = "Oscillators:";
			// 
			// label_Spaceships
			// 
			this.label_Spaceships.AutoSize = true;
			this.label_Spaceships.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label_Spaceships.Location = new System.Drawing.Point(526, 83);
			this.label_Spaceships.Name = "label_Spaceships";
			this.label_Spaceships.Size = new System.Drawing.Size(101, 20);
			this.label_Spaceships.TabIndex = 16;
			this.label_Spaceships.Text = "Spaceships:";
			// 
			// rBttn_Cell
			// 
			this.rBttn_Cell.AutoSize = true;
			this.rBttn_Cell.Location = new System.Drawing.Point(633, 37);
			this.rBttn_Cell.Name = "rBttn_Cell";
			this.rBttn_Cell.Size = new System.Drawing.Size(52, 21);
			this.rBttn_Cell.TabIndex = 18;
			this.rBttn_Cell.Text = "Cell";
			this.rBttn_Cell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rBttn_Cell.UseVisualStyleBackColor = true;
			this.rBttn_Cell.CheckedChanged += new System.EventHandler(this.rBttn_Cell_CheckedChanged);
			// 
			// rBttn_Block
			// 
			this.rBttn_Block.AutoSize = true;
			this.rBttn_Block.Checked = true;
			this.rBttn_Block.Location = new System.Drawing.Point(691, 37);
			this.rBttn_Block.Name = "rBttn_Block";
			this.rBttn_Block.Size = new System.Drawing.Size(63, 21);
			this.rBttn_Block.TabIndex = 17;
			this.rBttn_Block.TabStop = true;
			this.rBttn_Block.Text = "Block";
			this.rBttn_Block.UseVisualStyleBackColor = true;
			this.rBttn_Block.CheckedChanged += new System.EventHandler(this.rBttn_Block_CheckedChanged);
			// 
			// rBttn_Tub
			// 
			this.rBttn_Tub.AutoSize = true;
			this.rBttn_Tub.Location = new System.Drawing.Point(760, 37);
			this.rBttn_Tub.Name = "rBttn_Tub";
			this.rBttn_Tub.Size = new System.Drawing.Size(54, 21);
			this.rBttn_Tub.TabIndex = 19;
			this.rBttn_Tub.Text = "Tub";
			this.rBttn_Tub.UseVisualStyleBackColor = true;
			this.rBttn_Tub.CheckedChanged += new System.EventHandler(this.rBttn_Tub_CheckedChanged);
			// 
			// rBttn_Beehive
			// 
			this.rBttn_Beehive.AutoSize = true;
			this.rBttn_Beehive.Location = new System.Drawing.Point(820, 37);
			this.rBttn_Beehive.Name = "rBttn_Beehive";
			this.rBttn_Beehive.Size = new System.Drawing.Size(80, 21);
			this.rBttn_Beehive.TabIndex = 20;
			this.rBttn_Beehive.Text = "Beehive";
			this.rBttn_Beehive.UseVisualStyleBackColor = true;
			this.rBttn_Beehive.CheckedChanged += new System.EventHandler(this.rBttn_Beehive_CheckedChanged);
			// 
			// rBttn_Loaf
			// 
			this.rBttn_Loaf.AutoSize = true;
			this.rBttn_Loaf.Location = new System.Drawing.Point(906, 37);
			this.rBttn_Loaf.Name = "rBttn_Loaf";
			this.rBttn_Loaf.Size = new System.Drawing.Size(57, 21);
			this.rBttn_Loaf.TabIndex = 21;
			this.rBttn_Loaf.Text = "Loaf";
			this.rBttn_Loaf.UseVisualStyleBackColor = true;
			this.rBttn_Loaf.CheckedChanged += new System.EventHandler(this.rBttn_Loaf_CheckedChanged);
			// 
			// rBttn_Boat
			// 
			this.rBttn_Boat.AutoSize = true;
			this.rBttn_Boat.Location = new System.Drawing.Point(963, 37);
			this.rBttn_Boat.Name = "rBttn_Boat";
			this.rBttn_Boat.Size = new System.Drawing.Size(58, 21);
			this.rBttn_Boat.TabIndex = 22;
			this.rBttn_Boat.Text = "Boat";
			this.rBttn_Boat.UseVisualStyleBackColor = true;
			this.rBttn_Boat.CheckedChanged += new System.EventHandler(this.rBttn_Boat_CheckedChanged);
			// 
			// rBttn_Blinker
			// 
			this.rBttn_Blinker.AutoSize = true;
			this.rBttn_Blinker.Location = new System.Drawing.Point(633, 61);
			this.rBttn_Blinker.Name = "rBttn_Blinker";
			this.rBttn_Blinker.Size = new System.Drawing.Size(72, 21);
			this.rBttn_Blinker.TabIndex = 23;
			this.rBttn_Blinker.Text = "Blinker";
			this.rBttn_Blinker.UseVisualStyleBackColor = true;
			this.rBttn_Blinker.CheckedChanged += new System.EventHandler(this.rBttn_Blinker_CheckedChanged);
			// 
			// rBttn_Toad
			// 
			this.rBttn_Toad.AutoSize = true;
			this.rBttn_Toad.Location = new System.Drawing.Point(706, 61);
			this.rBttn_Toad.Name = "rBttn_Toad";
			this.rBttn_Toad.Size = new System.Drawing.Size(62, 21);
			this.rBttn_Toad.TabIndex = 24;
			this.rBttn_Toad.Text = "Toad";
			this.rBttn_Toad.UseVisualStyleBackColor = true;
			this.rBttn_Toad.CheckedChanged += new System.EventHandler(this.rBttn_Toad_CheckedChanged);
			// 
			// rBttn_Beacon
			// 
			this.rBttn_Beacon.AutoSize = true;
			this.rBttn_Beacon.Location = new System.Drawing.Point(774, 62);
			this.rBttn_Beacon.Name = "rBttn_Beacon";
			this.rBttn_Beacon.Size = new System.Drawing.Size(77, 21);
			this.rBttn_Beacon.TabIndex = 25;
			this.rBttn_Beacon.Text = "Beacon";
			this.rBttn_Beacon.UseVisualStyleBackColor = true;
			this.rBttn_Beacon.CheckedChanged += new System.EventHandler(this.rBttn_Beacon_CheckedChanged);
			// 
			// rButton_Pulsar
			// 
			this.rButton_Pulsar.AutoSize = true;
			this.rButton_Pulsar.Location = new System.Drawing.Point(857, 61);
			this.rButton_Pulsar.Name = "rButton_Pulsar";
			this.rButton_Pulsar.Size = new System.Drawing.Size(69, 21);
			this.rButton_Pulsar.TabIndex = 26;
			this.rButton_Pulsar.Text = "Pulsar";
			this.rButton_Pulsar.UseVisualStyleBackColor = true;
			this.rButton_Pulsar.CheckedChanged += new System.EventHandler(this.rButton_Pulsar_CheckedChanged);
			// 
			// rBttn_PentaD
			// 
			this.rBttn_PentaD.AutoSize = true;
			this.rBttn_PentaD.Location = new System.Drawing.Point(932, 62);
			this.rBttn_PentaD.Name = "rBttn_PentaD";
			this.rBttn_PentaD.Size = new System.Drawing.Size(76, 21);
			this.rBttn_PentaD.TabIndex = 27;
			this.rBttn_PentaD.Text = "PentaD";
			this.rBttn_PentaD.UseVisualStyleBackColor = true;
			this.rBttn_PentaD.CheckedChanged += new System.EventHandler(this.rBttn_PentaD_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(633, 84);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(67, 21);
			this.radioButton1.TabIndex = 28;
			this.radioButton1.Text = "Glider";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rBttn_LShip
			// 
			this.rBttn_LShip.AutoSize = true;
			this.rBttn_LShip.Location = new System.Drawing.Point(706, 84);
			this.rBttn_LShip.Name = "rBttn_LShip";
			this.rBttn_LShip.Size = new System.Drawing.Size(92, 21);
			this.rBttn_LShip.TabIndex = 29;
			this.rBttn_LShip.Text = "Light Ship";
			this.rBttn_LShip.UseVisualStyleBackColor = true;
			this.rBttn_LShip.CheckedChanged += new System.EventHandler(this.rBttn_LShip_CheckedChanged);
			// 
			// rBttn_MShip
			// 
			this.rBttn_MShip.AutoSize = true;
			this.rBttn_MShip.Location = new System.Drawing.Point(804, 84);
			this.rBttn_MShip.Name = "rBttn_MShip";
			this.rBttn_MShip.Size = new System.Drawing.Size(110, 21);
			this.rBttn_MShip.TabIndex = 30;
			this.rBttn_MShip.Text = "Medium Ship";
			this.rBttn_MShip.UseVisualStyleBackColor = true;
			this.rBttn_MShip.CheckedChanged += new System.EventHandler(this.rBttn_MShip_CheckedChanged);
			// 
			// rBttn_HShip
			// 
			this.rBttn_HShip.AutoSize = true;
			this.rBttn_HShip.Location = new System.Drawing.Point(920, 87);
			this.rBttn_HShip.Name = "rBttn_HShip";
			this.rBttn_HShip.Size = new System.Drawing.Size(101, 21);
			this.rBttn_HShip.TabIndex = 31;
			this.rBttn_HShip.Text = "Heavy Ship";
			this.rBttn_HShip.UseVisualStyleBackColor = true;
			this.rBttn_HShip.CheckedChanged += new System.EventHandler(this.rBttn_HShip_CheckedChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Save,
            this.toolStripSeparator1,
            this.tool_Load,
            this.toolStripSeparator2,
            this.tool_Info});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1062, 27);
			this.toolStrip1.TabIndex = 32;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tool_Save
			// 
			this.tool_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tool_Save.Image = ((System.Drawing.Image)(resources.GetObject("tool_Save.Image")));
			this.tool_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tool_Save.Name = "tool_Save";
			this.tool_Save.Size = new System.Drawing.Size(44, 24);
			this.tool_Save.Text = "Save";
			this.tool_Save.ToolTipText = "Ctrl+s";
			this.tool_Save.Click += new System.EventHandler(this.tool_Save_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// tool_Load
			// 
			this.tool_Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tool_Load.Image = ((System.Drawing.Image)(resources.GetObject("tool_Load.Image")));
			this.tool_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tool_Load.Name = "tool_Load";
			this.tool_Load.Size = new System.Drawing.Size(46, 24);
			this.tool_Load.Text = "Load";
			this.tool_Load.ToolTipText = "Ctrl+l";
			this.tool_Load.Click += new System.EventHandler(this.tool_Load_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// tool_Info
			// 
			this.tool_Info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tool_Info.Image = ((System.Drawing.Image)(resources.GetObject("tool_Info.Image")));
			this.tool_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tool_Info.Name = "tool_Info";
			this.tool_Info.Size = new System.Drawing.Size(39, 24);
			this.tool_Info.Text = "Info";
			this.tool_Info.ToolTipText = "Ctrl+i";
			this.tool_Info.Click += new System.EventHandler(this.tool_Info_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1062, 593);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.rBttn_HShip);
			this.Controls.Add(this.rBttn_MShip);
			this.Controls.Add(this.rBttn_LShip);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.rBttn_PentaD);
			this.Controls.Add(this.rButton_Pulsar);
			this.Controls.Add(this.rBttn_Beacon);
			this.Controls.Add(this.rBttn_Toad);
			this.Controls.Add(this.rBttn_Blinker);
			this.Controls.Add(this.rBttn_Boat);
			this.Controls.Add(this.rBttn_Loaf);
			this.Controls.Add(this.rBttn_Beehive);
			this.Controls.Add(this.rBttn_Tub);
			this.Controls.Add(this.rBttn_Block);
			this.Controls.Add(this.rBttn_Cell);
			this.Controls.Add(this.label_Spaceships);
			this.Controls.Add(this.label_Oscillators);
			this.Controls.Add(this.label_StillLifes);
			this.Controls.Add(this.Bttn_Clear);
			this.Controls.Add(this.check_Grid);
			this.Controls.Add(this.Bttn_Randomize);
			this.Controls.Add(this.Combo_Preset);
			this.Controls.Add(this.label_Gen);
			this.Controls.Add(this.UpDown_Delay);
			this.Controls.Add(this.UpDown_Size);
			this.Controls.Add(this.label_Delay);
			this.Controls.Add(this.label_Size);
			this.Controls.Add(this.Combo_Color);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Bttn_Pause);
			this.Controls.Add(this.Bttn_Run);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Conway\'s Game of Life";
			((System.ComponentModel.ISupportInitialize)(this.UpDown_Size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UpDown_Delay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button Bttn_Run;
		private System.Windows.Forms.Button Bttn_Pause;
		private System.Windows.Forms.ComboBox Combo_Color;
		private System.Windows.Forms.Label label_Size;
		private System.Windows.Forms.Label label_Delay;
		private System.Windows.Forms.NumericUpDown UpDown_Size;
		private System.Windows.Forms.NumericUpDown UpDown_Delay;
		private System.Windows.Forms.Label label_Gen;
		private System.Windows.Forms.ComboBox Combo_Preset;
		private System.Windows.Forms.Button Bttn_Randomize;
		private System.Windows.Forms.CheckBox check_Grid;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Bttn_Clear;
		private System.Windows.Forms.Label label_StillLifes;
		private System.Windows.Forms.Label label_Oscillators;
		private System.Windows.Forms.Label label_Spaceships;
		private System.Windows.Forms.RadioButton rBttn_Cell;
		private System.Windows.Forms.RadioButton rBttn_Block;
		private System.Windows.Forms.RadioButton rBttn_Tub;
		private System.Windows.Forms.RadioButton rBttn_Beehive;
		private System.Windows.Forms.RadioButton rBttn_Loaf;
		private System.Windows.Forms.RadioButton rBttn_Boat;
		private System.Windows.Forms.RadioButton rBttn_Blinker;
		private System.Windows.Forms.RadioButton rBttn_Toad;
		private System.Windows.Forms.RadioButton rBttn_Beacon;
		private System.Windows.Forms.RadioButton rButton_Pulsar;
		private System.Windows.Forms.RadioButton rBttn_PentaD;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton rBttn_LShip;
		private System.Windows.Forms.RadioButton rBttn_MShip;
		private System.Windows.Forms.RadioButton rBttn_HShip;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tool_Save;
		private System.Windows.Forms.ToolStripButton tool_Load;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tool_Info;
	}
}

