namespace forms;

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
            this.lblPunto1 = new System.Windows.Forms.Label();
            this.btnCrearRecta = new System.Windows.Forms.Button();
            this.grpboxRecta = new System.Windows.Forms.GroupBox();
            this.numY2 = new System.Windows.Forms.NumericUpDown();
            this.numX2 = new System.Windows.Forms.NumericUpDown();
            this.numY1 = new System.Windows.Forms.NumericUpDown();
            this.numX1 = new System.Windows.Forms.NumericUpDown();
            this.lblLineaCreadaAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPunto2 = new System.Windows.Forms.Label();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.grpboxOperaciones = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloResultados = new System.Windows.Forms.Label();
            this.lblPuntoMedioRecta = new System.Windows.Forms.Label();
            this.lblPendienteRecta = new System.Windows.Forms.Label();
            this.btnPuntoMedioRecta = new System.Windows.Forms.Button();
            this.btnPendienteRecta = new System.Windows.Forms.Button();
            this.btnDistanciaPuntos = new System.Windows.Forms.Button();
            this.lblDistanciaPuntos = new System.Windows.Forms.Label();
            this.grpboxCreditos = new System.Windows.Forms.GroupBox();
            this.lblDiana = new System.Windows.Forms.Label();
            this.lblKristan = new System.Windows.Forms.Label();
            this.grpboxRecta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).BeginInit();
            this.grpboxOperaciones.SuspendLayout();
            this.grpboxCreditos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPunto1
            // 
            this.lblPunto1.AutoSize = true;
            this.lblPunto1.Location = new System.Drawing.Point(15, 65);
            this.lblPunto1.Name = "lblPunto1";
            this.lblPunto1.Size = new System.Drawing.Size(58, 20);
            this.lblPunto1.TabIndex = 0;
            this.lblPunto1.Text = "Punto1:";
            // 
            // btnCrearRecta
            // 
            this.btnCrearRecta.Location = new System.Drawing.Point(15, 26);
            this.btnCrearRecta.Name = "btnCrearRecta";
            this.btnCrearRecta.Size = new System.Drawing.Size(116, 36);
            this.btnCrearRecta.TabIndex = 1;
            this.btnCrearRecta.Text = "Crear Recta";
            this.btnCrearRecta.UseVisualStyleBackColor = true;
            this.btnCrearRecta.Click += new System.EventHandler(this.btnCrearRecta_Click);
            // 
            // grpboxRecta
            // 
            this.grpboxRecta.Controls.Add(this.numY2);
            this.grpboxRecta.Controls.Add(this.numX2);
            this.grpboxRecta.Controls.Add(this.numY1);
            this.grpboxRecta.Controls.Add(this.numX1);
            this.grpboxRecta.Controls.Add(this.lblLineaCreadaAviso);
            this.grpboxRecta.Controls.Add(this.label1);
            this.grpboxRecta.Controls.Add(this.label2);
            this.grpboxRecta.Controls.Add(this.lblPunto2);
            this.grpboxRecta.Controls.Add(this.lblY1);
            this.grpboxRecta.Controls.Add(this.lblX1);
            this.grpboxRecta.Controls.Add(this.btnCrearRecta);
            this.grpboxRecta.Controls.Add(this.lblPunto1);
            this.grpboxRecta.Location = new System.Drawing.Point(12, 12);
            this.grpboxRecta.Name = "grpboxRecta";
            this.grpboxRecta.Size = new System.Drawing.Size(370, 259);
            this.grpboxRecta.TabIndex = 2;
            this.grpboxRecta.TabStop = false;
            this.grpboxRecta.Text = "Recta";
            // 
            // numY2
            // 
            this.numY2.Location = new System.Drawing.Point(214, 165);
            this.numY2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numY2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numY2.Name = "numY2";
            this.numY2.Size = new System.Drawing.Size(150, 27);
            this.numY2.TabIndex = 16;
            this.numY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numX2
            // 
            this.numX2.Location = new System.Drawing.Point(37, 165);
            this.numX2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numX2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numX2.Name = "numX2";
            this.numX2.Size = new System.Drawing.Size(150, 27);
            this.numX2.TabIndex = 15;
            this.numX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numY1
            // 
            this.numY1.Location = new System.Drawing.Point(214, 94);
            this.numY1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numY1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numY1.Name = "numY1";
            this.numY1.Size = new System.Drawing.Size(150, 27);
            this.numY1.TabIndex = 14;
            this.numY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numX1
            // 
            this.numX1.Location = new System.Drawing.Point(37, 94);
            this.numX1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numX1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numX1.Name = "numX1";
            this.numX1.Size = new System.Drawing.Size(150, 27);
            this.numX1.TabIndex = 13;
            this.numX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLineaCreadaAviso
            // 
            this.lblLineaCreadaAviso.AutoSize = true;
            this.lblLineaCreadaAviso.Location = new System.Drawing.Point(94, 216);
            this.lblLineaCreadaAviso.Name = "lblLineaCreadaAviso";
            this.lblLineaCreadaAviso.Size = new System.Drawing.Size(173, 20);
            this.lblLineaCreadaAviso.TabIndex = 12;
            this.lblLineaCreadaAviso.Text = "TextoPruebaLineaCreada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "X:";
            // 
            // lblPunto2
            // 
            this.lblPunto2.AutoSize = true;
            this.lblPunto2.Location = new System.Drawing.Point(15, 137);
            this.lblPunto2.Name = "lblPunto2";
            this.lblPunto2.Size = new System.Drawing.Size(62, 20);
            this.lblPunto2.TabIndex = 7;
            this.lblPunto2.Text = "Punto 2:";
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Location = new System.Drawing.Point(193, 96);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(20, 20);
            this.lblY1.TabIndex = 6;
            this.lblY1.Text = "Y:";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(15, 96);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(21, 20);
            this.lblX1.TabIndex = 5;
            this.lblX1.Text = "X:";
            // 
            // grpboxOperaciones
            // 
            this.grpboxOperaciones.Controls.Add(this.lblResultado);
            this.grpboxOperaciones.Controls.Add(this.lblTituloResultados);
            this.grpboxOperaciones.Controls.Add(this.lblPuntoMedioRecta);
            this.grpboxOperaciones.Controls.Add(this.lblPendienteRecta);
            this.grpboxOperaciones.Controls.Add(this.btnPuntoMedioRecta);
            this.grpboxOperaciones.Controls.Add(this.btnPendienteRecta);
            this.grpboxOperaciones.Controls.Add(this.btnDistanciaPuntos);
            this.grpboxOperaciones.Controls.Add(this.lblDistanciaPuntos);
            this.grpboxOperaciones.Location = new System.Drawing.Point(421, 12);
            this.grpboxOperaciones.Name = "grpboxOperaciones";
            this.grpboxOperaciones.Size = new System.Drawing.Size(330, 393);
            this.grpboxOperaciones.TabIndex = 3;
            this.grpboxOperaciones.TabStop = false;
            this.grpboxOperaciones.Text = "Operaciones";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(100, 278);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(93, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "--------------";
            // 
            // lblTituloResultados
            // 
            this.lblTituloResultados.AutoSize = true;
            this.lblTituloResultados.Location = new System.Drawing.Point(115, 230);
            this.lblTituloResultados.Name = "lblTituloResultados";
            this.lblTituloResultados.Size = new System.Drawing.Size(78, 20);
            this.lblTituloResultados.TabIndex = 4;
            this.lblTituloResultados.Text = "Resultado:";
            // 
            // lblPuntoMedioRecta
            // 
            this.lblPuntoMedioRecta.AutoSize = true;
            this.lblPuntoMedioRecta.Location = new System.Drawing.Point(129, 172);
            this.lblPuntoMedioRecta.Name = "lblPuntoMedioRecta";
            this.lblPuntoMedioRecta.Size = new System.Drawing.Size(180, 20);
            this.lblPuntoMedioRecta.TabIndex = 5;
            this.lblPuntoMedioRecta.Text = "Punto medio de una recta";
            // 
            // lblPendienteRecta
            // 
            this.lblPendienteRecta.AutoSize = true;
            this.lblPendienteRecta.Location = new System.Drawing.Point(129, 118);
            this.lblPendienteRecta.Name = "lblPendienteRecta";
            this.lblPendienteRecta.Size = new System.Drawing.Size(160, 20);
            this.lblPendienteRecta.TabIndex = 4;
            this.lblPendienteRecta.Text = "Pendiente de una recta";
            // 
            // btnPuntoMedioRecta
            // 
            this.btnPuntoMedioRecta.Location = new System.Drawing.Point(20, 168);
            this.btnPuntoMedioRecta.Name = "btnPuntoMedioRecta";
            this.btnPuntoMedioRecta.Size = new System.Drawing.Size(94, 29);
            this.btnPuntoMedioRecta.TabIndex = 3;
            this.btnPuntoMedioRecta.Text = "Calcular";
            this.btnPuntoMedioRecta.UseVisualStyleBackColor = true;
            this.btnPuntoMedioRecta.Click += new System.EventHandler(this.btnPuntoMedioRecta_Click);
            // 
            // btnPendienteRecta
            // 
            this.btnPendienteRecta.Location = new System.Drawing.Point(20, 114);
            this.btnPendienteRecta.Name = "btnPendienteRecta";
            this.btnPendienteRecta.Size = new System.Drawing.Size(94, 29);
            this.btnPendienteRecta.TabIndex = 2;
            this.btnPendienteRecta.Text = "Calcular";
            this.btnPendienteRecta.UseVisualStyleBackColor = true;
            this.btnPendienteRecta.Click += new System.EventHandler(this.btnPendienteRecta_Click);
            // 
            // btnDistanciaPuntos
            // 
            this.btnDistanciaPuntos.Location = new System.Drawing.Point(20, 56);
            this.btnDistanciaPuntos.Name = "btnDistanciaPuntos";
            this.btnDistanciaPuntos.Size = new System.Drawing.Size(94, 29);
            this.btnDistanciaPuntos.TabIndex = 1;
            this.btnDistanciaPuntos.Text = "Calcular";
            this.btnDistanciaPuntos.UseVisualStyleBackColor = true;
            this.btnDistanciaPuntos.Click += new System.EventHandler(this.btnDistanciaPuntos_Click);
            // 
            // lblDistanciaPuntos
            // 
            this.lblDistanciaPuntos.AutoSize = true;
            this.lblDistanciaPuntos.Location = new System.Drawing.Point(129, 60);
            this.lblDistanciaPuntos.Name = "lblDistanciaPuntos";
            this.lblDistanciaPuntos.Size = new System.Drawing.Size(185, 20);
            this.lblDistanciaPuntos.TabIndex = 0;
            this.lblDistanciaPuntos.Text = "Distancia entre dos puntos";
            // 
            // grpboxCreditos
            // 
            this.grpboxCreditos.Controls.Add(this.lblDiana);
            this.grpboxCreditos.Controls.Add(this.lblKristan);
            this.grpboxCreditos.Location = new System.Drawing.Point(12, 305);
            this.grpboxCreditos.Name = "grpboxCreditos";
            this.grpboxCreditos.Size = new System.Drawing.Size(370, 100);
            this.grpboxCreditos.TabIndex = 4;
            this.grpboxCreditos.TabStop = false;
            this.grpboxCreditos.Text = "Créditos";
            // 
            // lblDiana
            // 
            this.lblDiana.AutoSize = true;
            this.lblDiana.Location = new System.Drawing.Point(32, 58);
            this.lblDiana.Name = "lblDiana";
            this.lblDiana.Size = new System.Drawing.Size(206, 20);
            this.lblDiana.TabIndex = 1;
            this.lblDiana.Text = "Diana Yulissa Sesma Santiago";
            // 
            // lblKristan
            // 
            this.lblKristan.AutoSize = true;
            this.lblKristan.Location = new System.Drawing.Point(32, 38);
            this.lblKristan.Name = "lblKristan";
            this.lblKristan.Size = new System.Drawing.Size(131, 20);
            this.lblKristan.TabIndex = 0;
            this.lblKristan.Text = "Kristan Ruíz Limón";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpboxCreditos);
            this.Controls.Add(this.grpboxOperaciones);
            this.Controls.Add(this.grpboxRecta);
            this.Name = "Form1";
            this.Text = "Calculadora de rectas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxRecta.ResumeLayout(false);
            this.grpboxRecta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX1)).EndInit();
            this.grpboxOperaciones.ResumeLayout(false);
            this.grpboxOperaciones.PerformLayout();
            this.grpboxCreditos.ResumeLayout(false);
            this.grpboxCreditos.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Label lblPunto1;
    private Button btnCrearRecta;
    private GroupBox grpboxRecta;
    private Label label1;
    private Label label2;
    private Label lblPunto2;
    private Label lblY1;
    private Label lblX1;
    private Label lblLineaCreadaAviso;
    private GroupBox grpboxOperaciones;
    private Label lblDistanciaPuntos;
    private Label lblResultado;
    private Label lblTituloResultados;
    private Label lblPuntoMedioRecta;
    private Label lblPendienteRecta;
    private Button btnPuntoMedioRecta;
    private Button btnPendienteRecta;
    private Button btnDistanciaPuntos;
    private GroupBox grpboxCreditos;
    private Label lblDiana;
    private Label lblKristan;
    private NumericUpDown numY2;
    private NumericUpDown numX2;
    private NumericUpDown numY1;
    private NumericUpDown numX1;
}
