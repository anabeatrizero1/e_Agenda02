namespace e_Agenda02.WinApp.ModuloCompromisso
{
    partial class LIstagemCompromissosForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.brnContatos = new System.Windows.Forms.Button();
            this.brnTarefas = new System.Windows.Forms.Button();
            this.listCompromisso = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCompromissosFuturos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerTermino = new System.Windows.Forms.DateTimePicker();
            this.datePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCompromissosPassados = new System.Windows.Forms.Button();
            this.btnTodosCompromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(703, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 52;
            this.label2.Text = "Compromissos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(720, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 50;
            this.label1.Text = "e-Agenda 2.0";
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Location = new System.Drawing.Point(511, 12);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(177, 39);
            this.btnCompromissos.TabIndex = 49;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            // 
            // brnContatos
            // 
            this.brnContatos.Location = new System.Drawing.Point(262, 12);
            this.brnContatos.Name = "brnContatos";
            this.brnContatos.Size = new System.Drawing.Size(177, 39);
            this.brnContatos.TabIndex = 48;
            this.brnContatos.Text = "Contatos";
            this.brnContatos.UseVisualStyleBackColor = true;
            this.brnContatos.Click += new System.EventHandler(this.brnContatos_Click);
            // 
            // brnTarefas
            // 
            this.brnTarefas.Location = new System.Drawing.Point(12, 12);
            this.brnTarefas.Name = "brnTarefas";
            this.brnTarefas.Size = new System.Drawing.Size(177, 39);
            this.brnTarefas.TabIndex = 47;
            this.brnTarefas.Text = "Tarefas";
            this.brnTarefas.UseVisualStyleBackColor = true;
            this.brnTarefas.Click += new System.EventHandler(this.brnTarefas_Click);
            // 
            // listCompromisso
            // 
            this.listCompromisso.FormattingEnabled = true;
            this.listCompromisso.ItemHeight = 20;
            this.listCompromisso.Location = new System.Drawing.Point(22, 82);
            this.listCompromisso.Name = "listCompromisso";
            this.listCompromisso.Size = new System.Drawing.Size(666, 324);
            this.listCompromisso.TabIndex = 46;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(705, 182);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.TabIndex = 45;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(705, 228);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 40);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(705, 136);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(180, 40);
            this.btnInserir.TabIndex = 43;
            this.btnInserir.Text = "Inserir ";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(888, 443);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // btnCompromissosFuturos
            // 
            this.btnCompromissosFuturos.Location = new System.Drawing.Point(705, 320);
            this.btnCompromissosFuturos.Name = "btnCompromissosFuturos";
            this.btnCompromissosFuturos.Size = new System.Drawing.Size(180, 40);
            this.btnCompromissosFuturos.TabIndex = 53;
            this.btnCompromissosFuturos.Text = "Compromissos Futuros";
            this.btnCompromissosFuturos.UseVisualStyleBackColor = true;
            this.btnCompromissosFuturos.Click += new System.EventHandler(this.btnCompromissosFuturos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Filtrar por Priodo";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Location = new System.Drawing.Point(267, 474);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 26);
            this.btnFiltrar.TabIndex = 58;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(141, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Data de Termino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data de Inicio";
            // 
            // datePickerTermino
            // 
            this.datePickerTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTermino.Location = new System.Drawing.Point(141, 473);
            this.datePickerTermino.Name = "datePickerTermino";
            this.datePickerTermino.Size = new System.Drawing.Size(120, 27);
            this.datePickerTermino.TabIndex = 55;
            // 
            // datePickerInicio
            // 
            this.datePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerInicio.Location = new System.Drawing.Point(22, 473);
            this.datePickerInicio.MinDate = new System.DateTime(2022, 5, 3, 0, 0, 0, 0);
            this.datePickerInicio.Name = "datePickerInicio";
            this.datePickerInicio.Size = new System.Drawing.Size(113, 27);
            this.datePickerInicio.TabIndex = 54;
            // 
            // btnCompromissosPassados
            // 
            this.btnCompromissosPassados.Location = new System.Drawing.Point(705, 274);
            this.btnCompromissosPassados.Name = "btnCompromissosPassados";
            this.btnCompromissosPassados.Size = new System.Drawing.Size(180, 40);
            this.btnCompromissosPassados.TabIndex = 60;
            this.btnCompromissosPassados.Text = "Compromissos Passados";
            this.btnCompromissosPassados.UseVisualStyleBackColor = true;
            this.btnCompromissosPassados.Click += new System.EventHandler(this.btnCompromissosPassados_Click);
            // 
            // btnTodosCompromissos
            // 
            this.btnTodosCompromissos.Location = new System.Drawing.Point(705, 366);
            this.btnTodosCompromissos.Name = "btnTodosCompromissos";
            this.btnTodosCompromissos.Size = new System.Drawing.Size(180, 40);
            this.btnTodosCompromissos.TabIndex = 61;
            this.btnTodosCompromissos.Text = "Visualizar Todos";
            this.btnTodosCompromissos.UseVisualStyleBackColor = true;
            this.btnTodosCompromissos.Click += new System.EventHandler(this.btnTodosCompromissos_Click);
            // 
            // LIstagemCompromissosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 524);
            this.Controls.Add(this.btnTodosCompromissos);
            this.Controls.Add(this.btnCompromissosPassados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePickerTermino);
            this.Controls.Add(this.datePickerInicio);
            this.Controls.Add(this.btnCompromissosFuturos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.brnContatos);
            this.Controls.Add(this.brnTarefas);
            this.Controls.Add(this.listCompromisso);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LIstagemCompromissosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIstagem de Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Button brnContatos;
        private System.Windows.Forms.Button brnTarefas;
        private System.Windows.Forms.ListBox listCompromisso;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCompromissosFuturos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerTermino;
        private System.Windows.Forms.DateTimePicker datePickerInicio;
        private System.Windows.Forms.Button btnCompromissosPassados;
        private System.Windows.Forms.Button btnTodosCompromissos;
    }
}