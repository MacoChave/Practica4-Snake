﻿namespace Practica_Snake
{
    partial class UsuarioForm
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtPts = new System.Windows.Forms.TextBox();
            this.lblPts = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Location = new System.Drawing.Point(125, 40);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(245, 29);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(48, 43);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 23);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtNivel
            // 
            this.txtNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txtNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNivel.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNivel.Location = new System.Drawing.Point(125, 154);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(67, 29);
            this.txtNivel.TabIndex = 5;
            this.txtNivel.TextChanged += new System.EventHandler(this.txtNivel_TextChanged);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNivel.Location = new System.Drawing.Point(48, 157);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(50, 23);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nivel";
            // 
            // txtPts
            // 
            this.txtPts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txtPts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPts.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPts.Location = new System.Drawing.Point(125, 207);
            this.txtPts.Name = "txtPts";
            this.txtPts.ReadOnly = true;
            this.txtPts.Size = new System.Drawing.Size(67, 29);
            this.txtPts.TabIndex = 7;
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPts.Location = new System.Drawing.Point(48, 210);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(62, 23);
            this.lblPts.TabIndex = 6;
            this.lblPts.Text = "Puntos";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(103)))), ((int)(((byte)(130)))));
            this.txtTiempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempo.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTiempo.Location = new System.Drawing.Point(398, 93);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(67, 29);
            this.txtTiempo.TabIndex = 9;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempo.Location = new System.Drawing.Point(322, 96);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(70, 23);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "Tiempo";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Goudy Old Style", 21.75F);
            this.btnIniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.Location = new System.Drawing.Point(52, 337);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(140, 80);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar Juego";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSalir.Enabled = false;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Goudy Old Style", 21.75F);
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Location = new System.Drawing.Point(292, 337);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 80);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(495, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 500);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Snake";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 481);
            this.panel1.TabIndex = 0;
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1006, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtPts);
            this.Controls.Add(this.lblPts);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsuarioForm_KeyDown_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtPts;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}