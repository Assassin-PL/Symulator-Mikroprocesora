namespace Symulator_Mikroprocesora
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnSaveProgram = new System.Windows.Forms.Button();
            this.btnLoadProgram = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnLoadProgramFromFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRegisters = new System.Windows.Forms.RichTextBox();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.34164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.65836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.Controls.Add(this.btnStep, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveProgram, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadProgram, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExecute, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadProgramFromFile, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegisters, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInstructions, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(201, 3);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(75, 23);
            this.btnStep.TabIndex = 2;
            this.btnStep.Text = "step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnSaveProgram
            // 
            this.btnSaveProgram.Location = new System.Drawing.Point(201, 33);
            this.btnSaveProgram.Name = "btnSaveProgram";
            this.btnSaveProgram.Size = new System.Drawing.Size(75, 19);
            this.btnSaveProgram.TabIndex = 3;
            this.btnSaveProgram.Text = "save";
            this.btnSaveProgram.UseVisualStyleBackColor = true;
            this.btnSaveProgram.Click += new System.EventHandler(this.btnSaveProgram_Click);
            // 
            // btnLoadProgram
            // 
            this.btnLoadProgram.Location = new System.Drawing.Point(3, 3);
            this.btnLoadProgram.Name = "btnLoadProgram";
            this.btnLoadProgram.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProgram.TabIndex = 4;
            this.btnLoadProgram.Text = "loadProgram";
            this.btnLoadProgram.UseVisualStyleBackColor = true;
            this.btnLoadProgram.Click += new System.EventHandler(this.btnLoadProgram_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(3, 33);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 19);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnLoadProgramFromFile
            // 
            this.btnLoadProgramFromFile.Location = new System.Drawing.Point(580, 3);
            this.btnLoadProgramFromFile.Name = "btnLoadProgramFromFile";
            this.btnLoadProgramFromFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProgramFromFile.TabIndex = 6;
            this.btnLoadProgramFromFile.Text = "loadFile";
            this.btnLoadProgramFromFile.UseVisualStyleBackColor = true;
            this.btnLoadProgramFromFile.Click += new System.EventHandler(this.btnLoadProgramFromFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(580, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 19);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtRegisters
            // 
            this.txtRegisters.Location = new System.Drawing.Point(201, 58);
            this.txtRegisters.Name = "txtRegisters";
            this.txtRegisters.Size = new System.Drawing.Size(373, 175);
            this.txtRegisters.TabIndex = 8;
            this.txtRegisters.Text = "";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(201, 239);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(373, 208);
            this.txtInstructions.TabIndex = 9;
            this.txtInstructions.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnSaveProgram;
        private System.Windows.Forms.Button btnLoadProgram;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnLoadProgramFromFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox txtRegisters;
        private System.Windows.Forms.RichTextBox txtInstructions;
    }
}

