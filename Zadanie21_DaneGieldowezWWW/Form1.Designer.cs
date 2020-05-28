namespace Zadanie21_DaneGieldowezWWW
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox_CompanyTag = new System.Windows.Forms.TextBox();
            this.date_Start = new System.Windows.Forms.DateTimePicker();
            this.date_Stop = new System.Windows.Forms.DateTimePicker();
            this.btn_DownloadData = new System.Windows.Forms.Button();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CompanyTag
            // 
            this.textBox_CompanyTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_CompanyTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_CompanyTag.Location = new System.Drawing.Point(104, 23);
            this.textBox_CompanyTag.Name = "textBox_CompanyTag";
            this.textBox_CompanyTag.Size = new System.Drawing.Size(81, 26);
            this.textBox_CompanyTag.TabIndex = 1;
            this.textBox_CompanyTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_CompanyTag.TextChanged += new System.EventHandler(this.textBox_CompanyTag_TextChanged);
            // 
            // date_Start
            // 
            this.date_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date_Start.Location = new System.Drawing.Point(244, 23);
            this.date_Start.Name = "date_Start";
            this.date_Start.Size = new System.Drawing.Size(195, 26);
            this.date_Start.TabIndex = 2;
            // 
            // date_Stop
            // 
            this.date_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.date_Stop.Location = new System.Drawing.Point(467, 23);
            this.date_Stop.Name = "date_Stop";
            this.date_Stop.Size = new System.Drawing.Size(195, 26);
            this.date_Stop.TabIndex = 3;
            // 
            // btn_DownloadData
            // 
            this.btn_DownloadData.Enabled = false;
            this.btn_DownloadData.Location = new System.Drawing.Point(684, 17);
            this.btn_DownloadData.Name = "btn_DownloadData";
            this.btn_DownloadData.Size = new System.Drawing.Size(104, 39);
            this.btn_DownloadData.TabIndex = 4;
            this.btn_DownloadData.Text = "Download Data";
            this.btn_DownloadData.UseVisualStyleBackColor = true;
            this.btn_DownloadData.Click += new System.EventHandler(this.btn_DownloadData_Click);
            // 
            // dgv_Data
            // 
            this.dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(12, 75);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(1029, 215);
            this.dgv_Data.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company \r\nName Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(205, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(445, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "to:";
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(12, 296);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(518, 227);
            this.cartesianChart.TabIndex = 9;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // dataChart
            // 
            chartArea4.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.dataChart.Legends.Add(legend4);
            this.dataChart.Location = new System.Drawing.Point(536, 314);
            this.dataChart.Name = "dataChart";
            series10.BackImageTransparentColor = System.Drawing.Color.White;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series10.Legend = "Legend1";
            series10.Name = "Open";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Close";
            series12.BackSecondaryColor = System.Drawing.Color.Red;
            series12.BorderColor = System.Drawing.Color.Lime;
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.Fuchsia;
            series12.LabelBorderWidth = 4;
            series12.Legend = "Legend1";
            series12.Name = "Volume";
            series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.dataChart.Series.Add(series10);
            this.dataChart.Series.Add(series11);
            this.dataChart.Series.Add(series12);
            this.dataChart.Size = new System.Drawing.Size(499, 209);
            this.dataChart.TabIndex = 10;
            this.dataChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 568);
            this.Controls.Add(this.dataChart);
            this.Controls.Add(this.cartesianChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Data);
            this.Controls.Add(this.btn_DownloadData);
            this.Controls.Add(this.date_Stop);
            this.Controls.Add(this.date_Start);
            this.Controls.Add(this.textBox_CompanyTag);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Stock Prices Parser";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_CompanyTag;
        private System.Windows.Forms.DateTimePicker date_Start;
        private System.Windows.Forms.DateTimePicker date_Stop;
        private System.Windows.Forms.Button btn_DownloadData;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
    }
}

