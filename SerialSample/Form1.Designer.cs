namespace SerialSample
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputLabel = new System.Windows.Forms.Label();
            this.cbSerials = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.baudLabel = new System.Windows.Forms.Label();
            this.baudCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textRecibidos = new System.Windows.Forms.RichTextBox();
            this.puertoSerial = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.dataBitsBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dissConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.Location = new System.Drawing.Point(35, 38);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(124, 23);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Puertos Seriales: ";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSerials
            // 
            this.cbSerials.FormattingEnabled = true;
            this.cbSerials.Location = new System.Drawing.Point(165, 38);
            this.cbSerials.Name = "cbSerials";
            this.cbSerials.Size = new System.Drawing.Size(213, 24);
            this.cbSerials.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(408, 31);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(97, 37);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Resfrescar";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.resfreshClick);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(580, 28);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(148, 42);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectClick);
            // 
            // baudLabel
            // 
            this.baudLabel.Location = new System.Drawing.Point(35, 86);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(124, 23);
            this.baudLabel.TabIndex = 4;
            this.baudLabel.Text = "Baud Rate:";
            this.baudLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baudCombo
            // 
            this.baudCombo.FormattingEnabled = true;
            this.baudCombo.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudCombo.Location = new System.Drawing.Point(165, 86);
            this.baudCombo.Name = "baudCombo";
            this.baudCombo.Size = new System.Drawing.Size(213, 24);
            this.baudCombo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Datos Recibidos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textRecibidos
            // 
            this.textRecibidos.Location = new System.Drawing.Point(180, 250);
            this.textRecibidos.Name = "textRecibidos";
            this.textRecibidos.Size = new System.Drawing.Size(409, 85);
            this.textRecibidos.TabIndex = 7;
            this.textRecibidos.Text = "";
            // 
            // puertoSerial
            // 
            this.puertoSerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataRecibida);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "DataBits:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // parityBox
            // 
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.parityBox.Location = new System.Drawing.Point(165, 176);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(212, 24);
            this.parityBox.TabIndex = 10;
            // 
            // dataBitsBox
            // 
            this.dataBitsBox.FormattingEnabled = true;
            this.dataBitsBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitsBox.Location = new System.Drawing.Point(166, 134);
            this.dataBitsBox.Name = "dataBitsBox";
            this.dataBitsBox.Size = new System.Drawing.Size(212, 24);
            this.dataBitsBox.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(408, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Discard Null";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dissConnect
            // 
            this.dissConnect.Location = new System.Drawing.Point(580, 89);
            this.dissConnect.Name = "dissConnect";
            this.dissConnect.Size = new System.Drawing.Size(148, 42);
            this.dissConnect.TabIndex = 14;
            this.dissConnect.Text = "Desconectar";
            this.dissConnect.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 358);
            this.Controls.Add(this.dissConnect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataBitsBox);
            this.Controls.Add(this.parityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRecibidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudCombo);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.cbSerials);
            this.Controls.Add(this.inputLabel);
            this.Name = "MainForm";
            this.Text = "Configuracion de Serial Port";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.ComboBox cbSerials;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.ComboBox baudCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textRecibidos;
        private System.IO.Ports.SerialPort puertoSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox parityBox;
        private System.Windows.Forms.ComboBox dataBitsBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button dissConnect;
    }
}

