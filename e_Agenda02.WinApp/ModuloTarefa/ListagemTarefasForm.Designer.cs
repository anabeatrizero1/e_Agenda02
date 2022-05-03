namespace e_Agenda02.WinApp
{
    partial class ListagemTarefasForm
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
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.btnAtualizarItens = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrarItens = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTarefasPendentes = new System.Windows.Forms.Button();
            this.btnTarefasConcluidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(743, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tarefas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(704, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "e-Agenda 2.0";
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Location = new System.Drawing.Point(510, 12);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(177, 39);
            this.btnCompromissos.TabIndex = 27;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // brnContatos
            // 
            this.brnContatos.Location = new System.Drawing.Point(261, 12);
            this.brnContatos.Name = "brnContatos";
            this.brnContatos.Size = new System.Drawing.Size(177, 39);
            this.brnContatos.TabIndex = 26;
            this.brnContatos.Text = "Contatos";
            this.brnContatos.UseVisualStyleBackColor = true;
            this.brnContatos.Click += new System.EventHandler(this.brnContatos_Click);
            // 
            // brnTarefas
            // 
            this.brnTarefas.Location = new System.Drawing.Point(14, 12);
            this.brnTarefas.Name = "brnTarefas";
            this.brnTarefas.Size = new System.Drawing.Size(177, 39);
            this.brnTarefas.TabIndex = 25;
            this.brnTarefas.Text = "Tarefas";
            this.brnTarefas.UseVisualStyleBackColor = true;
            // 
            // listTarefas
            // 
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 20;
            this.listTarefas.Location = new System.Drawing.Point(24, 82);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(663, 364);
            this.listTarefas.TabIndex = 24;
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.Location = new System.Drawing.Point(704, 306);
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Size = new System.Drawing.Size(180, 40);
            this.btnAtualizarItens.TabIndex = 23;
            this.btnAtualizarItens.Text = "Atualizar Itens";
            this.btnAtualizarItens.UseVisualStyleBackColor = true;
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(704, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.Location = new System.Drawing.Point(704, 260);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(180, 40);
            this.btnCadastrarItens.TabIndex = 21;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = true;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(704, 214);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(180, 40);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(704, 122);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(180, 40);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir ";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(14, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(886, 393);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // btnTarefasPendentes
            // 
            this.btnTarefasPendentes.Location = new System.Drawing.Point(704, 398);
            this.btnTarefasPendentes.Name = "btnTarefasPendentes";
            this.btnTarefasPendentes.Size = new System.Drawing.Size(180, 40);
            this.btnTarefasPendentes.TabIndex = 31;
            this.btnTarefasPendentes.Text = "Tarefas Pendentes";
            this.btnTarefasPendentes.UseVisualStyleBackColor = true;
            this.btnTarefasPendentes.Click += new System.EventHandler(this.btnTarefasPendentes_Click);
            // 
            // btnTarefasConcluidas
            // 
            this.btnTarefasConcluidas.Location = new System.Drawing.Point(704, 352);
            this.btnTarefasConcluidas.Name = "btnTarefasConcluidas";
            this.btnTarefasConcluidas.Size = new System.Drawing.Size(180, 40);
            this.btnTarefasConcluidas.TabIndex = 32;
            this.btnTarefasConcluidas.Text = "Tarefas Concluidas";
            this.btnTarefasConcluidas.UseVisualStyleBackColor = true;
            this.btnTarefasConcluidas.Click += new System.EventHandler(this.btnTarefasConcluidas_Click);
            // 
            // ListagemTarefasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 473);
            this.Controls.Add(this.btnTarefasConcluidas);
            this.Controls.Add(this.btnTarefasPendentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.brnContatos);
            this.Controls.Add(this.brnTarefas);
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.btnAtualizarItens);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrarItens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListagemTarefasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompromissos;
        private System.Windows.Forms.Button brnContatos;
        private System.Windows.Forms.Button brnTarefas;
        private System.Windows.Forms.ListBox listTarefas;
        private System.Windows.Forms.Button btnAtualizarItens;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrarItens;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTarefasPendentes;
        private System.Windows.Forms.Button btnTarefasConcluidas;
    }
}