﻿
namespace Cohesion_Project
{
   partial class Frm_BedFlag
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
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.lblOrderStatus = new System.Windows.Forms.Label();
         this.lblOrderQty = new System.Windows.Forms.Label();
         this.lblProductQty = new System.Windows.Forms.Label();
         this.lblDefectQty = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.btnStart = new System.Windows.Forms.Button();
         this.Btn_Close = new System.Windows.Forms.Button();
         this.panel3 = new System.Windows.Forms.Panel();
         this.txtBedRegName = new System.Windows.Forms.TextBox();
         this.label11 = new System.Windows.Forms.Label();
         this.txtBedRegTotal = new System.Windows.Forms.TextBox();
         this.label14 = new System.Windows.Forms.Label();
         this.txtLotQty = new System.Windows.Forms.TextBox();
         this.label34 = new System.Windows.Forms.Label();
         this.btnBedRegAdd = new System.Windows.Forms.Button();
         this.cboBedReg = new System.Windows.Forms.ComboBox();
         this.txtDesc = new System.Windows.Forms.TextBox();
         this.label20 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.txtBedQty = new System.Windows.Forms.TextBox();
         this.label13 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.panel5 = new System.Windows.Forms.Panel();
         this.dgvDefect = new System.Windows.Forms.DataGridView();
         this.label10 = new System.Windows.Forms.Label();
         this.panel2 = new System.Windows.Forms.Panel();
         this.txtCustomerName = new System.Windows.Forms.TextBox();
         this.label32 = new System.Windows.Forms.Label();
         this.txtCustomerCode = new System.Windows.Forms.TextBox();
         this.label24 = new System.Windows.Forms.Label();
         this.txtTotal = new System.Windows.Forms.TextBox();
         this.label25 = new System.Windows.Forms.Label();
         this.txtProductCode = new System.Windows.Forms.TextBox();
         this.label26 = new System.Windows.Forms.Label();
         this.txtProductName = new System.Windows.Forms.TextBox();
         this.txtOperationName = new System.Windows.Forms.TextBox();
         this.label29 = new System.Windows.Forms.Label();
         this.txtOperationCode = new System.Windows.Forms.TextBox();
         this.label31 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label27 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.btnOrder = new System.Windows.Forms.Button();
         this.txtOrder = new System.Windows.Forms.TextBox();
         this.label19 = new System.Windows.Forms.Label();
         this.txtLotDesc = new System.Windows.Forms.TextBox();
         this.cboLotId = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label22 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label21 = new System.Windows.Forms.Label();
         this.panel4 = new System.Windows.Forms.Panel();
         this.flwOperation = new System.Windows.Forms.FlowLayoutPanel();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel5.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDefect)).BeginInit();
         this.panel2.SuspendLayout();
         this.panel1.SuspendLayout();
         this.panel4.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.Controls.Add(this.lblOrderStatus, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.lblOrderQty, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.lblProductQty, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.lblDefectQty, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
         this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
         this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 519);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(1454, 77);
         this.tableLayoutPanel1.TabIndex = 32;
         // 
         // lblOrderStatus
         // 
         this.lblOrderStatus.BackColor = System.Drawing.Color.White;
         this.lblOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblOrderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblOrderStatus.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.lblOrderStatus.ForeColor = System.Drawing.Color.Black;
         this.lblOrderStatus.Location = new System.Drawing.Point(0, 30);
         this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(0);
         this.lblOrderStatus.Name = "lblOrderStatus";
         this.lblOrderStatus.Size = new System.Drawing.Size(363, 47);
         this.lblOrderStatus.TabIndex = 9;
         this.lblOrderStatus.Text = "0";
         this.lblOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblOrderQty
         // 
         this.lblOrderQty.BackColor = System.Drawing.Color.White;
         this.lblOrderQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblOrderQty.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblOrderQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.lblOrderQty.ForeColor = System.Drawing.Color.Black;
         this.lblOrderQty.Location = new System.Drawing.Point(363, 30);
         this.lblOrderQty.Margin = new System.Windows.Forms.Padding(0);
         this.lblOrderQty.Name = "lblOrderQty";
         this.lblOrderQty.Size = new System.Drawing.Size(363, 47);
         this.lblOrderQty.TabIndex = 8;
         this.lblOrderQty.Text = "0";
         this.lblOrderQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblProductQty
         // 
         this.lblProductQty.BackColor = System.Drawing.Color.White;
         this.lblProductQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblProductQty.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblProductQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.lblProductQty.ForeColor = System.Drawing.Color.Black;
         this.lblProductQty.Location = new System.Drawing.Point(726, 30);
         this.lblProductQty.Margin = new System.Windows.Forms.Padding(0);
         this.lblProductQty.Name = "lblProductQty";
         this.lblProductQty.Size = new System.Drawing.Size(363, 47);
         this.lblProductQty.TabIndex = 7;
         this.lblProductQty.Text = "0";
         this.lblProductQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblDefectQty
         // 
         this.lblDefectQty.BackColor = System.Drawing.Color.White;
         this.lblDefectQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblDefectQty.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblDefectQty.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.lblDefectQty.ForeColor = System.Drawing.Color.Black;
         this.lblDefectQty.Location = new System.Drawing.Point(1089, 30);
         this.lblDefectQty.Margin = new System.Windows.Forms.Padding(0);
         this.lblDefectQty.Name = "lblDefectQty";
         this.lblDefectQty.Size = new System.Drawing.Size(365, 47);
         this.lblDefectQty.TabIndex = 6;
         this.lblDefectQty.Text = "0";
         this.lblDefectQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label6
         // 
         this.label6.BackColor = System.Drawing.Color.Gray;
         this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label6.ForeColor = System.Drawing.Color.White;
         this.label6.Location = new System.Drawing.Point(363, 0);
         this.label6.Margin = new System.Windows.Forms.Padding(0);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(363, 30);
         this.label6.TabIndex = 3;
         this.label6.Text = "지시 수량";
         this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label7
         // 
         this.label7.BackColor = System.Drawing.Color.YellowGreen;
         this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label7.ForeColor = System.Drawing.Color.White;
         this.label7.Location = new System.Drawing.Point(726, 0);
         this.label7.Margin = new System.Windows.Forms.Padding(0);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(363, 30);
         this.label7.TabIndex = 4;
         this.label7.Text = "생산 수량";
         this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label8
         // 
         this.label8.BackColor = System.Drawing.Color.Tomato;
         this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label8.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label8.ForeColor = System.Drawing.Color.White;
         this.label8.Location = new System.Drawing.Point(1089, 0);
         this.label8.Margin = new System.Windows.Forms.Padding(0);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(365, 30);
         this.label8.TabIndex = 5;
         this.label8.Text = "불량 수량";
         this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label5
         // 
         this.label5.BackColor = System.Drawing.Color.Gray;
         this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
         this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(0, 0);
         this.label5.Margin = new System.Windows.Forms.Padding(0);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(363, 30);
         this.label5.TabIndex = 2;
         this.label5.Text = "지시 상태";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnStart
         // 
         this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
         this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnStart.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.btnStart.ForeColor = System.Drawing.Color.White;
         this.btnStart.Location = new System.Drawing.Point(1156, 944);
         this.btnStart.Margin = new System.Windows.Forms.Padding(0);
         this.btnStart.Name = "btnStart";
         this.btnStart.Size = new System.Drawing.Size(150, 40);
         this.btnStart.TabIndex = 35;
         this.btnStart.Text = "입력";
         this.btnStart.UseVisualStyleBackColor = false;
         this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
         // 
         // Btn_Close
         // 
         this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.Btn_Close.BackColor = System.Drawing.Color.DimGray;
         this.Btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.Btn_Close.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.Btn_Close.ForeColor = System.Drawing.Color.White;
         this.Btn_Close.Location = new System.Drawing.Point(1315, 944);
         this.Btn_Close.Margin = new System.Windows.Forms.Padding(0);
         this.Btn_Close.Name = "Btn_Close";
         this.Btn_Close.Size = new System.Drawing.Size(150, 40);
         this.Btn_Close.TabIndex = 34;
         this.Btn_Close.Text = "닫기";
         this.Btn_Close.UseVisualStyleBackColor = false;
         // 
         // panel3
         // 
         this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel3.BackColor = System.Drawing.Color.White;
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel3.Controls.Add(this.txtBedRegName);
         this.panel3.Controls.Add(this.label11);
         this.panel3.Controls.Add(this.txtBedRegTotal);
         this.panel3.Controls.Add(this.label14);
         this.panel3.Controls.Add(this.btnBedRegAdd);
         this.panel3.Controls.Add(this.cboBedReg);
         this.panel3.Controls.Add(this.txtDesc);
         this.panel3.Controls.Add(this.txtLotQty);
         this.panel3.Controls.Add(this.label20);
         this.panel3.Controls.Add(this.label9);
         this.panel3.Controls.Add(this.label34);
         this.panel3.Controls.Add(this.label12);
         this.panel3.Controls.Add(this.txtBedQty);
         this.panel3.Controls.Add(this.label13);
         this.panel3.Controls.Add(this.label3);
         this.panel3.Controls.Add(this.panel5);
         this.panel3.Controls.Add(this.label10);
         this.panel3.Location = new System.Drawing.Point(12, 607);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(1454, 330);
         this.panel3.TabIndex = 33;
         // 
         // txtBedRegName
         // 
         this.txtBedRegName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtBedRegName.Enabled = false;
         this.txtBedRegName.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtBedRegName.Location = new System.Drawing.Point(660, 49);
         this.txtBedRegName.Name = "txtBedRegName";
         this.txtBedRegName.Size = new System.Drawing.Size(265, 29);
         this.txtBedRegName.TabIndex = 54;
         // 
         // label11
         // 
         this.label11.BackColor = System.Drawing.Color.Transparent;
         this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label11.ForeColor = System.Drawing.Color.Black;
         this.label11.Location = new System.Drawing.Point(551, 48);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(138, 30);
         this.label11.TabIndex = 53;
         this.label11.Text = "◾ 불량 명칭";
         this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtBedRegTotal
         // 
         this.txtBedRegTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtBedRegTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtBedRegTotal.Enabled = false;
         this.txtBedRegTotal.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtBedRegTotal.Location = new System.Drawing.Point(792, 226);
         this.txtBedRegTotal.Name = "txtBedRegTotal";
         this.txtBedRegTotal.Size = new System.Drawing.Size(265, 29);
         this.txtBedRegTotal.TabIndex = 79;
         this.txtBedRegTotal.Text = "0";
         this.txtBedRegTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label14
         // 
         this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label14.BackColor = System.Drawing.Color.Transparent;
         this.label14.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label14.ForeColor = System.Drawing.Color.Black;
         this.label14.Location = new System.Drawing.Point(695, 225);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(138, 30);
         this.label14.TabIndex = 78;
         this.label14.Text = "◾ 총 불량";
         this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtLotQty
         // 
         this.txtLotQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtLotQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtLotQty.Enabled = false;
         this.txtLotQty.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtLotQty.Location = new System.Drawing.Point(1172, 226);
         this.txtLotQty.Name = "txtLotQty";
         this.txtLotQty.Size = new System.Drawing.Size(265, 29);
         this.txtLotQty.TabIndex = 77;
         this.txtLotQty.Text = "0";
         this.txtLotQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label34
         // 
         this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label34.BackColor = System.Drawing.Color.Transparent;
         this.label34.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label34.ForeColor = System.Drawing.Color.Black;
         this.label34.Location = new System.Drawing.Point(1063, 225);
         this.label34.Name = "label34";
         this.label34.Size = new System.Drawing.Size(138, 30);
         this.label34.TabIndex = 76;
         this.label34.Text = "◾ 남은 수량";
         this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnBedRegAdd
         // 
         this.btnBedRegAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
         this.btnBedRegAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btnBedRegAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnBedRegAdd.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.btnBedRegAdd.ForeColor = System.Drawing.Color.White;
         this.btnBedRegAdd.Location = new System.Drawing.Point(1260, 50);
         this.btnBedRegAdd.Margin = new System.Windows.Forms.Padding(0);
         this.btnBedRegAdd.Name = "btnBedRegAdd";
         this.btnBedRegAdd.Size = new System.Drawing.Size(92, 30);
         this.btnBedRegAdd.TabIndex = 73;
         this.btnBedRegAdd.Text = "추가";
         this.btnBedRegAdd.UseVisualStyleBackColor = false;
         this.btnBedRegAdd.Click += new System.EventHandler(this.btnBedRegAdd_Click);
         // 
         // cboBedReg
         // 
         this.cboBedReg.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.cboBedReg.FormattingEnabled = true;
         this.cboBedReg.Location = new System.Drawing.Point(128, 50);
         this.cboBedReg.Name = "cboBedReg";
         this.cboBedReg.Size = new System.Drawing.Size(384, 29);
         this.cboBedReg.TabIndex = 63;
         this.cboBedReg.SelectedIndexChanged += new System.EventHandler(this.cboBedReg_SelectedIndexChanged);
         // 
         // txtDesc
         // 
         this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtDesc.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtDesc.Location = new System.Drawing.Point(126, 268);
         this.txtDesc.Multiline = true;
         this.txtDesc.Name = "txtDesc";
         this.txtDesc.Size = new System.Drawing.Size(1311, 40);
         this.txtDesc.TabIndex = 62;
         // 
         // label20
         // 
         this.label20.BackColor = System.Drawing.Color.Transparent;
         this.label20.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label20.ForeColor = System.Drawing.Color.Black;
         this.label20.Location = new System.Drawing.Point(17, 267);
         this.label20.Name = "label20";
         this.label20.Size = new System.Drawing.Size(138, 30);
         this.label20.TabIndex = 61;
         this.label20.Text = "◾ 생산 주석";
         this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label9
         // 
         this.label9.BackColor = System.Drawing.Color.Transparent;
         this.label9.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label9.ForeColor = System.Drawing.Color.Black;
         this.label9.Location = new System.Drawing.Point(16, 265);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(138, 30);
         this.label9.TabIndex = 60;
         this.label9.Text = "◾ label4";
         this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label12
         // 
         this.label12.BackColor = System.Drawing.Color.Transparent;
         this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label12.ForeColor = System.Drawing.Color.Black;
         this.label12.Location = new System.Drawing.Point(19, 49);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(138, 30);
         this.label12.TabIndex = 50;
         this.label12.Text = "◾ 불량코드";
         this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtBedQty
         // 
         this.txtBedQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtBedQty.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtBedQty.Location = new System.Drawing.Point(1069, 50);
         this.txtBedQty.Name = "txtBedQty";
         this.txtBedQty.Size = new System.Drawing.Size(188, 29);
         this.txtBedQty.TabIndex = 55;
         this.txtBedQty.Text = "0";
         this.txtBedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtBedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBedQty_KeyPress);
         // 
         // label13
         // 
         this.label13.BackColor = System.Drawing.Color.Transparent;
         this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label13.ForeColor = System.Drawing.Color.Black;
         this.label13.Location = new System.Drawing.Point(960, 49);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(138, 30);
         this.label13.TabIndex = 53;
         this.label13.Text = "◾ 입력 수량";
         this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label3
         // 
         this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
         this.label3.Dock = System.Windows.Forms.DockStyle.Top;
         this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(0, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(1452, 30);
         this.label3.TabIndex = 1;
         this.label3.Text = "작업 공정 정보";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel5
         // 
         this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel5.Controls.Add(this.dgvDefect);
         this.panel5.Location = new System.Drawing.Point(128, 94);
         this.panel5.Name = "panel5";
         this.panel5.Size = new System.Drawing.Size(1309, 119);
         this.panel5.TabIndex = 80;
         // 
         // dgvDefect
         // 
         this.dgvDefect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDefect.Location = new System.Drawing.Point(3, 3);
         this.dgvDefect.Name = "dgvDefect";
         this.dgvDefect.RowTemplate.Height = 23;
         this.dgvDefect.Size = new System.Drawing.Size(1023, 97);
         this.dgvDefect.TabIndex = 74;
         this.dgvDefect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefect_CellClick);
         // 
         // label10
         // 
         this.label10.BackColor = System.Drawing.Color.Transparent;
         this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label10.ForeColor = System.Drawing.Color.Black;
         this.label10.Location = new System.Drawing.Point(19, 94);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(138, 30);
         this.label10.TabIndex = 75;
         this.label10.Text = "◾ 불량등록";
         this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel2
         // 
         this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel2.BackColor = System.Drawing.Color.White;
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.txtCustomerName);
         this.panel2.Controls.Add(this.label32);
         this.panel2.Controls.Add(this.txtCustomerCode);
         this.panel2.Controls.Add(this.label24);
         this.panel2.Controls.Add(this.txtTotal);
         this.panel2.Controls.Add(this.label25);
         this.panel2.Controls.Add(this.txtProductCode);
         this.panel2.Controls.Add(this.label26);
         this.panel2.Controls.Add(this.txtProductName);
         this.panel2.Controls.Add(this.txtOperationName);
         this.panel2.Controls.Add(this.label29);
         this.panel2.Controls.Add(this.txtOperationCode);
         this.panel2.Controls.Add(this.label31);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.label27);
         this.panel2.Location = new System.Drawing.Point(12, 174);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1454, 261);
         this.panel2.TabIndex = 31;
         // 
         // txtCustomerName
         // 
         this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtCustomerName.Enabled = false;
         this.txtCustomerName.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtCustomerName.Location = new System.Drawing.Point(660, 161);
         this.txtCustomerName.Name = "txtCustomerName";
         this.txtCustomerName.Size = new System.Drawing.Size(265, 29);
         this.txtCustomerName.TabIndex = 52;
         // 
         // label32
         // 
         this.label32.BackColor = System.Drawing.Color.Transparent;
         this.label32.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label32.ForeColor = System.Drawing.Color.Black;
         this.label32.Location = new System.Drawing.Point(551, 160);
         this.label32.Name = "label32";
         this.label32.Size = new System.Drawing.Size(138, 30);
         this.label32.TabIndex = 51;
         this.label32.Text = "◾ 고객사명";
         this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtCustomerCode
         // 
         this.txtCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtCustomerCode.Enabled = false;
         this.txtCustomerCode.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtCustomerCode.Location = new System.Drawing.Point(125, 160);
         this.txtCustomerCode.Name = "txtCustomerCode";
         this.txtCustomerCode.Size = new System.Drawing.Size(387, 29);
         this.txtCustomerCode.TabIndex = 50;
         // 
         // label24
         // 
         this.label24.BackColor = System.Drawing.Color.Transparent;
         this.label24.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label24.ForeColor = System.Drawing.Color.Black;
         this.label24.Location = new System.Drawing.Point(16, 159);
         this.label24.Name = "label24";
         this.label24.Size = new System.Drawing.Size(138, 30);
         this.label24.TabIndex = 49;
         this.label24.Text = "◾ 고객사";
         this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtTotal
         // 
         this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtTotal.Enabled = false;
         this.txtTotal.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtTotal.Location = new System.Drawing.Point(125, 215);
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.Size = new System.Drawing.Size(387, 29);
         this.txtTotal.TabIndex = 48;
         // 
         // label25
         // 
         this.label25.BackColor = System.Drawing.Color.Transparent;
         this.label25.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label25.ForeColor = System.Drawing.Color.Black;
         this.label25.Location = new System.Drawing.Point(16, 214);
         this.label25.Name = "label25";
         this.label25.Size = new System.Drawing.Size(138, 30);
         this.label25.TabIndex = 47;
         this.label25.Text = "◾ 수량";
         this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtProductCode
         // 
         this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtProductCode.Enabled = false;
         this.txtProductCode.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtProductCode.Location = new System.Drawing.Point(125, 49);
         this.txtProductCode.Name = "txtProductCode";
         this.txtProductCode.Size = new System.Drawing.Size(387, 29);
         this.txtProductCode.TabIndex = 39;
         // 
         // label26
         // 
         this.label26.BackColor = System.Drawing.Color.Transparent;
         this.label26.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label26.ForeColor = System.Drawing.Color.Black;
         this.label26.Location = new System.Drawing.Point(16, 48);
         this.label26.Name = "label26";
         this.label26.Size = new System.Drawing.Size(138, 30);
         this.label26.TabIndex = 36;
         this.label26.Text = "◾ 품번";
         this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtProductName
         // 
         this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtProductName.Enabled = false;
         this.txtProductName.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtProductName.Location = new System.Drawing.Point(660, 50);
         this.txtProductName.Name = "txtProductName";
         this.txtProductName.Size = new System.Drawing.Size(265, 29);
         this.txtProductName.TabIndex = 45;
         // 
         // txtOperationName
         // 
         this.txtOperationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtOperationName.Enabled = false;
         this.txtOperationName.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtOperationName.Location = new System.Drawing.Point(660, 105);
         this.txtOperationName.Name = "txtOperationName";
         this.txtOperationName.Size = new System.Drawing.Size(265, 29);
         this.txtOperationName.TabIndex = 46;
         // 
         // label29
         // 
         this.label29.BackColor = System.Drawing.Color.Transparent;
         this.label29.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label29.ForeColor = System.Drawing.Color.Black;
         this.label29.Location = new System.Drawing.Point(551, 104);
         this.label29.Name = "label29";
         this.label29.Size = new System.Drawing.Size(138, 30);
         this.label29.TabIndex = 44;
         this.label29.Text = "◾ 공정명";
         this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtOperationCode
         // 
         this.txtOperationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtOperationCode.Enabled = false;
         this.txtOperationCode.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtOperationCode.Location = new System.Drawing.Point(125, 104);
         this.txtOperationCode.Name = "txtOperationCode";
         this.txtOperationCode.Size = new System.Drawing.Size(387, 29);
         this.txtOperationCode.TabIndex = 40;
         // 
         // label31
         // 
         this.label31.BackColor = System.Drawing.Color.Transparent;
         this.label31.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label31.ForeColor = System.Drawing.Color.Black;
         this.label31.Location = new System.Drawing.Point(16, 103);
         this.label31.Name = "label31";
         this.label31.Size = new System.Drawing.Size(138, 30);
         this.label31.TabIndex = 37;
         this.label31.Text = "◾ 공정";
         this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label2
         // 
         this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
         this.label2.Dock = System.Windows.Forms.DockStyle.Top;
         this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label2.ForeColor = System.Drawing.Color.White;
         this.label2.Location = new System.Drawing.Point(0, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(1452, 30);
         this.label2.TabIndex = 1;
         this.label2.Text = "생산 LOT 정보";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label27
         // 
         this.label27.BackColor = System.Drawing.Color.Transparent;
         this.label27.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label27.ForeColor = System.Drawing.Color.Black;
         this.label27.Location = new System.Drawing.Point(551, 49);
         this.label27.Name = "label27";
         this.label27.Size = new System.Drawing.Size(138, 30);
         this.label27.TabIndex = 43;
         this.label27.Text = "◾ 품명";
         this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.BackColor = System.Drawing.Color.White;
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.btnOrder);
         this.panel1.Controls.Add(this.txtOrder);
         this.panel1.Controls.Add(this.label19);
         this.panel1.Controls.Add(this.txtLotDesc);
         this.panel1.Controls.Add(this.cboLotId);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.label22);
         this.panel1.Controls.Add(this.label4);
         this.panel1.Location = new System.Drawing.Point(12, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1454, 152);
         this.panel1.TabIndex = 30;
         // 
         // btnOrder
         // 
         this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
         this.btnOrder.FlatAppearance.BorderSize = 0;
         this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnOrder.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btnOrder.Image = global::Cohesion_Project.Properties.Resources.Search;
         this.btnOrder.Location = new System.Drawing.Point(518, 49);
         this.btnOrder.Name = "btnOrder";
         this.btnOrder.Size = new System.Drawing.Size(55, 29);
         this.btnOrder.TabIndex = 54;
         this.btnOrder.Text = "조회";
         this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
         this.btnOrder.UseVisualStyleBackColor = false;
         this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
         // 
         // txtOrder
         // 
         this.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtOrder.Enabled = false;
         this.txtOrder.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtOrder.Location = new System.Drawing.Point(125, 49);
         this.txtOrder.Name = "txtOrder";
         this.txtOrder.Size = new System.Drawing.Size(387, 29);
         this.txtOrder.TabIndex = 53;
         // 
         // label19
         // 
         this.label19.BackColor = System.Drawing.Color.Transparent;
         this.label19.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label19.ForeColor = System.Drawing.Color.Black;
         this.label19.Location = new System.Drawing.Point(16, 48);
         this.label19.Name = "label19";
         this.label19.Size = new System.Drawing.Size(138, 30);
         this.label19.TabIndex = 52;
         this.label19.Text = "◾ 작업지시서";
         this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtLotDesc
         // 
         this.txtLotDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtLotDesc.Enabled = false;
         this.txtLotDesc.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.txtLotDesc.Location = new System.Drawing.Point(660, 104);
         this.txtLotDesc.Name = "txtLotDesc";
         this.txtLotDesc.Size = new System.Drawing.Size(265, 29);
         this.txtLotDesc.TabIndex = 51;
         // 
         // cboLotId
         // 
         this.cboLotId.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.cboLotId.FormattingEnabled = true;
         this.cboLotId.Location = new System.Drawing.Point(125, 103);
         this.cboLotId.Name = "cboLotId";
         this.cboLotId.Size = new System.Drawing.Size(387, 29);
         this.cboLotId.TabIndex = 31;
         this.cboLotId.SelectedIndexChanged += new System.EventHandler(this.cboLotId_SelectedIndexChanged);
         this.cboLotId.Leave += new System.EventHandler(this.cboLotId_Leave);
         // 
         // label1
         // 
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
         this.label1.Dock = System.Windows.Forms.DockStyle.Top;
         this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(1452, 30);
         this.label1.TabIndex = 0;
         this.label1.Text = "생산 LOT";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label22
         // 
         this.label22.BackColor = System.Drawing.Color.Transparent;
         this.label22.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label22.ForeColor = System.Drawing.Color.Black;
         this.label22.Location = new System.Drawing.Point(16, 102);
         this.label22.Name = "label22";
         this.label22.Size = new System.Drawing.Size(138, 30);
         this.label22.TabIndex = 21;
         this.label22.Text = "◾ LOT ID";
         this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label4
         // 
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label4.ForeColor = System.Drawing.Color.Black;
         this.label4.Location = new System.Drawing.Point(551, 104);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(138, 30);
         this.label4.TabIndex = 55;
         this.label4.Text = "◾ LOT 설명";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label21
         // 
         this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(56)))), ((int)(((byte)(67)))));
         this.label21.Dock = System.Windows.Forms.DockStyle.Top;
         this.label21.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
         this.label21.ForeColor = System.Drawing.Color.White;
         this.label21.Location = new System.Drawing.Point(0, 0);
         this.label21.Margin = new System.Windows.Forms.Padding(0);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(1454, 30);
         this.label21.TabIndex = 2;
         this.label21.Text = "생산 LOT 공정 진행 상태";
         this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // panel4
         // 
         this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel4.Controls.Add(this.flwOperation);
         this.panel4.Controls.Add(this.label21);
         this.panel4.Location = new System.Drawing.Point(12, 446);
         this.panel4.Margin = new System.Windows.Forms.Padding(0);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(1454, 62);
         this.panel4.TabIndex = 36;
         // 
         // flwOperation
         // 
         this.flwOperation.BackColor = System.Drawing.Color.White;
         this.flwOperation.Dock = System.Windows.Forms.DockStyle.Fill;
         this.flwOperation.Location = new System.Drawing.Point(0, 30);
         this.flwOperation.Margin = new System.Windows.Forms.Padding(0);
         this.flwOperation.Name = "flwOperation";
         this.flwOperation.Size = new System.Drawing.Size(1454, 32);
         this.flwOperation.TabIndex = 3;
         // 
         // Frm_BedFlag
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
         this.ClientSize = new System.Drawing.Size(1478, 990);
         this.Controls.Add(this.panel4);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Controls.Add(this.btnStart);
         this.Controls.Add(this.Btn_Close);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Name = "Frm_BedFlag";
         this.Text = "불량 등록";
         this.Load += new System.EventHandler(this.Frm_WORK_ORDER_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.panel5.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDefect)).EndInit();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel4.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      protected System.Windows.Forms.Label lblOrderStatus;
      protected System.Windows.Forms.Label lblOrderQty;
      protected System.Windows.Forms.Label lblProductQty;
      protected System.Windows.Forms.Label lblDefectQty;
      protected System.Windows.Forms.Label label6;
      protected System.Windows.Forms.Label label7;
      protected System.Windows.Forms.Label label8;
      protected System.Windows.Forms.Label label5;
      protected System.Windows.Forms.Button btnStart;
      protected System.Windows.Forms.Button Btn_Close;
      protected System.Windows.Forms.Panel panel3;
      protected System.Windows.Forms.Label label3;
      protected System.Windows.Forms.Panel panel2;
      protected System.Windows.Forms.Label label2;
      protected System.Windows.Forms.Panel panel1;
      protected System.Windows.Forms.Label label1;
      protected System.Windows.Forms.Label label22;
      protected System.Windows.Forms.TextBox txtProductCode;
      protected System.Windows.Forms.Label label26;
      protected System.Windows.Forms.TextBox txtProductName;
      protected System.Windows.Forms.Label label27;
      protected System.Windows.Forms.TextBox txtCustomerCode;
      protected System.Windows.Forms.Label label24;
      protected System.Windows.Forms.TextBox txtOperationName;
      protected System.Windows.Forms.Label label29;
      protected System.Windows.Forms.TextBox txtOperationCode;
      protected System.Windows.Forms.Label label31;
      private System.Windows.Forms.ComboBox cboLotId;
      protected System.Windows.Forms.TextBox txtLotDesc;
      protected System.Windows.Forms.TextBox txtCustomerName;
      protected System.Windows.Forms.Label label32;
      protected System.Windows.Forms.Label label21;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Button btnOrder;
      protected System.Windows.Forms.TextBox txtOrder;
      protected System.Windows.Forms.Label label19;
      protected System.Windows.Forms.TextBox txtTotal;
      protected System.Windows.Forms.Label label25;
      protected System.Windows.Forms.Label label4;
      private System.Windows.Forms.FlowLayoutPanel flwOperation;
      private System.Windows.Forms.ComboBox cboBedReg;
      protected System.Windows.Forms.TextBox txtDesc;
      protected System.Windows.Forms.Label label20;
      protected System.Windows.Forms.Label label9;
      protected System.Windows.Forms.Label label12;
      protected System.Windows.Forms.TextBox txtBedQty;
      protected System.Windows.Forms.Label label13;
      private System.Windows.Forms.DataGridView dgvDefect;
      protected System.Windows.Forms.Button btnBedRegAdd;
      protected System.Windows.Forms.Label label10;
      protected System.Windows.Forms.TextBox txtBedRegTotal;
      protected System.Windows.Forms.Label label14;
      protected System.Windows.Forms.TextBox txtLotQty;
      protected System.Windows.Forms.Label label34;
      private System.Windows.Forms.Panel panel5;
      protected System.Windows.Forms.TextBox txtBedRegName;
      protected System.Windows.Forms.Label label11;
   }
}
