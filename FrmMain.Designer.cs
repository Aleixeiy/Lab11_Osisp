namespace Intellector
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonThink = new System.Windows.Forms.Button();
            this.labelBestMove = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericDepth = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBoxPlayers = new System.Windows.Forms.TextBox();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.radioa = new System.Windows.Forms.RadioButton();
            this.radiol = new System.Windows.Forms.RadioButton();
            this.radiod = new System.Windows.Forms.RadioButton();
            this.radiop = new System.Windows.Forms.RadioButton();
            this.radioi = new System.Windows.Forms.RadioButton();
            this.radioib = new System.Windows.Forms.RadioButton();
            this.radiopb = new System.Windows.Forms.RadioButton();
            this.radiodb = new System.Windows.Forms.RadioButton();
            this.radiolb = new System.Windows.Forms.RadioButton();
            this.radioab = new System.Windows.Forms.RadioButton();
            this.radiomb = new System.Windows.Forms.RadioButton();
            this.radiom = new System.Windows.Forms.RadioButton();
            this.radioClear = new System.Windows.Forms.RadioButton();
            this.pictureib = new System.Windows.Forms.PictureBox();
            this.picturepb = new System.Windows.Forms.PictureBox();
            this.picturedb = new System.Windows.Forms.PictureBox();
            this.picturelb = new System.Windows.Forms.PictureBox();
            this.pictureab = new System.Windows.Forms.PictureBox();
            this.picturemb = new System.Windows.Forms.PictureBox();
            this.picturei = new System.Windows.Forms.PictureBox();
            this.picturep = new System.Windows.Forms.PictureBox();
            this.pictured = new System.Windows.Forms.PictureBox();
            this.picturel = new System.Windows.Forms.PictureBox();
            this.picturea = new System.Windows.Forms.PictureBox();
            this.picturem = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelHashCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictured)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThink
            // 
            this.buttonThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThink.Location = new System.Drawing.Point(863, 111);
            this.buttonThink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThink.Name = "buttonThink";
            this.buttonThink.Size = new System.Drawing.Size(100, 45);
            this.buttonThink.TabIndex = 0;
            this.buttonThink.Text = "Думай";
            this.buttonThink.UseVisualStyleBackColor = true;
            this.buttonThink.Click += new System.EventHandler(this.buttonThink_Click);
            // 
            // labelBestMove
            // 
            this.labelBestMove.AutoSize = true;
            this.labelBestMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBestMove.Location = new System.Drawing.Point(968, 119);
            this.labelBestMove.Name = "labelBestMove";
            this.labelBestMove.Size = new System.Drawing.Size(92, 29);
            this.labelBestMove.TabIndex = 1;
            this.labelBestMove.Text = "uu-uu u";
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMark.Location = new System.Drawing.Point(1066, 119);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(58, 29);
            this.labelMark.TabIndex = 2;
            this.labelMark.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(858, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Глубина";
            // 
            // numericDepth
            // 
            this.numericDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericDepth.Location = new System.Drawing.Point(974, 7);
            this.numericDepth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDepth.Name = "numericDepth";
            this.numericDepth.Size = new System.Drawing.Size(61, 35);
            this.numericDepth.TabIndex = 4;
            this.numericDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBoxPlayers
            // 
            this.textBoxPlayers.Location = new System.Drawing.Point(863, 169);
            this.textBoxPlayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPlayers.Multiline = true;
            this.textBoxPlayers.Name = "textBoxPlayers";
            this.textBoxPlayers.Size = new System.Drawing.Size(259, 87);
            this.textBoxPlayers.TabIndex = 5;
            // 
            // radioMove
            // 
            this.radioMove.AutoSize = true;
            this.radioMove.Location = new System.Drawing.Point(823, 389);
            this.radioMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(59, 17);
            this.radioMove.TabIndex = 6;
            this.radioMove.TabStop = true;
            this.radioMove.Text = "ходить";
            this.radioMove.UseVisualStyleBackColor = true;
            // 
            // radioa
            // 
            this.radioa.AutoSize = true;
            this.radioa.Location = new System.Drawing.Point(896, 462);
            this.radioa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioa.Name = "radioa";
            this.radioa.Size = new System.Drawing.Size(14, 13);
            this.radioa.TabIndex = 7;
            this.radioa.TabStop = true;
            this.radioa.UseVisualStyleBackColor = true;
            // 
            // radiol
            // 
            this.radiol.AutoSize = true;
            this.radiol.Location = new System.Drawing.Point(955, 462);
            this.radiol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiol.Name = "radiol";
            this.radiol.Size = new System.Drawing.Size(14, 13);
            this.radiol.TabIndex = 8;
            this.radiol.TabStop = true;
            this.radiol.UseVisualStyleBackColor = true;
            // 
            // radiod
            // 
            this.radiod.AutoSize = true;
            this.radiod.Location = new System.Drawing.Point(1014, 462);
            this.radiod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiod.Name = "radiod";
            this.radiod.Size = new System.Drawing.Size(14, 13);
            this.radiod.TabIndex = 9;
            this.radiod.TabStop = true;
            this.radiod.UseVisualStyleBackColor = true;
            // 
            // radiop
            // 
            this.radiop.AutoSize = true;
            this.radiop.Location = new System.Drawing.Point(1073, 462);
            this.radiop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiop.Name = "radiop";
            this.radiop.Size = new System.Drawing.Size(14, 13);
            this.radiop.TabIndex = 10;
            this.radiop.TabStop = true;
            this.radiop.UseVisualStyleBackColor = true;
            // 
            // radioi
            // 
            this.radioi.AutoSize = true;
            this.radioi.Location = new System.Drawing.Point(1132, 462);
            this.radioi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioi.Name = "radioi";
            this.radioi.Size = new System.Drawing.Size(14, 13);
            this.radioi.TabIndex = 11;
            this.radioi.TabStop = true;
            this.radioi.UseVisualStyleBackColor = true;
            // 
            // radioib
            // 
            this.radioib.AutoSize = true;
            this.radioib.Location = new System.Drawing.Point(1132, 564);
            this.radioib.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioib.Name = "radioib";
            this.radioib.Size = new System.Drawing.Size(14, 13);
            this.radioib.TabIndex = 16;
            this.radioib.TabStop = true;
            this.radioib.UseVisualStyleBackColor = true;
            // 
            // radiopb
            // 
            this.radiopb.AutoSize = true;
            this.radiopb.Location = new System.Drawing.Point(1073, 564);
            this.radiopb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiopb.Name = "radiopb";
            this.radiopb.Size = new System.Drawing.Size(14, 13);
            this.radiopb.TabIndex = 15;
            this.radiopb.TabStop = true;
            this.radiopb.UseVisualStyleBackColor = true;
            // 
            // radiodb
            // 
            this.radiodb.AutoSize = true;
            this.radiodb.Location = new System.Drawing.Point(1014, 564);
            this.radiodb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiodb.Name = "radiodb";
            this.radiodb.Size = new System.Drawing.Size(14, 13);
            this.radiodb.TabIndex = 14;
            this.radiodb.TabStop = true;
            this.radiodb.UseVisualStyleBackColor = true;
            // 
            // radiolb
            // 
            this.radiolb.AutoSize = true;
            this.radiolb.Location = new System.Drawing.Point(955, 564);
            this.radiolb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiolb.Name = "radiolb";
            this.radiolb.Size = new System.Drawing.Size(14, 13);
            this.radiolb.TabIndex = 13;
            this.radiolb.TabStop = true;
            this.radiolb.UseVisualStyleBackColor = true;
            // 
            // radioab
            // 
            this.radioab.AutoSize = true;
            this.radioab.Location = new System.Drawing.Point(896, 564);
            this.radioab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioab.Name = "radioab";
            this.radioab.Size = new System.Drawing.Size(14, 13);
            this.radioab.TabIndex = 12;
            this.radioab.TabStop = true;
            this.radioab.UseVisualStyleBackColor = true;
            // 
            // radiomb
            // 
            this.radiomb.AutoSize = true;
            this.radiomb.Location = new System.Drawing.Point(837, 564);
            this.radiomb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiomb.Name = "radiomb";
            this.radiomb.Size = new System.Drawing.Size(14, 13);
            this.radiomb.TabIndex = 18;
            this.radiomb.TabStop = true;
            this.radiomb.UseVisualStyleBackColor = true;
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.Location = new System.Drawing.Point(837, 462);
            this.radiom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(14, 13);
            this.radiom.TabIndex = 17;
            this.radiom.TabStop = true;
            this.radiom.UseVisualStyleBackColor = true;
            // 
            // radioClear
            // 
            this.radioClear.AutoSize = true;
            this.radioClear.Location = new System.Drawing.Point(886, 389);
            this.radioClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioClear.Name = "radioClear";
            this.radioClear.Size = new System.Drawing.Size(72, 17);
            this.radioClear.TabIndex = 19;
            this.radioClear.TabStop = true;
            this.radioClear.Text = "Очистить";
            this.radioClear.UseVisualStyleBackColor = true;
            // 
            // pictureib
            // 
            this.pictureib.BackgroundImage = global::Intellector.Properties.Resources.iB;
            this.pictureib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureib.Location = new System.Drawing.Point(1108, 581);
            this.pictureib.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureib.Name = "pictureib";
            this.pictureib.Size = new System.Drawing.Size(60, 60);
            this.pictureib.TabIndex = 31;
            this.pictureib.TabStop = false;
            // 
            // picturepb
            // 
            this.picturepb.BackgroundImage = global::Intellector.Properties.Resources.pB;
            this.picturepb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturepb.Location = new System.Drawing.Point(1049, 581);
            this.picturepb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturepb.Name = "picturepb";
            this.picturepb.Size = new System.Drawing.Size(60, 60);
            this.picturepb.TabIndex = 30;
            this.picturepb.TabStop = false;
            // 
            // picturedb
            // 
            this.picturedb.BackgroundImage = global::Intellector.Properties.Resources.dB;
            this.picturedb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturedb.Location = new System.Drawing.Point(990, 581);
            this.picturedb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturedb.Name = "picturedb";
            this.picturedb.Size = new System.Drawing.Size(60, 60);
            this.picturedb.TabIndex = 29;
            this.picturedb.TabStop = false;
            // 
            // picturelb
            // 
            this.picturelb.BackgroundImage = global::Intellector.Properties.Resources.lB;
            this.picturelb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturelb.Location = new System.Drawing.Point(931, 581);
            this.picturelb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturelb.Name = "picturelb";
            this.picturelb.Size = new System.Drawing.Size(60, 60);
            this.picturelb.TabIndex = 28;
            this.picturelb.TabStop = false;
            // 
            // pictureab
            // 
            this.pictureab.BackgroundImage = global::Intellector.Properties.Resources.aB;
            this.pictureab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureab.Location = new System.Drawing.Point(872, 581);
            this.pictureab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureab.Name = "pictureab";
            this.pictureab.Size = new System.Drawing.Size(60, 60);
            this.pictureab.TabIndex = 27;
            this.pictureab.TabStop = false;
            // 
            // picturemb
            // 
            this.picturemb.BackgroundImage = global::Intellector.Properties.Resources.mB;
            this.picturemb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturemb.Location = new System.Drawing.Point(813, 581);
            this.picturemb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturemb.Name = "picturemb";
            this.picturemb.Size = new System.Drawing.Size(60, 60);
            this.picturemb.TabIndex = 26;
            this.picturemb.TabStop = false;
            // 
            // picturei
            // 
            this.picturei.BackgroundImage = global::Intellector.Properties.Resources.iW;
            this.picturei.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturei.Location = new System.Drawing.Point(1108, 479);
            this.picturei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturei.Name = "picturei";
            this.picturei.Size = new System.Drawing.Size(60, 60);
            this.picturei.TabIndex = 25;
            this.picturei.TabStop = false;
            // 
            // picturep
            // 
            this.picturep.BackgroundImage = global::Intellector.Properties.Resources.pW;
            this.picturep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturep.Location = new System.Drawing.Point(1049, 479);
            this.picturep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturep.Name = "picturep";
            this.picturep.Size = new System.Drawing.Size(60, 60);
            this.picturep.TabIndex = 24;
            this.picturep.TabStop = false;
            // 
            // pictured
            // 
            this.pictured.BackgroundImage = global::Intellector.Properties.Resources.dW;
            this.pictured.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictured.Location = new System.Drawing.Point(990, 479);
            this.pictured.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictured.Name = "pictured";
            this.pictured.Size = new System.Drawing.Size(60, 60);
            this.pictured.TabIndex = 23;
            this.pictured.TabStop = false;
            // 
            // picturel
            // 
            this.picturel.BackgroundImage = global::Intellector.Properties.Resources.lW;
            this.picturel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturel.Location = new System.Drawing.Point(931, 479);
            this.picturel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturel.Name = "picturel";
            this.picturel.Size = new System.Drawing.Size(60, 60);
            this.picturel.TabIndex = 22;
            this.picturel.TabStop = false;
            // 
            // picturea
            // 
            this.picturea.BackgroundImage = global::Intellector.Properties.Resources.aW;
            this.picturea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturea.Location = new System.Drawing.Point(872, 479);
            this.picturea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturea.Name = "picturea";
            this.picturea.Size = new System.Drawing.Size(60, 60);
            this.picturea.TabIndex = 21;
            this.picturea.TabStop = false;
            // 
            // picturem
            // 
            this.picturem.BackgroundImage = global::Intellector.Properties.Resources.mW1;
            this.picturem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturem.Location = new System.Drawing.Point(813, 479);
            this.picturem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturem.Name = "picturem";
            this.picturem.Size = new System.Drawing.Size(60, 60);
            this.picturem.TabIndex = 20;
            this.picturem.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(1058, 11);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 26);
            this.labelTime.TabIndex = 32;
            this.labelTime.Text = "time";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(1058, 45);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(65, 26);
            this.labelCount.TabIndex = 33;
            this.labelCount.Text = "count";
            // 
            // labelHashCount
            // 
            this.labelHashCount.AutoSize = true;
            this.labelHashCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHashCount.Location = new System.Drawing.Point(1058, 79);
            this.labelHashCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHashCount.Name = "labelHashCount";
            this.labelHashCount.Size = new System.Drawing.Size(117, 26);
            this.labelHashCount.TabIndex = 34;
            this.labelHashCount.Text = "hashCount";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.labelHashCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureib);
            this.Controls.Add(this.picturepb);
            this.Controls.Add(this.picturedb);
            this.Controls.Add(this.picturelb);
            this.Controls.Add(this.pictureab);
            this.Controls.Add(this.picturemb);
            this.Controls.Add(this.picturei);
            this.Controls.Add(this.picturep);
            this.Controls.Add(this.pictured);
            this.Controls.Add(this.picturel);
            this.Controls.Add(this.picturea);
            this.Controls.Add(this.picturem);
            this.Controls.Add(this.radioClear);
            this.Controls.Add(this.radiomb);
            this.Controls.Add(this.radiom);
            this.Controls.Add(this.radioib);
            this.Controls.Add(this.radiopb);
            this.Controls.Add(this.radiodb);
            this.Controls.Add(this.radiolb);
            this.Controls.Add(this.radioab);
            this.Controls.Add(this.radioi);
            this.Controls.Add(this.radiop);
            this.Controls.Add(this.radiod);
            this.Controls.Add(this.radiol);
            this.Controls.Add(this.radioa);
            this.Controls.Add(this.radioMove);
            this.Controls.Add(this.textBoxPlayers);
            this.Controls.Add(this.numericDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.labelBestMove);
            this.Controls.Add(this.buttonThink);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "Intellector";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numericDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturepb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturelb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictured)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThink;
        private System.Windows.Forms.Label labelBestMove;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericDepth;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.TextBox textBoxPlayers;
        private System.Windows.Forms.RadioButton radioMove;
        private System.Windows.Forms.RadioButton radioa;
        private System.Windows.Forms.RadioButton radiol;
        private System.Windows.Forms.RadioButton radiod;
        private System.Windows.Forms.RadioButton radiop;
        private System.Windows.Forms.RadioButton radioi;
        private System.Windows.Forms.RadioButton radioib;
        private System.Windows.Forms.RadioButton radiopb;
        private System.Windows.Forms.RadioButton radiodb;
        private System.Windows.Forms.RadioButton radiolb;
        private System.Windows.Forms.RadioButton radioab;
        private System.Windows.Forms.RadioButton radiomb;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.RadioButton radioClear;
        private System.Windows.Forms.PictureBox picturem;
        private System.Windows.Forms.PictureBox picturea;
        private System.Windows.Forms.PictureBox picturel;
        private System.Windows.Forms.PictureBox pictured;
        private System.Windows.Forms.PictureBox picturep;
        private System.Windows.Forms.PictureBox picturei;
        private System.Windows.Forms.PictureBox pictureib;
        private System.Windows.Forms.PictureBox picturepb;
        private System.Windows.Forms.PictureBox picturedb;
        private System.Windows.Forms.PictureBox picturelb;
        private System.Windows.Forms.PictureBox pictureab;
        private System.Windows.Forms.PictureBox picturemb;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelHashCount;
    }
}

