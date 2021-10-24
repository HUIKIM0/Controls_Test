
namespace Controls_Test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvHobby = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxHobby = new System.Windows.Forms.TextBox();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btndgvAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxMate = new System.Windows.Forms.ComboBox();
            this.cboxBoss = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnlbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvName,
            this.lvHobby,
            this.lvCity});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(287, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 336);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvName
            // 
            this.lvName.Text = "이름";
            // 
            // lvHobby
            // 
            this.lvHobby.Text = "취미";
            this.lvHobby.Width = 150;
            // 
            // lvCity
            // 
            this.lvCity.Text = "거주지역";
            this.lvCity.Width = 90;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "데이터추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "데이터삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(38, 69);
            this.tboxName.Multiline = true;
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(163, 26);
            this.tboxName.TabIndex = 3;
            // 
            // tboxHobby
            // 
            this.tboxHobby.Location = new System.Drawing.Point(38, 143);
            this.tboxHobby.Multiline = true;
            this.tboxHobby.Name = "tboxHobby";
            this.tboxHobby.Size = new System.Drawing.Size(163, 26);
            this.tboxHobby.TabIndex = 4;
            // 
            // tboxCity
            // 
            this.tboxCity.Location = new System.Drawing.Point(38, 220);
            this.tboxCity.Multiline = true;
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(163, 26);
            this.tboxCity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "취미";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "거주지역";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(765, 39);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 27;
            this.dgv1.Size = new System.Drawing.Size(314, 336);
            this.dgv1.TabIndex = 9;
            // 
            // btndgvAdd
            // 
            this.btndgvAdd.Location = new System.Drawing.Point(1096, 192);
            this.btndgvAdd.Name = "btndgvAdd";
            this.btndgvAdd.Size = new System.Drawing.Size(114, 35);
            this.btndgvAdd.TabIndex = 10;
            this.btndgvAdd.Text = "dgv데이터추가";
            this.btndgvAdd.UseVisualStyleBackColor = true;
            this.btndgvAdd.Click += new System.EventHandler(this.btndgvAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1093, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "투표자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1093, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "후보자";
            // 
            // cboxMate
            // 
            this.cboxMate.FormattingEnabled = true;
            this.cboxMate.Location = new System.Drawing.Point(1096, 80);
            this.cboxMate.Name = "cboxMate";
            this.cboxMate.Size = new System.Drawing.Size(121, 23);
            this.cboxMate.TabIndex = 15;
            // 
            // cboxBoss
            // 
            this.cboxBoss.FormattingEnabled = true;
            this.cboxBoss.Location = new System.Drawing.Point(1096, 146);
            this.cboxBoss.Name = "cboxBoss";
            this.cboxBoss.Size = new System.Drawing.Size(121, 23);
            this.cboxBoss.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(287, 408);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 94);
            this.listBox1.TabIndex = 17;
            // 
            // btnlbox
            // 
            this.btnlbox.Location = new System.Drawing.Point(765, 467);
            this.btnlbox.Name = "btnlbox";
            this.btnlbox.Size = new System.Drawing.Size(122, 34);
            this.btnlbox.TabIndex = 18;
            this.btnlbox.Text = "lbox데이터추가";
            this.btnlbox.UseVisualStyleBackColor = true;
            this.btnlbox.Click += new System.EventHandler(this.btnlbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 542);
            this.Controls.Add(this.btnlbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cboxBoss);
            this.Controls.Add(this.cboxMate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndgvAdd);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.tboxHobby);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvName;
        private System.Windows.Forms.ColumnHeader lvHobby;
        private System.Windows.Forms.ColumnHeader lvCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxHobby;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btndgvAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxMate;
        private System.Windows.Forms.ComboBox cboxBoss;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnlbox;
    }
}

