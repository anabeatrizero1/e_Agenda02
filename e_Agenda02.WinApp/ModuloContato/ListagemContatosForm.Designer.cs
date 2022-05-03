namespace e_Agenda02.WinApp
{
    partial class ListagemContatosForm
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
            this.listContatos = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnVisualizarDetalhes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(737, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Contatos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(702, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "e-Agenda 2.0";
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Location = new System.Drawing.Point(505, 12);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(177, 39);
            this.btnCompromissos.TabIndex = 39;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // brnContatos
            // 
            this.brnContatos.Location = new System.Drawing.Point(257, 12);
            this.brnContatos.Name = "brnContatos";
            this.brnContatos.Size = new System.Drawing.Size(177, 39);
            this.brnContatos.TabIndex = 38;
            this.brnContatos.Text = "Contatos";
            this.brnContatos.UseVisualStyleBackColor = true;
            // 
            // brnTarefas
            // 
            this.brnTarefas.Location = new System.Drawing.Point(12, 12);
            this.brnTarefas.Name = "brnTarefas";
            this.brnTarefas.Size = new System.Drawing.Size(177, 39);
            this.brnTarefas.TabIndex = 37;
            this.brnTarefas.Text = "Tarefas";
            this.brnTarefas.UseVisualStyleBackColor = true;
            this.brnTarefas.Click += new System.EventHandler(this.brnTarefas_Click);
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 20;
            this.listContatos.Location = new System.Drawing.Point(22, 82);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(660, 364);
            this.listContatos.TabIndex = 36;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(702, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(702, 214);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 40);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(702, 122);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(180, 40);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir ";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(888, 397);
            this.richTextBox1.TabIndex = 41;
            this.richTextBox1.Text = "";
            // 
            // btnVisualizarDetalhes
            // 
            this.btnVisualizarDetalhes.Location = new System.Drawing.Point(702, 260);
            this.btnVisualizarDetalhes.Name = "btnVisualizarDetalhes";
            this.btnVisualizarDetalhes.Size = new System.Drawing.Size(180, 40);
            this.btnVisualizarDetalhes.TabIndex = 43;
            this.btnVisualizarDetalhes.Text = "Visualizar Detalhes";
            this.btnVisualizarDetalhes.UseVisualStyleBackColor = true;
            this.btnVisualizarDetalhes.Click += new System.EventHandler(this.btnVisualizarDetalhes_Click);
            // 
            // ListagemContatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.btnVisualizarDetalhes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.brnContatos);
            this.Controls.Add(this.brnTarefas);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagemContatosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Button brnContatos;
        private System.Windows.Forms.Button brnTarefas;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnVisualizarDetalhes;
    }
}