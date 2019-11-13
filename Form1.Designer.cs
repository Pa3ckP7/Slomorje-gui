namespace Slomorje_gui
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TempSeaB2Text = new System.Windows.Forms.Label();
            this.TempSeaPText = new System.Windows.Forms.Label();
            this.WindText = new System.Windows.Forms.Label();
            this.TempSeaB1Text = new System.Windows.Forms.Label();
            this.WsizeText = new System.Windows.Forms.Label();
            this.TempSeaB2Label = new System.Windows.Forms.Label();
            this.TempSeaB1Label = new System.Windows.Forms.Label();
            this.SeaTempPLabel = new System.Windows.Forms.Label();
            this.WsizeLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.TempAirLabel = new System.Windows.Forms.Label();
            this.TempText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RefreshButton.Location = new System.Drawing.Point(310, 380);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(145, 25);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.37192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09894F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.37192F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.07861F));
            this.tableLayoutPanel1.Controls.Add(this.TempSeaB2Text, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.TempSeaPText, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.WindText, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.TempSeaB1Text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.WsizeText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TempSeaB2Label, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.TempSeaB1Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SeaTempPLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.WsizeLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WindSpeedLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.TempAirLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TempText, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 295);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TempSeaB2Text
            // 
            this.TempSeaB2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempSeaB2Text.AutoSize = true;
            this.TempSeaB2Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempSeaB2Text.Location = new System.Drawing.Point(597, 233);
            this.TempSeaB2Text.Name = "TempSeaB2Text";
            this.TempSeaB2Text.Size = new System.Drawing.Size(78, 24);
            this.TempSeaB2Text.TabIndex = 31;
            this.TempSeaB2Text.Text = "00.0  C";
            // 
            // TempSeaPText
            // 
            this.TempSeaPText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempSeaPText.AutoSize = true;
            this.TempSeaPText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempSeaPText.Location = new System.Drawing.Point(597, 135);
            this.TempSeaPText.Name = "TempSeaPText";
            this.TempSeaPText.Size = new System.Drawing.Size(78, 24);
            this.TempSeaPText.TabIndex = 30;
            this.TempSeaPText.Text = "00.0  C";
            // 
            // WindText
            // 
            this.WindText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WindText.AutoSize = true;
            this.WindText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WindText.Location = new System.Drawing.Point(597, 37);
            this.WindText.Name = "WindText";
            this.WindText.Size = new System.Drawing.Size(78, 24);
            this.WindText.TabIndex = 29;
            this.WindText.Text = "00.0  C";
            // 
            // TempSeaB1Text
            // 
            this.TempSeaB1Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempSeaB1Text.AutoSize = true;
            this.TempSeaB1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempSeaB1Text.Location = new System.Drawing.Point(222, 233);
            this.TempSeaB1Text.Name = "TempSeaB1Text";
            this.TempSeaB1Text.Size = new System.Drawing.Size(75, 24);
            this.TempSeaB1Text.TabIndex = 27;
            this.TempSeaB1Text.Text = "00.0  C";
            // 
            // WsizeText
            // 
            this.WsizeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WsizeText.AutoSize = true;
            this.WsizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WsizeText.Location = new System.Drawing.Point(222, 135);
            this.WsizeText.Name = "WsizeText";
            this.WsizeText.Size = new System.Drawing.Size(75, 24);
            this.WsizeText.TabIndex = 25;
            this.WsizeText.Text = "00.0  C";
            // 
            // TempSeaB2Label
            // 
            this.TempSeaB2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempSeaB2Label.AutoSize = true;
            this.TempSeaB2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempSeaB2Label.Location = new System.Drawing.Point(378, 202);
            this.TempSeaB2Label.Name = "TempSeaB2Label";
            this.TempSeaB2Label.Size = new System.Drawing.Size(213, 87);
            this.TempSeaB2Label.TabIndex = 13;
            this.TempSeaB2Label.Text = "Temperatura morja v globini (Senzor 2)";
            // 
            // TempSeaB1Label
            // 
            this.TempSeaB1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempSeaB1Label.AutoSize = true;
            this.TempSeaB1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempSeaB1Label.Location = new System.Drawing.Point(3, 202);
            this.TempSeaB1Label.Name = "TempSeaB1Label";
            this.TempSeaB1Label.Size = new System.Drawing.Size(213, 87);
            this.TempSeaB1Label.TabIndex = 10;
            this.TempSeaB1Label.Text = "Temperatura morja v globini (Senzor 1)";
            // 
            // SeaTempPLabel
            // 
            this.SeaTempPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SeaTempPLabel.AutoSize = true;
            this.SeaTempPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SeaTempPLabel.Location = new System.Drawing.Point(378, 118);
            this.SeaTempPLabel.Name = "SeaTempPLabel";
            this.SeaTempPLabel.Size = new System.Drawing.Size(213, 58);
            this.SeaTempPLabel.TabIndex = 8;
            this.SeaTempPLabel.Text = "Temperatura površine morja";
            // 
            // WsizeLabel
            // 
            this.WsizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WsizeLabel.AutoSize = true;
            this.WsizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WsizeLabel.Location = new System.Drawing.Point(3, 132);
            this.WsizeLabel.Name = "WsizeLabel";
            this.WsizeLabel.Size = new System.Drawing.Size(213, 29);
            this.WsizeLabel.TabIndex = 5;
            this.WsizeLabel.Text = "Višina Valov";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WindSpeedLabel.Location = new System.Drawing.Point(378, 34);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(213, 29);
            this.WindSpeedLabel.TabIndex = 3;
            this.WindSpeedLabel.Text = "Hitrost Vetra";
            // 
            // TempAirLabel
            // 
            this.TempAirLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempAirLabel.AutoSize = true;
            this.TempAirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TempAirLabel.Location = new System.Drawing.Point(3, 34);
            this.TempAirLabel.Name = "TempAirLabel";
            this.TempAirLabel.Size = new System.Drawing.Size(213, 29);
            this.TempAirLabel.TabIndex = 0;
            this.TempAirLabel.Text = "Tempertura Zraka";
            // 
            // TempText
            // 
            this.TempText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TempText.AutoSize = true;
            this.TempText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TempText.Location = new System.Drawing.Point(222, 37);
            this.TempText.Name = "TempText";
            this.TempText.Size = new System.Drawing.Size(75, 24);
            this.TempText.TabIndex = 23;
            this.TempText.Text = "00.0   C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RefreshButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "Form1";
            this.Text = "Slomorje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TempAirLabel;
        private System.Windows.Forms.Label TempSeaB2Label;
        private System.Windows.Forms.Label TempSeaB1Label;
        private System.Windows.Forms.Label SeaTempPLabel;
        private System.Windows.Forms.Label WsizeLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label TempSeaB2Text;
        private System.Windows.Forms.Label TempSeaPText;
        private System.Windows.Forms.Label WindText;
        private System.Windows.Forms.Label TempSeaB1Text;
        private System.Windows.Forms.Label WsizeText;
        private System.Windows.Forms.Label TempText;
    }
}

