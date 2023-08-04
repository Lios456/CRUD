namespace Interaz7
{
    partial class Principal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btinsertar = new Button();
            btleer = new Button();
            btmodificar = new Button();
            btborrar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btinsertar, 0, 0);
            tableLayoutPanel1.Controls.Add(btleer, 0, 1);
            tableLayoutPanel1.Controls.Add(btmodificar, 0, 2);
            tableLayoutPanel1.Controls.Add(btborrar, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(324, 405);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btinsertar
            // 
            btinsertar.Dock = DockStyle.Fill;
            btinsertar.Location = new Point(3, 3);
            btinsertar.Name = "btinsertar";
            btinsertar.Size = new Size(318, 95);
            btinsertar.TabIndex = 0;
            btinsertar.Text = "Insertar";
            btinsertar.UseVisualStyleBackColor = true;
            btinsertar.Click += btinsertar_Click;
            // 
            // btleer
            // 
            btleer.Dock = DockStyle.Fill;
            btleer.Location = new Point(3, 104);
            btleer.Name = "btleer";
            btleer.Size = new Size(318, 95);
            btleer.TabIndex = 1;
            btleer.Text = "Visualizar";
            btleer.UseVisualStyleBackColor = true;
            btleer.Click += btleer_Click;
            // 
            // btmodificar
            // 
            btmodificar.Dock = DockStyle.Fill;
            btmodificar.Location = new Point(3, 205);
            btmodificar.Name = "btmodificar";
            btmodificar.Size = new Size(318, 95);
            btmodificar.TabIndex = 2;
            btmodificar.Text = "Modificar";
            btmodificar.UseVisualStyleBackColor = true;
            btmodificar.Click += btmodificar_Click;
            // 
            // btborrar
            // 
            btborrar.Dock = DockStyle.Fill;
            btborrar.Location = new Point(3, 306);
            btborrar.Name = "btborrar";
            btborrar.Size = new Size(318, 96);
            btborrar.TabIndex = 3;
            btborrar.Text = "Eliminar";
            btborrar.UseVisualStyleBackColor = true;
            btborrar.Click += btborrar_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 405);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Principal";
            Text = "Inicio";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btinsertar;
        private Button btleer;
        private Button btmodificar;
        private Button btborrar;
    }
}