
namespace agacOdev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dEkleLabel = new System.Windows.Forms.Label();
            this.dSilLabel = new System.Windows.Forms.Label();
            this.dDuzeyLabel = new System.Windows.Forms.Label();
            this.dEkleText = new System.Windows.Forms.TextBox();
            this.dSilText = new System.Windows.Forms.TextBox();
            this.dBulText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.aDugumTextBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bInOrderText = new System.Windows.Forms.Label();
            this.bPostOrderText = new System.Windows.Forms.Label();
            this.bPreOrder = new System.Windows.Forms.TextBox();
            this.bInOrder = new System.Windows.Forms.TextBox();
            this.bPostOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.aDugum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.aYukseklik = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bYapraklar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dEkleLabel
            // 
            this.dEkleLabel.AutoSize = true;
            this.dEkleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dEkleLabel.Location = new System.Drawing.Point(29, 26);
            this.dEkleLabel.Name = "dEkleLabel";
            this.dEkleLabel.Size = new System.Drawing.Size(0, 16);
            this.dEkleLabel.TabIndex = 0;
            // 
            // dSilLabel
            // 
            this.dSilLabel.AutoSize = true;
            this.dSilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dSilLabel.Location = new System.Drawing.Point(29, 66);
            this.dSilLabel.Name = "dSilLabel";
            this.dSilLabel.Size = new System.Drawing.Size(0, 16);
            this.dSilLabel.TabIndex = 1;
            // 
            // dDuzeyLabel
            // 
            this.dDuzeyLabel.AutoSize = true;
            this.dDuzeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dDuzeyLabel.Location = new System.Drawing.Point(29, 110);
            this.dDuzeyLabel.Name = "dDuzeyLabel";
            this.dDuzeyLabel.Size = new System.Drawing.Size(0, 16);
            this.dDuzeyLabel.TabIndex = 2;
            // 
            // dEkleText
            // 
            this.dEkleText.Location = new System.Drawing.Point(167, 22);
            this.dEkleText.Name = "dEkleText";
            this.dEkleText.Size = new System.Drawing.Size(100, 20);
            this.dEkleText.TabIndex = 3;
            // 
            // dSilText
            // 
            this.dSilText.Location = new System.Drawing.Point(167, 62);
            this.dSilText.Name = "dSilText";
            this.dSilText.Size = new System.Drawing.Size(100, 20);
            this.dSilText.TabIndex = 4;
            // 
            // dBulText
            // 
            this.dBulText.Location = new System.Drawing.Point(167, 106);
            this.dBulText.Name = "dBulText";
            this.dBulText.Size = new System.Drawing.Size(100, 20);
            this.dBulText.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Düğüm Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Düğüm Silme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Düğüm Bul";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(354, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Ağaçtaki Düğümleri Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // aDugumTextBox
            // 
            this.aDugumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aDugumTextBox.Location = new System.Drawing.Point(32, 263);
            this.aDugumTextBox.Name = "aDugumTextBox";
            this.aDugumTextBox.Size = new System.Drawing.Size(354, 266);
            this.aDugumTextBox.TabIndex = 10;
            this.aDugumTextBox.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(543, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(354, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Ağaçtaki Bilgilerini Göster";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(540, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ağaç Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(540, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Preorder";
            // 
            // bInOrderText
            // 
            this.bInOrderText.AutoSize = true;
            this.bInOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bInOrderText.Location = new System.Drawing.Point(540, 148);
            this.bInOrderText.Name = "bInOrderText";
            this.bInOrderText.Size = new System.Drawing.Size(50, 16);
            this.bInOrderText.TabIndex = 14;
            this.bInOrderText.Text = "Inorder";
            // 
            // bPostOrderText
            // 
            this.bPostOrderText.AutoSize = true;
            this.bPostOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bPostOrderText.Location = new System.Drawing.Point(540, 183);
            this.bPostOrderText.Name = "bPostOrderText";
            this.bPostOrderText.Size = new System.Drawing.Size(67, 16);
            this.bPostOrderText.TabIndex = 15;
            this.bPostOrderText.Text = "Postorder";
            // 
            // bPreOrder
            // 
            this.bPreOrder.Location = new System.Drawing.Point(624, 108);
            this.bPreOrder.Name = "bPreOrder";
            this.bPreOrder.Size = new System.Drawing.Size(273, 20);
            this.bPreOrder.TabIndex = 16;
            // 
            // bInOrder
            // 
            this.bInOrder.Location = new System.Drawing.Point(624, 144);
            this.bInOrder.Name = "bInOrder";
            this.bInOrder.Size = new System.Drawing.Size(273, 20);
            this.bInOrder.TabIndex = 17;
            // 
            // bPostOrder
            // 
            this.bPostOrder.Location = new System.Drawing.Point(624, 179);
            this.bPostOrder.Name = "bPostOrder";
            this.bPostOrder.Size = new System.Drawing.Size(273, 20);
            this.bPostOrder.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(540, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ağaçtaki Toplam Düğüm Sayısı";
            // 
            // aDugum
            // 
            this.aDugum.Location = new System.Drawing.Point(746, 284);
            this.aDugum.Name = "aDugum";
            this.aDugum.Size = new System.Drawing.Size(151, 20);
            this.aDugum.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(540, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ağacın Yüksekliği";
            // 
            // aYukseklik
            // 
            this.aYukseklik.Location = new System.Drawing.Point(746, 328);
            this.aYukseklik.Name = "aYukseklik";
            this.aYukseklik.Size = new System.Drawing.Size(151, 20);
            this.aYukseklik.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(540, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Yapraklar";
            // 
            // bYapraklar
            // 
            this.bYapraklar.Location = new System.Drawing.Point(746, 374);
            this.bYapraklar.Name = "bYapraklar";
            this.bYapraklar.Size = new System.Drawing.Size(151, 20);
            this.bYapraklar.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 573);
            this.Controls.Add(this.bYapraklar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.aYukseklik);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aDugum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bPostOrder);
            this.Controls.Add(this.bInOrder);
            this.Controls.Add(this.bPreOrder);
            this.Controls.Add(this.bPostOrderText);
            this.Controls.Add(this.bInOrderText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.aDugumTextBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dBulText);
            this.Controls.Add(this.dSilText);
            this.Controls.Add(this.dEkleText);
            this.Controls.Add(this.dDuzeyLabel);
            this.Controls.Add(this.dSilLabel);
            this.Controls.Add(this.dEkleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dEkleLabel;
        private System.Windows.Forms.Label dSilLabel;
        private System.Windows.Forms.Label dDuzeyLabel;
        private System.Windows.Forms.TextBox dEkleText;
        private System.Windows.Forms.TextBox dSilText;
        private System.Windows.Forms.TextBox dBulText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox aDugumTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bInOrderText;
        private System.Windows.Forms.Label bPostOrderText;
        private System.Windows.Forms.TextBox bPreOrder;
        private System.Windows.Forms.TextBox bInOrder;
        private System.Windows.Forms.TextBox bPostOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aDugum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox aYukseklik;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bYapraklar;
    }
}

