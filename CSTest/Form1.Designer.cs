namespace CSTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.load_information = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.input_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_work = new System.Windows.Forms.TextBox();
            this.input_information = new System.Windows.Forms.Button();
            this.input_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input_delete);
            this.panel1.Controls.Add(this.input_information);
            this.panel1.Controls.Add(this.input_work);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.input_year);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.input_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.input_num);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.load_information);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // load_information
            // 
            this.load_information.Location = new System.Drawing.Point(610, 237);
            this.load_information.Name = "load_information";
            this.load_information.Size = new System.Drawing.Size(176, 29);
            this.load_information.TabIndex = 1;
            this.load_information.Text = "불러오기";
            this.load_information.UseVisualStyleBackColor = true;
            this.load_information.Click += new System.EventHandler(this.load_information_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.num,
            this.name,
            this.year,
            this.work});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(604, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            // 
            // num
            // 
            this.num.HeaderText = "번호";
            this.num.Name = "num";
            this.num.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            // 
            // year
            // 
            this.year.HeaderText = "기수";
            this.year.Name = "year";
            // 
            // work
            // 
            this.work.HeaderText = "소속";
            this.work.Name = "work";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "번호";
            // 
            // input_num
            // 
            this.input_num.Location = new System.Drawing.Point(612, 24);
            this.input_num.Name = "input_num";
            this.input_num.Size = new System.Drawing.Size(176, 21);
            this.input_num.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "이름";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(612, 73);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(176, 21);
            this.input_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "기수";
            // 
            // input_year
            // 
            this.input_year.Location = new System.Drawing.Point(612, 126);
            this.input_year.Name = "input_year";
            this.input_year.Size = new System.Drawing.Size(176, 21);
            this.input_year.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "소속";
            // 
            // input_work
            // 
            this.input_work.Location = new System.Drawing.Point(612, 176);
            this.input_work.Name = "input_work";
            this.input_work.Size = new System.Drawing.Size(176, 21);
            this.input_work.TabIndex = 9;
            // 
            // input_information
            // 
            this.input_information.Location = new System.Drawing.Point(610, 203);
            this.input_information.Name = "input_information";
            this.input_information.Size = new System.Drawing.Size(178, 28);
            this.input_information.TabIndex = 10;
            this.input_information.Text = "입력넣기";
            this.input_information.UseVisualStyleBackColor = true;
            this.input_information.Click += new System.EventHandler(this.input_information_Click);
            // 
            // input_delete
            // 
            this.input_delete.Location = new System.Drawing.Point(610, 272);
            this.input_delete.Name = "input_delete";
            this.input_delete.Size = new System.Drawing.Size(176, 23);
            this.input_delete.TabIndex = 11;
            this.input_delete.Text = "삭제";
            this.input_delete.UseVisualStyleBackColor = true;
            this.input_delete.Click += new System.EventHandler(this.input_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button load_information;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn work;
        private System.Windows.Forms.TextBox input_work;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button input_information;
        private System.Windows.Forms.Button input_delete;
    }
}

