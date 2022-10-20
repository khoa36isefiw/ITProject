namespace Final_1__Library.FORMS
{
    partial class Book_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Close = new System.Windows.Forms.Label();
            this.btn_Bookheader = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.Lb_typeFind = new System.Windows.Forms.ComboBox();
            this.panel_Infor = new System.Windows.Forms.Panel();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Pic_Book = new System.Windows.Forms.PictureBox();
            this.Dtp_Updateday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Pricebook = new System.Windows.Forms.TextBox();
            this.txt_Idbook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Publisher = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt_nbook = new System.Windows.Forms.TextBox();
            this.txt_AuthorBook = new System.Windows.Forms.TextBox();
            this.txt_Namebook = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBOOK = new System.Windows.Forms.DataGridView();
            this.label_Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_PrintDT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOOK)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.Label_Close);
            this.panel1.Controls.Add(this.btn_Bookheader);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label_Header);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 904);
            this.panel1.TabIndex = 0;
            // 
            // Label_Close
            // 
            this.Label_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Close.ForeColor = System.Drawing.Color.White;
            this.Label_Close.Location = new System.Drawing.Point(1384, 10);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(47, 43);
            this.Label_Close.TabIndex = 9;
            this.Label_Close.Text = "X";
            this.Label_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            // 
            // btn_Bookheader
            // 
            this.btn_Bookheader.BackColor = System.Drawing.Color.Orange;
            this.btn_Bookheader.FlatAppearance.BorderSize = 0;
            this.btn_Bookheader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bookheader.Location = new System.Drawing.Point(11, 10);
            this.btn_Bookheader.Name = "btn_Bookheader";
            this.btn_Bookheader.Size = new System.Drawing.Size(78, 80);
            this.btn_Bookheader.TabIndex = 8;
            this.btn_Bookheader.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.btn_PrintDT);
            this.panel3.Controls.Add(this.btn_Back);
            this.panel3.Controls.Add(this.Lb_typeFind);
            this.panel3.Controls.Add(this.panel_Infor);
            this.panel3.Controls.Add(this.Btn_Find);
            this.panel3.Controls.Add(this.txt_Find);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dgvBOOK);
            this.panel3.Location = new System.Drawing.Point(228, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1318, 805);
            this.panel3.TabIndex = 7;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(18, 676);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(88, 74);
            this.btn_Back.TabIndex = 83;
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Lb_typeFind
            // 
            this.Lb_typeFind.FormattingEnabled = true;
            this.Lb_typeFind.Location = new System.Drawing.Point(646, 16);
            this.Lb_typeFind.Name = "Lb_typeFind";
            this.Lb_typeFind.Size = new System.Drawing.Size(147, 24);
            this.Lb_typeFind.TabIndex = 66;
            // 
            // panel_Infor
            // 
            this.panel_Infor.Controls.Add(this.txt_Type);
            this.panel_Infor.Controls.Add(this.btn_UploadImage);
            this.panel_Infor.Controls.Add(this.label2);
            this.panel_Infor.Controls.Add(this.Pic_Book);
            this.panel_Infor.Controls.Add(this.Dtp_Updateday);
            this.panel_Infor.Controls.Add(this.label1);
            this.panel_Infor.Controls.Add(this.Description);
            this.panel_Infor.Controls.Add(this.txt_Description);
            this.panel_Infor.Controls.Add(this.label10);
            this.panel_Infor.Controls.Add(this.txt_Pricebook);
            this.panel_Infor.Controls.Add(this.txt_Idbook);
            this.panel_Infor.Controls.Add(this.label11);
            this.panel_Infor.Controls.Add(this.label12);
            this.panel_Infor.Controls.Add(this.lbl5);
            this.panel_Infor.Controls.Add(this.label13);
            this.panel_Infor.Controls.Add(this.txt_Publisher);
            this.panel_Infor.Controls.Add(this.lbl4);
            this.panel_Infor.Controls.Add(this.txt_nbook);
            this.panel_Infor.Controls.Add(this.txt_AuthorBook);
            this.panel_Infor.Controls.Add(this.txt_Namebook);
            this.panel_Infor.Controls.Add(this.lbl3);
            this.panel_Infor.Location = new System.Drawing.Point(3, 14);
            this.panel_Infor.Name = "panel_Infor";
            this.panel_Infor.Size = new System.Drawing.Size(469, 638);
            this.panel_Infor.TabIndex = 65;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(181, 205);
            this.txt_Type.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Type.Multiline = true;
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(256, 36);
            this.txt_Type.TabIndex = 84;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Location = new System.Drawing.Point(15, 515);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(117, 74);
            this.btn_UploadImage.TabIndex = 82;
            this.btn_UploadImage.Text = "Upload Image";
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Book Picture : ";
            // 
            // Pic_Book
            // 
            this.Pic_Book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_Book.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Book.Image")));
            this.Pic_Book.Location = new System.Drawing.Point(181, 478);
            this.Pic_Book.Name = "Pic_Book";
            this.Pic_Book.Size = new System.Drawing.Size(256, 111);
            this.Pic_Book.TabIndex = 80;
            this.Pic_Book.TabStop = false;
            // 
            // Dtp_Updateday
            // 
            this.Dtp_Updateday.Location = new System.Drawing.Point(181, 335);
            this.Dtp_Updateday.Name = "Dtp_Updateday";
            this.Dtp_Updateday.Size = new System.Drawing.Size(256, 22);
            this.Dtp_Updateday.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 339);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Update Day : ";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Description.Location = new System.Drawing.Point(16, 385);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(115, 19);
            this.Description.TabIndex = 77;
            this.Description.Text = "Description : ";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(181, 385);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(256, 88);
            this.txt_Description.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(16, 298);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 75;
            this.label10.Text = "Price : ";
            // 
            // txt_Pricebook
            // 
            this.txt_Pricebook.Location = new System.Drawing.Point(181, 283);
            this.txt_Pricebook.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Pricebook.Multiline = true;
            this.txt_Pricebook.Name = "txt_Pricebook";
            this.txt_Pricebook.Size = new System.Drawing.Size(256, 37);
            this.txt_Pricebook.TabIndex = 74;
            // 
            // txt_Idbook
            // 
            this.txt_Idbook.Location = new System.Drawing.Point(181, 40);
            this.txt_Idbook.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Idbook.Multiline = true;
            this.txt_Idbook.Name = "txt_Idbook";
            this.txt_Idbook.Size = new System.Drawing.Size(256, 36);
            this.txt_Idbook.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(16, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "ID Book  : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(16, 179);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "Publisher : ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl5.Location = new System.Drawing.Point(16, 219);
            this.lbl5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(108, 19);
            this.lbl5.TabIndex = 70;
            this.lbl5.Text = "Book Type : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(16, 257);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 69;
            this.label13.Text = "Number : ";
            // 
            // txt_Publisher
            // 
            this.txt_Publisher.Location = new System.Drawing.Point(181, 162);
            this.txt_Publisher.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Publisher.Multiline = true;
            this.txt_Publisher.Name = "txt_Publisher";
            this.txt_Publisher.Size = new System.Drawing.Size(256, 39);
            this.txt_Publisher.TabIndex = 67;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl4.Location = new System.Drawing.Point(16, 136);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(129, 19);
            this.lbl4.TabIndex = 68;
            this.lbl4.Text = "Book Author  : ";
            // 
            // txt_nbook
            // 
            this.txt_nbook.Location = new System.Drawing.Point(181, 245);
            this.txt_nbook.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nbook.Multiline = true;
            this.txt_nbook.Name = "txt_nbook";
            this.txt_nbook.Size = new System.Drawing.Size(256, 34);
            this.txt_nbook.TabIndex = 65;
            // 
            // txt_AuthorBook
            // 
            this.txt_AuthorBook.Location = new System.Drawing.Point(181, 123);
            this.txt_AuthorBook.Margin = new System.Windows.Forms.Padding(2);
            this.txt_AuthorBook.Multiline = true;
            this.txt_AuthorBook.Name = "txt_AuthorBook";
            this.txt_AuthorBook.Size = new System.Drawing.Size(256, 35);
            this.txt_AuthorBook.TabIndex = 64;
            // 
            // txt_Namebook
            // 
            this.txt_Namebook.Location = new System.Drawing.Point(181, 84);
            this.txt_Namebook.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Namebook.Multiline = true;
            this.txt_Namebook.Name = "txt_Namebook";
            this.txt_Namebook.Size = new System.Drawing.Size(256, 35);
            this.txt_Namebook.TabIndex = 63;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl3.Location = new System.Drawing.Point(16, 97);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(115, 19);
            this.lbl3.TabIndex = 62;
            this.lbl3.Text = "Book Name : ";
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(1034, 10);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(134, 39);
            this.Btn_Find.TabIndex = 64;
            this.Btn_Find.Text = "Find";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(807, 10);
            this.txt_Find.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Find.Multiline = true;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(205, 36);
            this.txt_Find.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(508, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Find book by  : ";
            // 
            // dgvBOOK
            // 
            this.dgvBOOK.AllowUserToOrderColumns = true;
            this.dgvBOOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBOOK.Location = new System.Drawing.Point(478, 55);
            this.dgvBOOK.Name = "dgvBOOK";
            this.dgvBOOK.RowHeadersWidth = 51;
            this.dgvBOOK.RowTemplate.Height = 24;
            this.dgvBOOK.Size = new System.Drawing.Size(725, 531);
            this.dgvBOOK.TabIndex = 56;
            this.dgvBOOK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBOOK_CellContentClick);
            // 
            // label_Header
            // 
            this.label_Header.BackColor = System.Drawing.Color.Orange;
            this.label_Header.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Header.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Header.ForeColor = System.Drawing.Color.White;
            this.label_Header.Location = new System.Drawing.Point(0, 0);
            this.label_Header.Name = "label_Header";
            this.label_Header.Size = new System.Drawing.Size(1443, 93);
            this.label_Header.TabIndex = 5;
            this.label_Header.Text = "    Books";
            this.label_Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Header.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 808);
            this.panel2.TabIndex = 6;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(23, 209);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(177, 76);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(23, 338);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(177, 75);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(23, 466);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(177, 76);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(23, 64);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(177, 74);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_PrintDT
            // 
            this.btn_PrintDT.Location = new System.Drawing.Point(1072, 669);
            this.btn_PrintDT.Name = "btn_PrintDT";
            this.btn_PrintDT.Size = new System.Drawing.Size(86, 81);
            this.btn_PrintDT.TabIndex = 84;
            this.btn_PrintDT.UseVisualStyleBackColor = true;
            this.btn_PrintDT.Click += new System.EventHandler(this.btn_PrintDT_Click);
            // 
            // Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 904);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Form";
            this.Load += new System.EventHandler(this.Book_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_Infor.ResumeLayout(false);
            this.panel_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBOOK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBOOK;
        private System.Windows.Forms.Button btn_Bookheader;
        private System.Windows.Forms.Label Label_Close;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Infor;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Pic_Book;
        private System.Windows.Forms.DateTimePicker Dtp_Updateday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Pricebook;
        private System.Windows.Forms.TextBox txt_Idbook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt_nbook;
        private System.Windows.Forms.TextBox txt_AuthorBook;
        private System.Windows.Forms.TextBox txt_Namebook;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox Lb_typeFind;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox txt_Publisher;
        private System.Windows.Forms.Button btn_PrintDT;
    }
}