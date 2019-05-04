namespace Kredek
{
    partial class FormMain
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.A2GridView = new System.Windows.Forms.DataGridView();
            this.buttonAddWpis = new System.Windows.Forms.Button();
            this.textBoxWpisyCounter = new System.Windows.Forms.TextBox();
            this.labelWpisyCounter = new System.Windows.Forms.Label();
            this.buttonA3Start = new System.Windows.Forms.Button();
            this.timerA3 = new System.Windows.Forms.Timer(this.components);
            this.EmplyeesGridView = new System.Windows.Forms.DataGridView();
            this.buttonShowEmployees = new System.Windows.Forms.Button();
            this.buttonNoReportsTo = new System.Windows.Forms.Button();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.buttonProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.A2GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplyeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(55, 12);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(55, 40);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(3, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(5, 40);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(44, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Hasło";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Location = new System.Drawing.Point(55, 68);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(100, 27);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "A1 - Zaloguj";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // A2GridView
            // 
            this.A2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A2GridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.A2GridView.Location = new System.Drawing.Point(184, 31);
            this.A2GridView.Name = "A2GridView";
            this.A2GridView.RowTemplate.Height = 24;
            this.A2GridView.Size = new System.Drawing.Size(240, 150);
            this.A2GridView.TabIndex = 5;
            // 
            // buttonAddWpis
            // 
            this.buttonAddWpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWpis.Location = new System.Drawing.Point(253, 187);
            this.buttonAddWpis.Name = "buttonAddWpis";
            this.buttonAddWpis.Size = new System.Drawing.Size(100, 27);
            this.buttonAddWpis.TabIndex = 6;
            this.buttonAddWpis.Text = "A2 - Dodaj";
            this.buttonAddWpis.UseVisualStyleBackColor = true;
            this.buttonAddWpis.Click += new System.EventHandler(this.buttonAddWpis_Click);
            // 
            // textBoxWpisyCounter
            // 
            this.textBoxWpisyCounter.Location = new System.Drawing.Point(397, 3);
            this.textBoxWpisyCounter.Name = "textBoxWpisyCounter";
            this.textBoxWpisyCounter.Size = new System.Drawing.Size(27, 22);
            this.textBoxWpisyCounter.TabIndex = 7;
            // 
            // labelWpisyCounter
            // 
            this.labelWpisyCounter.AutoSize = true;
            this.labelWpisyCounter.Location = new System.Drawing.Point(237, 6);
            this.labelWpisyCounter.Name = "labelWpisyCounter";
            this.labelWpisyCounter.Size = new System.Drawing.Size(154, 17);
            this.labelWpisyCounter.TabIndex = 8;
            this.labelWpisyCounter.Text = "Ilość dodanych wpisów:";
            // 
            // buttonA3Start
            // 
            this.buttonA3Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA3Start.Location = new System.Drawing.Point(475, 30);
            this.buttonA3Start.Name = "buttonA3Start";
            this.buttonA3Start.Size = new System.Drawing.Size(100, 27);
            this.buttonA3Start.TabIndex = 9;
            this.buttonA3Start.Text = "A3 - Start";
            this.buttonA3Start.UseVisualStyleBackColor = true;
            this.buttonA3Start.Click += new System.EventHandler(this.buttonA3Start_Click);
            // 
            // timerA3
            // 
            this.timerA3.Interval = 1000;
            this.timerA3.Tick += new System.EventHandler(this.timerA3_Tick);
            // 
            // EmplyeesGridView
            // 
            this.EmplyeesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmplyeesGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmplyeesGridView.Location = new System.Drawing.Point(581, 12);
            this.EmplyeesGridView.Name = "EmplyeesGridView";
            this.EmplyeesGridView.RowTemplate.Height = 24;
            this.EmplyeesGridView.Size = new System.Drawing.Size(290, 169);
            this.EmplyeesGridView.TabIndex = 10;
            // 
            // buttonShowEmployees
            // 
            this.buttonShowEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowEmployees.Location = new System.Drawing.Point(668, 187);
            this.buttonShowEmployees.Name = "buttonShowEmployees";
            this.buttonShowEmployees.Size = new System.Drawing.Size(134, 27);
            this.buttonShowEmployees.TabIndex = 11;
            this.buttonShowEmployees.Text = "A4 - Pracownicy a";
            this.buttonShowEmployees.UseVisualStyleBackColor = true;
            this.buttonShowEmployees.Click += new System.EventHandler(this.buttonShowEmployees_Click);
            // 
            // buttonNoReportsTo
            // 
            this.buttonNoReportsTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoReportsTo.Location = new System.Drawing.Point(654, 220);
            this.buttonNoReportsTo.Name = "buttonNoReportsTo";
            this.buttonNoReportsTo.Size = new System.Drawing.Size(168, 27);
            this.buttonNoReportsTo.TabIndex = 12;
            this.buttonNoReportsTo.Text = "A5 - Bez przełożonych";
            this.buttonNoReportsTo.UseVisualStyleBackColor = true;
            this.buttonNoReportsTo.Click += new System.EventHandler(this.buttonNoReportsTo_Click);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductsGridView.Location = new System.Drawing.Point(6, 220);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowTemplate.Height = 24;
            this.ProductsGridView.Size = new System.Drawing.Size(290, 169);
            this.ProductsGridView.TabIndex = 13;
            // 
            // buttonProducts
            // 
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Location = new System.Drawing.Point(55, 395);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(168, 27);
            this.buttonProducts.TabIndex = 14;
            this.buttonProducts.Text = "A6 - Produkty 5-20";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.buttonNoReportsTo);
            this.Controls.Add(this.buttonShowEmployees);
            this.Controls.Add(this.EmplyeesGridView);
            this.Controls.Add(this.buttonA3Start);
            this.Controls.Add(this.labelWpisyCounter);
            this.Controls.Add(this.textBoxWpisyCounter);
            this.Controls.Add(this.buttonAddWpis);
            this.Controls.Add(this.A2GridView);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.A2GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmplyeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.DataGridView A2GridView;
        private System.Windows.Forms.Button buttonAddWpis;
        private System.Windows.Forms.TextBox textBoxWpisyCounter;
        private System.Windows.Forms.Label labelWpisyCounter;
        private System.Windows.Forms.Button buttonA3Start;
        private System.Windows.Forms.Timer timerA3;
        private System.Windows.Forms.DataGridView EmplyeesGridView;
        private System.Windows.Forms.Button buttonShowEmployees;
        private System.Windows.Forms.Button buttonNoReportsTo;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Button buttonProducts;
    }
}

