namespace Presentacion
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
            txtBuscar = new TextBox();
            dgvRegion = new DataGridView();
            label1 = new Label();
            btnCrear = new Button();
            button1 = new Button();
            txtId = new TextBox();
            label2 = new Label();
            button2 = new Button();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            habilitado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRegion).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(194, 37);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(105, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvRegion
            // 
            dgvRegion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegion.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, habilitado });
            dgvRegion.Location = new Point(194, 169);
            dgvRegion.Name = "dgvRegion";
            dgvRegion.RowTemplate.Height = 25;
            dgvRegion.Size = new Size(381, 142);
            dgvRegion.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre Region";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(500, 36);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(500, 83);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(228, 88);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 91);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // button2
            // 
            button2.Location = new Point(500, 125);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "RegionId";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "RegionName";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // habilitado
            // 
            habilitado.DataPropertyName = "Enabled";
            habilitado.HeaderText = "habilitado";
            habilitado.Name = "habilitado";
            habilitado.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(dgvRegion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private DataGridView dgvRegion;
        private Label label1;
        private Button btnCrear;
        private Button button1;
        private TextBox txtId;
        private Label label2;
        private Button button2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn habilitado;
    }
}
