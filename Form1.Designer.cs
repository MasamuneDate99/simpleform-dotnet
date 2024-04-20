namespace SimpleForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priceInput = new System.Windows.Forms.TextBox();
            this.itemId = new System.Windows.Forms.TextBox();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.harborOrigin = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.harborLabel = new System.Windows.Forms.Label();
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.genereateResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.pelabuhan = new System.Windows.Forms.Label();
            this.barang = new System.Windows.Forms.Label();
            this.detailBarang = new System.Windows.Forms.Label();
            this.hargaBarang = new System.Windows.Forms.Label();
            this.persenPajak = new System.Windows.Forms.Label();
            this.nominalPajak = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(12, 250);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(210, 27);
            this.priceInput.TabIndex = 4;
            this.priceInput.Text = "Price";
            // 
            // itemId
            // 
            this.itemId.Location = new System.Drawing.Point(12, 197);
            this.itemId.Name = "itemId";
            this.itemId.Size = new System.Drawing.Size(210, 27);
            this.itemId.TabIndex = 1;
            this.itemId.Text = "Item";
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(12, 91);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(210, 27);
            this.countryInput.TabIndex = 0;
            this.countryInput.Text = "Country";
            // 
            // harborOrigin
            // 
            this.harborOrigin.Location = new System.Drawing.Point(12, 144);
            this.harborOrigin.Name = "harborOrigin";
            this.harborOrigin.Size = new System.Drawing.Size(210, 27);
            this.harborOrigin.TabIndex = 2;
            this.harborOrigin.Text = "Pelabuhan";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 68);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(60, 20);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "Country";
            // 
            // harborLabel
            // 
            this.harborLabel.AutoSize = true;
            this.harborLabel.Location = new System.Drawing.Point(12, 121);
            this.harborLabel.Name = "harborLabel";
            this.harborLabel.Size = new System.Drawing.Size(138, 20);
            this.harborLabel.TabIndex = 8;
            this.harborLabel.Text = "Harbor / Pelabuhan";
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Location = new System.Drawing.Point(12, 174);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(58, 20);
            this.itemIdLabel.TabIndex = 9;
            this.itemIdLabel.Text = "Item ID";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 227);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 20);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "Price";
            // 
            // genereateResult
            // 
            this.genereateResult.Location = new System.Drawing.Point(12, 283);
            this.genereateResult.Name = "genereateResult";
            this.genereateResult.Size = new System.Drawing.Size(94, 29);
            this.genereateResult.TabIndex = 14;
            this.genereateResult.Text = "Submit";
            this.genereateResult.UseVisualStyleBackColor = true;
            this.genereateResult.Click += new System.EventHandler(this.genereateResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Input Data";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(298, 68);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(60, 20);
            this.country.TabIndex = 16;
            this.country.Text = "Country";
            this.country.Visible = false;
            // 
            // pelabuhan
            // 
            this.pelabuhan.AutoSize = true;
            this.pelabuhan.Location = new System.Drawing.Point(298, 121);
            this.pelabuhan.Name = "pelabuhan";
            this.pelabuhan.Size = new System.Drawing.Size(60, 20);
            this.pelabuhan.TabIndex = 17;
            this.pelabuhan.Text = "Country";
            this.pelabuhan.Visible = false;
            // 
            // barang
            // 
            this.barang.AutoSize = true;
            this.barang.Location = new System.Drawing.Point(298, 174);
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(60, 20);
            this.barang.TabIndex = 18;
            this.barang.Text = "Country";
            this.barang.Visible = false;
            // 
            // detailBarang
            // 
            this.detailBarang.AutoSize = true;
            this.detailBarang.Location = new System.Drawing.Point(298, 227);
            this.detailBarang.Name = "detailBarang";
            this.detailBarang.Size = new System.Drawing.Size(60, 20);
            this.detailBarang.TabIndex = 19;
            this.detailBarang.Text = "Country";
            this.detailBarang.Visible = false;
            // 
            // hargaBarang
            // 
            this.hargaBarang.AutoSize = true;
            this.hargaBarang.Location = new System.Drawing.Point(298, 283);
            this.hargaBarang.Name = "hargaBarang";
            this.hargaBarang.Size = new System.Drawing.Size(60, 20);
            this.hargaBarang.TabIndex = 20;
            this.hargaBarang.Text = "Country";
            this.hargaBarang.Visible = false;
            // 
            // persenPajak
            // 
            this.persenPajak.AutoSize = true;
            this.persenPajak.Location = new System.Drawing.Point(298, 335);
            this.persenPajak.Name = "persenPajak";
            this.persenPajak.Size = new System.Drawing.Size(60, 20);
            this.persenPajak.TabIndex = 21;
            this.persenPajak.Text = "Country";
            this.persenPajak.Visible = false;
            // 
            // nominalPajak
            // 
            this.nominalPajak.AutoSize = true;
            this.nominalPajak.Location = new System.Drawing.Point(298, 390);
            this.nominalPajak.Name = "nominalPajak";
            this.nominalPajak.Size = new System.Drawing.Size(60, 20);
            this.nominalPajak.TabIndex = 22;
            this.nominalPajak.Text = "Country";
            this.nominalPajak.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(298, 9);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(151, 37);
            this.resultLabel.TabIndex = 23;
            this.resultLabel.Text = "Result Data";
            this.resultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.nominalPajak);
            this.Controls.Add(this.persenPajak);
            this.Controls.Add(this.hargaBarang);
            this.Controls.Add(this.detailBarang);
            this.Controls.Add(this.barang);
            this.Controls.Add(this.pelabuhan);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genereateResult);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.itemIdLabel);
            this.Controls.Add(this.harborLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.harborOrigin);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.itemId);
            this.Name = "Form1";
            this.Text = "Simple Form Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private TextBox priceInput;
        private TextBox itemId;
        private TextBox countryInput;
        private TextBox harborOrigin;
        private Label countryLabel;
        private Label harborLabel;
        private Label itemIdLabel;
        private Label priceLabel;
        private Button genereateResult;
        private Label label1;
        private Label country;
        private Label pelabuhan;
        private Label barang;
        private Label detailBarang;
        private Label hargaBarang;
        private Label persenPajak;
        private Label nominalPajak;
        private Label resultLabel;
    }
}