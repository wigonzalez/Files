

//UPGRADE_NOTE: (1707) The resulting shared file would differ depending on whether all or some of the projects are migrated. More Information: https://docs.mobilize.net/vbuc/ewis/notes#id-1707 
#if BARS
namespace BARS;
#endif

partial class frmLogin
{

	#region "Upgrade Support "
	private static frmLogin m_vb6FormDefInstance;
	private static bool m_InitializingDefInstance;
	public static frmLogin DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = CreateInstance();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	#endregion
	#region "Windows Form Designer generated code "
	public static frmLogin CreateInstance()
	{
		frmLogin theInstance = new frmLogin();
		theInstance.Form_Load();
		return theInstance;
	}
	protected void InitializeHelp()
	{
		UpgradeSupport.helpSupport.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
	}
	private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdHelp", "cmdCancel", "cmdOK", "Label7", "lblReportPath", "Label3", "Image3", "Label5", "Image1", "Label1", "_lblLabels_0", "_lblLabels_1", "Label2", "lblEditRegion", "cmbRegion", "txtUserName", "txtPassword", "cmbDataSource", "editRegion", "_SSTab1_TabPage0", "SSTab1", "Image2", "lblLabels", "commandButtonHelper1"};
	//Required by the Windows Form Designer
	private System.ComponentModel.IContainer components;
	public System.Windows.Forms.ToolTip ToolTipMain;
	public System.Windows.Forms.Button cmdHelp;
	public System.Windows.Forms.Button cmdCancel;
	public System.Windows.Forms.Button cmdOK;
	public System.Windows.Forms.Label Label7;
	public System.Windows.Forms.Label lblReportPath;
	public System.Windows.Forms.Label Label3;
	public System.Windows.Forms.PictureBox Image3;
	public System.Windows.Forms.Label Label5;
	public System.Windows.Forms.PictureBox Image1;
	public System.Windows.Forms.Label Label1;
	private System.Windows.Forms.Label _lblLabels_0;
	private System.Windows.Forms.Label _lblLabels_1;
	public System.Windows.Forms.Label Label2;
	public System.Windows.Forms.Label lblEditRegion;
	public System.Windows.Forms.ComboBox cmbRegion;
	public System.Windows.Forms.TextBox txtUserName;
	public System.Windows.Forms.TextBox txtPassword;
	public System.Windows.Forms.ComboBox cmbDataSource;
	public System.Windows.Forms.CheckBox editRegion;
	private System.Windows.Forms.TabPage _SSTab1_TabPage0;
	public UpgradeHelpers.Gui.Controls.TabControlExtension SSTab1;
	public System.Windows.Forms.PictureBox Image2;
	public System.Windows.Forms.Label[] lblLabels = new System.Windows.Forms.Label[2];
	public UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1;
	private int SSTab1PreviousTab;
	//NOTE: The following procedure is required by the Windows Form Designer
	//It can be modified using the Windows Form Designer.
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
		components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
		ToolTipMain = new System.Windows.Forms.ToolTip(components);
		cmdHelp = new System.Windows.Forms.Button();
		cmdCancel = new System.Windows.Forms.Button();
		cmdOK = new System.Windows.Forms.Button();
		SSTab1 = new UpgradeHelpers.Gui.Controls.TabControlExtension();
		_SSTab1_TabPage0 = new System.Windows.Forms.TabPage();
		Label7 = new System.Windows.Forms.Label();
		lblReportPath = new System.Windows.Forms.Label();
		Label3 = new System.Windows.Forms.Label();
		Image3 = new System.Windows.Forms.PictureBox();
		Label5 = new System.Windows.Forms.Label();
		Image1 = new System.Windows.Forms.PictureBox();
		Label1 = new System.Windows.Forms.Label();
		_lblLabels_0 = new System.Windows.Forms.Label();
		_lblLabels_1 = new System.Windows.Forms.Label();
		Label2 = new System.Windows.Forms.Label();
		lblEditRegion = new System.Windows.Forms.Label();
		cmbRegion = new System.Windows.Forms.ComboBox();
		txtUserName = new System.Windows.Forms.TextBox();
		txtPassword = new System.Windows.Forms.TextBox();
		cmbDataSource = new System.Windows.Forms.ComboBox();
		editRegion = new System.Windows.Forms.CheckBox();
		Image2 = new System.Windows.Forms.PictureBox();
		SSTab1.SuspendLayout();
		_SSTab1_TabPage0.SuspendLayout();
		SuspendLayout();
		commandButtonHelper1 = new UpgradeHelpers.Gui.Controls.CommandButtonHelper(components);
		// 
		// cmdHelp
		// 
		cmdHelp.AllowDrop = true;
		cmdHelp.BackColor = System.Drawing.SystemColors.Control;
		cmdHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText;
		cmdHelp.Location = new System.Drawing.Point(368, 120);
		cmdHelp.Name = "cmdHelp";
		cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
		cmdHelp.Size = new System.Drawing.Size(76, 24);
		cmdHelp.TabIndex = 6;
		cmdHelp.Tag = "Cancel";
		cmdHelp.Text = "&Help";
		cmdHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		cmdHelp.UseVisualStyleBackColor = false;
		cmdHelp.Click += new System.EventHandler(cmdHelp_Click);
		// 
		// cmdCancel
		// 
		cmdCancel.AllowDrop = true;
		cmdCancel.BackColor = System.Drawing.SystemColors.Control;
		cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
		cmdCancel.Location = new System.Drawing.Point(368, 88);
		cmdCancel.Name = "cmdCancel";
		cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
		cmdCancel.Size = new System.Drawing.Size(76, 24);
		cmdCancel.TabIndex = 5;
		cmdCancel.Tag = "Cancel";
		cmdCancel.Text = "Cancel";
		cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		cmdCancel.UseVisualStyleBackColor = false;
		cmdCancel.Click += new System.EventHandler(cmdCancel_Click);
		// 
		// cmdOK
		// 
		cmdOK.AllowDrop = true;
		cmdOK.BackColor = System.Drawing.SystemColors.Control;
		cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
		cmdOK.Location = new System.Drawing.Point(368, 56);
		cmdOK.Name = "cmdOK";
		cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
		cmdOK.Size = new System.Drawing.Size(76, 24);
		cmdOK.TabIndex = 4;
		cmdOK.Tag = "OK";
		cmdOK.Text = "OK";
		cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
		cmdOK.UseVisualStyleBackColor = false;
		cmdOK.Click += new System.EventHandler(cmdOk_Click);
		// 
		// SSTab1
		// 
		SSTab1.Alignment = System.Windows.Forms.TabAlignment.Top;
		SSTab1.AllowDrop = true;
		SSTab1.Controls.Add(_SSTab1_TabPage0);
		SSTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		SSTab1.ItemSize = new System.Drawing.Size(175, 18);
		SSTab1.Location = new System.Drawing.Point(8, 56);
		SSTab1.Multiline = true;
		SSTab1.Name = "SSTab1";
		SSTab1.Size = new System.Drawing.Size(357, 237);
		SSTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
		SSTab1.TabIndex = 7;
		SSTab1.TabStop = false;
		SSTab1.SelectedIndexChanged += new System.EventHandler(SSTab1_SelectedIndexChanged);
		// 
		// _SSTab1_TabPage0
		// 
		_SSTab1_TabPage0.Controls.Add(Label7);
		_SSTab1_TabPage0.Controls.Add(lblReportPath);
		_SSTab1_TabPage0.Controls.Add(Label3);
		_SSTab1_TabPage0.Controls.Add(Image3);
		_SSTab1_TabPage0.Controls.Add(Label5);
		_SSTab1_TabPage0.Controls.Add(Image1);
		_SSTab1_TabPage0.Controls.Add(Label1);
		_SSTab1_TabPage0.Controls.Add(_lblLabels_0);
		_SSTab1_TabPage0.Controls.Add(_lblLabels_1);
		_SSTab1_TabPage0.Controls.Add(Label2);
		_SSTab1_TabPage0.Controls.Add(lblEditRegion);
		_SSTab1_TabPage0.Controls.Add(cmbRegion);
		_SSTab1_TabPage0.Controls.Add(txtUserName);
		_SSTab1_TabPage0.Controls.Add(txtPassword);
		_SSTab1_TabPage0.Controls.Add(cmbDataSource);
		_SSTab1_TabPage0.Controls.Add(editRegion);
		_SSTab1_TabPage0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		_SSTab1_TabPage0.Text = "&Login";
		// 
		// Label7
		// 
		Label7.AllowDrop = true;
		Label7.BackColor = System.Drawing.SystemColors.Control;
		Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Label7.ForeColor = System.Drawing.SystemColors.ControlText;
		Label7.Location = new System.Drawing.Point(16, 164);
		Label7.MinimumSize = new System.Drawing.Size(73, 17);
		Label7.Name = "Label7";
		Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
		Label7.Size = new System.Drawing.Size(73, 17);
		Label7.TabIndex = 8;
		Label7.Text = "Report Folder:";
		Label7.Visible = false;
		// 
		// lblReportPath
		// 
		lblReportPath.AllowDrop = true;
		lblReportPath.BackColor = System.Drawing.SystemColors.Control;
		lblReportPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		lblReportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblReportPath.ForeColor = System.Drawing.SystemColors.ControlText;
		lblReportPath.Location = new System.Drawing.Point(96, 164);
		lblReportPath.MinimumSize = new System.Drawing.Size(249, 33);
		lblReportPath.Name = "lblReportPath";
		lblReportPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
		lblReportPath.Size = new System.Drawing.Size(249, 33);
		lblReportPath.TabIndex = 9;
		lblReportPath.Visible = false;
		// 
		// Label3
		// 
		Label3.AllowDrop = true;
		Label3.BackColor = System.Drawing.SystemColors.Control;
		Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Label3.ForeColor = System.Drawing.SystemColors.ControlText;
		Label3.Location = new System.Drawing.Point(16, 132);
		Label3.MinimumSize = new System.Drawing.Size(49, 17);
		Label3.Name = "Label3";
		Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
		Label3.Size = new System.Drawing.Size(49, 17);
		Label3.TabIndex = 10;
		Label3.Text = "Region:";
		Label3.Visible = false;
		// 
		// Image3
		// 
		Image3.AllowDrop = true;
		Image3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Image3.Enabled = true;
		Image3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Image3.Image = (System.Drawing.Image) resources.GetObject("Image3.Image");
		Image3.Location = new System.Drawing.Point(8, 20);
		Image3.Name = "Image3";
		Image3.Size = new System.Drawing.Size(16, 16);
		Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
		Image3.Visible = true;
		// 
		// Label5
		// 
		Label5.AllowDrop = true;
		Label5.AutoSize = true;
		Label5.BackColor = System.Drawing.Color.Transparent;
		Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Label5.ForeColor = System.Drawing.SystemColors.ControlText;
		Label5.Location = new System.Drawing.Point(56, 28);
		Label5.MinimumSize = new System.Drawing.Size(57, 17);
		Label5.Name = "Label5";
		Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
		Label5.Size = new System.Drawing.Size(57, 17);
		Label5.TabIndex = 11;
		Label5.Text = "DB2/IDW";
		// 
		// Image1
		// 
		Image1.AllowDrop = true;
		Image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Image1.Enabled = true;
		Image1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Image1.Image = (System.Drawing.Image) resources.GetObject("Image1.Image");
		Image1.Location = new System.Drawing.Point(16, 20);
		Image1.Name = "Image1";
		Image1.Size = new System.Drawing.Size(32, 32);
		Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
		Image1.Visible = true;
		// 
		// Label1
		// 
		Label1.AllowDrop = true;
		Label1.BackColor = System.Drawing.SystemColors.Control;
		Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Label1.ForeColor = System.Drawing.SystemColors.ControlText;
		Label1.Location = new System.Drawing.Point(16, 4);
		Label1.MinimumSize = new System.Drawing.Size(233, 17);
		Label1.Name = "Label1";
		Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		Label1.Size = new System.Drawing.Size(233, 17);
		Label1.TabIndex = 12;
		Label1.Text = "Please enter your authentication information.";
		// 
		// _lblLabels_0
		// 
		_lblLabels_0.AllowDrop = true;
		_lblLabels_0.BackColor = System.Drawing.SystemColors.Control;
		_lblLabels_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
		_lblLabels_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		_lblLabels_0.ForeColor = System.Drawing.SystemColors.ControlText;
		_lblLabels_0.Location = new System.Drawing.Point(16, 60);
		_lblLabels_0.MinimumSize = new System.Drawing.Size(72, 17);
		_lblLabels_0.Name = "_lblLabels_0";
		_lblLabels_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
		_lblLabels_0.Size = new System.Drawing.Size(72, 17);
		_lblLabels_0.TabIndex = 13;
		_lblLabels_0.Tag = "&User Name:";
		_lblLabels_0.Text = "&User Name:";
		// 
		// _lblLabels_1
		// 
		_lblLabels_1.AllowDrop = true;
		_lblLabels_1.BackColor = System.Drawing.SystemColors.Control;
		_lblLabels_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		_lblLabels_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		_lblLabels_1.ForeColor = System.Drawing.SystemColors.ControlText;
		_lblLabels_1.Location = new System.Drawing.Point(16, 84);
		_lblLabels_1.MinimumSize = new System.Drawing.Size(72, 17);
		_lblLabels_1.Name = "_lblLabels_1";
		_lblLabels_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
		_lblLabels_1.Size = new System.Drawing.Size(72, 17);
		_lblLabels_1.TabIndex = 14;
		_lblLabels_1.Tag = "&Password:";
		_lblLabels_1.Text = "&Password:";
		// 
		// Label2
		// 
		Label2.AllowDrop = true;
		Label2.BackColor = System.Drawing.SystemColors.Control;
		Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Label2.ForeColor = System.Drawing.SystemColors.ControlText;
		Label2.Location = new System.Drawing.Point(16, 108);
		Label2.MinimumSize = new System.Drawing.Size(65, 17);
		Label2.Name = "Label2";
		Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
		Label2.Size = new System.Drawing.Size(65, 17);
		Label2.TabIndex = 15;
		Label2.Text = "Resource:";
		Label2.Visible = false;
		// 
		// lblEditRegion
		// 
		lblEditRegion.AllowDrop = true;
		lblEditRegion.BackColor = System.Drawing.SystemColors.Control;
		lblEditRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
		lblEditRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblEditRegion.ForeColor = System.Drawing.SystemColors.ControlText;
		lblEditRegion.Location = new System.Drawing.Point(224, 28);
		lblEditRegion.MinimumSize = new System.Drawing.Size(89, 25);
		lblEditRegion.Name = "lblEditRegion";
		lblEditRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
		lblEditRegion.Size = new System.Drawing.Size(89, 25);
		lblEditRegion.TabIndex = 17;
		lblEditRegion.Text = "Edit DB2 Region:";
		lblEditRegion.Visible = false;
		// 
		// cmbRegion
		// 
		cmbRegion.AllowDrop = true;
		cmbRegion.BackColor = System.Drawing.SystemColors.Window;
		cmbRegion.CausesValidation = true;
		cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cmbRegion.Enabled = false;
		cmbRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cmbRegion.ForeColor = System.Drawing.SystemColors.WindowText;
		cmbRegion.IntegralHeight = true;
		cmbRegion.Location = new System.Drawing.Point(96, 132);
		cmbRegion.Name = "cmbRegion";
		cmbRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
		cmbRegion.Size = new System.Drawing.Size(201, 21);
		cmbRegion.Sorted = false;
		cmbRegion.TabIndex = 3;
		cmbRegion.TabStop = true;
		cmbRegion.Visible = false;
		// 
		// txtUserName
		// 
		txtUserName.AcceptsReturn = true;
		txtUserName.AllowDrop = true;
		txtUserName.BackColor = System.Drawing.SystemColors.Window;
		txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
		txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
		txtUserName.Location = new System.Drawing.Point(96, 60);
		txtUserName.MaxLength = 0;
		txtUserName.Name = "txtUserName";
		txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
		txtUserName.Size = new System.Drawing.Size(219, 19);
		txtUserName.TabIndex = 0;
		txtUserName.Enter += new System.EventHandler(txtUserName_Enter);
		// 
		// txtPassword
		// 
		txtPassword.AcceptsReturn = true;
		txtPassword.AllowDrop = true;
		txtPassword.BackColor = System.Drawing.SystemColors.Window;
		txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
		txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
		txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
		txtPassword.Location = new System.Drawing.Point(96, 84);
		txtPassword.MaxLength = 0;
		txtPassword.Name = "txtPassword";
		txtPassword.PasswordChar = (char) 42;
		txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
		txtPassword.Size = new System.Drawing.Size(219, 19);
		txtPassword.TabIndex = 1;
		// 
		// cmbDataSource
		// 
		cmbDataSource.AllowDrop = true;
		cmbDataSource.BackColor = System.Drawing.SystemColors.Window;
		cmbDataSource.CausesValidation = true;
		cmbDataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cmbDataSource.Enabled = false;
		cmbDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cmbDataSource.ForeColor = System.Drawing.SystemColors.WindowText;
		cmbDataSource.IntegralHeight = true;
		cmbDataSource.Location = new System.Drawing.Point(96, 108);
		cmbDataSource.Name = "cmbDataSource";
		cmbDataSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
		cmbDataSource.Size = new System.Drawing.Size(219, 21);
		cmbDataSource.Sorted = false;
		cmbDataSource.TabIndex = 2;
		cmbDataSource.TabStop = true;
		cmbDataSource.Visible = false;
		cmbDataSource.Enter += new System.EventHandler(cmbDataSource_Enter);
		cmbDataSource.SelectedIndexChanged += new System.EventHandler(cmbDataSource_SelectedIndexChanged);
		// 
		// editRegion
		// 
		editRegion.AllowDrop = true;
		editRegion.Appearance = System.Windows.Forms.Appearance.Normal;
		editRegion.BackColor = System.Drawing.SystemColors.Control;
		editRegion.CausesValidation = true;
		editRegion.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
		editRegion.CheckState = System.Windows.Forms.CheckState.Unchecked;
		editRegion.Enabled = true;
		editRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		editRegion.ForeColor = System.Drawing.SystemColors.ControlText;
		editRegion.Location = new System.Drawing.Point(320, 28);
		editRegion.Name = "editRegion";
		editRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
		editRegion.Size = new System.Drawing.Size(17, 13);
		editRegion.TabIndex = 16;
		editRegion.TabStop = false;
		editRegion.Text = "Check1";
		editRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		editRegion.Visible = false;
		editRegion.CheckStateChanged += new System.EventHandler(editRegion_CheckStateChanged);
		// 
		// Image2
		// 
		Image2.AllowDrop = true;
		Image2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		Image2.Enabled = true;
		Image2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		Image2.Image = (System.Drawing.Image) resources.GetObject("Image2.Image");
		Image2.Location = new System.Drawing.Point(0, 0);
		Image2.Name = "Image2";
		Image2.Size = new System.Drawing.Size(445, 53);
		Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		Image2.Visible = true;
		// 
		// frmLogin
		// 
		AcceptButton = cmdOK;
		AllowDrop = true;
		AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		BackColor = System.Drawing.SystemColors.Control;
		CancelButton = cmdHelp;
		// VB6 Cancel=True only maps Esc to the button; it must not close the dialog (CancelButton sets DialogResult.Cancel).
		cmdHelp.DialogResult = System.Windows.Forms.DialogResult.None;
		ClientSize = new System.Drawing.Size(455, 348);
		Controls.Add(cmdHelp);
		Controls.Add(cmdCancel);
		Controls.Add(cmdOK);
		Controls.Add(SSTab1);
		Controls.Add(Image2);
		Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		Icon = (System.Drawing.Icon) resources.GetObject("frmLogin.Icon");
		Location = new System.Drawing.Point(248, 139);
		StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "frmLogin";
		RightToLeft = System.Windows.Forms.RightToLeft.No;
		ShowInTaskbar = false;
		Tag = "Login";
		Text = "BARS System Login";
		commandButtonHelper1.SetStyle(cmdHelp, 0);
		commandButtonHelper1.SetStyle(cmdCancel, 0);
		commandButtonHelper1.SetStyle(cmdOK, 0);
		Activated += new System.EventHandler(frmLogin_Activated);
		Closed += new System.EventHandler(Form_Closed);
		SSTab1.ResumeLayout(false);
		SSTab1.PerformLayout();
		_SSTab1_TabPage0.ResumeLayout(false);
		_SSTab1_TabPage0.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
	void ReLoadForm(bool addEvents)
	{
		InitializeHelp();
		InitializelblLabels();
		SSTab1PreviousTab = SSTab1.SelectedIndex;
	}
	void InitializelblLabels()
	{
		lblLabels = new System.Windows.Forms.Label[2];
		lblLabels[1] = _lblLabels_1;
		lblLabels[0] = _lblLabels_0;
	}
	#endregion
}
