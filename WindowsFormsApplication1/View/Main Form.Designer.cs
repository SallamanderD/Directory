namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editingToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАлфивитуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИндексуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryControl = new System.Windows.Forms.TabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.criminalTable = new System.Windows.Forms.ListView();
            this.dataID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataLastBusy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataColorEye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataColorHair = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataNowAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataFeatures = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataCitizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.archievePage = new System.Windows.Forms.TabPage();
            this.archiveTable = new System.Windows.Forms.ListView();
            this.criminalID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.criminalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.criminalSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.criminalBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.criminalNickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.criminalLastBusy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPage = new System.Windows.Forms.TabPage();
            this.groupChooseLabel = new System.Windows.Forms.Label();
            this.groupChooseComboBox = new System.Windows.Forms.ComboBox();
            this.groupTable = new System.Windows.Forms.ListView();
            this.groupID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupLastBusy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupHeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupColorEye = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupColorHair = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupNowAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupNameGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupFeatures = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupCitizenship = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTool = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToArchieveToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.topMenu.SuspendLayout();
            this.directoryControl.SuspendLayout();
            this.dataPage.SuspendLayout();
            this.archievePage.SuspendLayout();
            this.groupPage.SuspendLayout();
            this.columnTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.editingToolStrip,
            this.сортировкаToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1250, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripItem,
            this.loadToolStripItem});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(48, 20);
            this.fileToolStrip.Text = "Файл";
            // 
            // saveToolStripItem
            // 
            this.saveToolStripItem.Name = "saveToolStripItem";
            this.saveToolStripItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripItem.Text = "Сохранить";
            this.saveToolStripItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripItem
            // 
            this.loadToolStripItem.Name = "loadToolStripItem";
            this.loadToolStripItem.Size = new System.Drawing.Size(132, 22);
            this.loadToolStripItem.Text = "Загрузить";
            this.loadToolStripItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // editingToolStrip
            // 
            this.editingToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripItem,
            this.clearAllToolStripItem});
            this.editingToolStrip.Name = "editingToolStrip";
            this.editingToolStrip.Size = new System.Drawing.Size(108, 20);
            this.editingToolStrip.Text = "Редактирование";
            // 
            // addToolStripItem
            // 
            this.addToolStripItem.Name = "addToolStripItem";
            this.addToolStripItem.Size = new System.Drawing.Size(147, 22);
            this.addToolStripItem.Text = "Добавить";
            this.addToolStripItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // clearAllToolStripItem
            // 
            this.clearAllToolStripItem.Name = "clearAllToolStripItem";
            this.clearAllToolStripItem.Size = new System.Drawing.Size(147, 22);
            this.clearAllToolStripItem.Text = "Очистить все";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поАлфивитуToolStripMenuItem,
            this.поИндексуToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поАлфивитуToolStripMenuItem
            // 
            this.поАлфивитуToolStripMenuItem.Name = "поАлфивитуToolStripMenuItem";
            this.поАлфивитуToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поАлфивитуToolStripMenuItem.Text = "По Алфивиту";
            // 
            // поИндексуToolStripMenuItem
            // 
            this.поИндексуToolStripMenuItem.Name = "поИндексуToolStripMenuItem";
            this.поИндексуToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поИндексуToolStripMenuItem.Text = "По Индексу";
            // 
            // directoryControl
            // 
            this.directoryControl.Controls.Add(this.dataPage);
            this.directoryControl.Controls.Add(this.archievePage);
            this.directoryControl.Controls.Add(this.groupPage);
            this.directoryControl.Location = new System.Drawing.Point(-3, 27);
            this.directoryControl.Name = "directoryControl";
            this.directoryControl.SelectedIndex = 0;
            this.directoryControl.Size = new System.Drawing.Size(1253, 527);
            this.directoryControl.TabIndex = 1;
            // 
            // dataPage
            // 
            this.dataPage.BackColor = System.Drawing.SystemColors.Control;
            this.dataPage.Controls.Add(this.button2);
            this.dataPage.Controls.Add(this.button1);
            this.dataPage.Controls.Add(this.criminalTable);
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(1245, 501);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Данные";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // criminalTable
            // 
            this.criminalTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataID,
            this.dataName,
            this.dataSurname,
            this.dataBornDate,
            this.dataNickname,
            this.dataLastBusy,
            this.dataHeight,
            this.dataColorEye,
            this.dataColorHair,
            this.dataNowAdress,
            this.dataGroup,
            this.dataFeatures,
            this.dataCitizenship});
            this.criminalTable.FullRowSelect = true;
            this.criminalTable.GridLines = true;
            this.criminalTable.Location = new System.Drawing.Point(0, 122);
            this.criminalTable.Name = "criminalTable";
            this.criminalTable.Size = new System.Drawing.Size(1246, 383);
            this.criminalTable.TabIndex = 0;
            this.criminalTable.UseCompatibleStateImageBehavior = false;
            this.criminalTable.View = System.Windows.Forms.View.Details;
            this.criminalTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // dataID
            // 
            this.dataID.Text = "№";
            this.dataID.Width = 31;
            // 
            // dataName
            // 
            this.dataName.DisplayIndex = 2;
            this.dataName.Text = "Имя";
            this.dataName.Width = 111;
            // 
            // dataSurname
            // 
            this.dataSurname.DisplayIndex = 1;
            this.dataSurname.Text = "Фамилия";
            this.dataSurname.Width = 107;
            // 
            // dataBornDate
            // 
            this.dataBornDate.Text = "Дата Рождения";
            this.dataBornDate.Width = 133;
            // 
            // dataNickname
            // 
            this.dataNickname.Text = "Кличка";
            this.dataNickname.Width = 117;
            // 
            // dataLastBusy
            // 
            this.dataLastBusy.Text = "Последнее дело";
            this.dataLastBusy.Width = 132;
            // 
            // dataHeight
            // 
            this.dataHeight.Text = "Рост";
            this.dataHeight.Width = 49;
            // 
            // dataColorEye
            // 
            this.dataColorEye.Text = "Цвет Глаз";
            this.dataColorEye.Width = 83;
            // 
            // dataColorHair
            // 
            this.dataColorHair.Text = "Цвет Волос";
            this.dataColorHair.Width = 71;
            // 
            // dataNowAdress
            // 
            this.dataNowAdress.Text = "Нынешний Адресс";
            this.dataNowAdress.Width = 116;
            // 
            // dataGroup
            // 
            this.dataGroup.Text = "Группировка";
            this.dataGroup.Width = 113;
            // 
            // dataFeatures
            // 
            this.dataFeatures.Text = "Ос. приметы";
            this.dataFeatures.Width = 83;
            // 
            // dataCitizenship
            // 
            this.dataCitizenship.Text = "Гражданство";
            this.dataCitizenship.Width = 94;
            // 
            // archievePage
            // 
            this.archievePage.Controls.Add(this.archiveTable);
            this.archievePage.Location = new System.Drawing.Point(4, 22);
            this.archievePage.Name = "archievePage";
            this.archievePage.Padding = new System.Windows.Forms.Padding(3);
            this.archievePage.Size = new System.Drawing.Size(1245, 501);
            this.archievePage.TabIndex = 1;
            this.archievePage.Text = "Архив";
            this.archievePage.UseVisualStyleBackColor = true;
            // 
            // archiveTable
            // 
            this.archiveTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.criminalID,
            this.criminalName,
            this.criminalSurname,
            this.criminalBornDate,
            this.criminalNickName,
            this.criminalLastBusy});
            this.archiveTable.Location = new System.Drawing.Point(0, 0);
            this.archiveTable.Name = "archiveTable";
            this.archiveTable.Size = new System.Drawing.Size(1245, 505);
            this.archiveTable.TabIndex = 0;
            this.archiveTable.UseCompatibleStateImageBehavior = false;
            this.archiveTable.View = System.Windows.Forms.View.Details;
            // 
            // criminalID
            // 
            this.criminalID.Text = "№";
            this.criminalID.Width = 48;
            // 
            // criminalName
            // 
            this.criminalName.Text = "Имя";
            this.criminalName.Width = 80;
            // 
            // criminalSurname
            // 
            this.criminalSurname.Text = "Фамилия";
            this.criminalSurname.Width = 83;
            // 
            // criminalBornDate
            // 
            this.criminalBornDate.Text = "Дата Рождения";
            this.criminalBornDate.Width = 105;
            // 
            // criminalNickName
            // 
            this.criminalNickName.Text = "Кличка";
            // 
            // criminalLastBusy
            // 
            this.criminalLastBusy.Text = "Последнее Дело";
            this.criminalLastBusy.Width = 107;
            // 
            // groupPage
            // 
            this.groupPage.BackColor = System.Drawing.SystemColors.Control;
            this.groupPage.Controls.Add(this.groupChooseLabel);
            this.groupPage.Controls.Add(this.groupChooseComboBox);
            this.groupPage.Controls.Add(this.groupTable);
            this.groupPage.Location = new System.Drawing.Point(4, 22);
            this.groupPage.Name = "groupPage";
            this.groupPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupPage.Size = new System.Drawing.Size(1245, 501);
            this.groupPage.TabIndex = 2;
            this.groupPage.Text = "Группировки";
            // 
            // groupChooseLabel
            // 
            this.groupChooseLabel.AutoSize = true;
            this.groupChooseLabel.Location = new System.Drawing.Point(6, 13);
            this.groupChooseLabel.Name = "groupChooseLabel";
            this.groupChooseLabel.Size = new System.Drawing.Size(75, 13);
            this.groupChooseLabel.TabIndex = 2;
            this.groupChooseLabel.Text = "Группировка:";
            // 
            // groupChooseComboBox
            // 
            this.groupChooseComboBox.FormattingEnabled = true;
            this.groupChooseComboBox.Location = new System.Drawing.Point(81, 9);
            this.groupChooseComboBox.Name = "groupChooseComboBox";
            this.groupChooseComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupChooseComboBox.TabIndex = 1;
            this.groupChooseComboBox.SelectedIndexChanged += new System.EventHandler(this.groupChooseComboBox_SelectedIndexChanged);
            // 
            // groupTable
            // 
            this.groupTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.groupID,
            this.groupSurname,
            this.groupName,
            this.groupBornDate,
            this.groupNickname,
            this.groupLastBusy,
            this.groupHeight,
            this.groupColorEye,
            this.groupColorHair,
            this.groupNowAdress,
            this.groupNameGroup,
            this.groupFeatures,
            this.groupCitizenship});
            this.groupTable.FullRowSelect = true;
            this.groupTable.GridLines = true;
            this.groupTable.Location = new System.Drawing.Point(0, 121);
            this.groupTable.Name = "groupTable";
            this.groupTable.Size = new System.Drawing.Size(1242, 380);
            this.groupTable.TabIndex = 0;
            this.groupTable.UseCompatibleStateImageBehavior = false;
            this.groupTable.View = System.Windows.Forms.View.Details;
            // 
            // groupID
            // 
            this.groupID.Text = "№";
            // 
            // groupSurname
            // 
            this.groupSurname.Text = "Фамилия";
            // 
            // groupName
            // 
            this.groupName.Text = "Имя";
            // 
            // groupBornDate
            // 
            this.groupBornDate.Text = "Дата Рождения";
            // 
            // groupNickname
            // 
            this.groupNickname.Text = "Кличка";
            // 
            // groupLastBusy
            // 
            this.groupLastBusy.Text = "Последнее Дело";
            // 
            // groupHeight
            // 
            this.groupHeight.Text = "Рост";
            // 
            // groupColorEye
            // 
            this.groupColorEye.Text = "Цвет Глаз";
            // 
            // groupColorHair
            // 
            this.groupColorHair.Text = "Цвет Волос";
            // 
            // groupNowAdress
            // 
            this.groupNowAdress.Text = "Нынешний Адресс";
            // 
            // groupNameGroup
            // 
            this.groupNameGroup.Text = "Группировка";
            // 
            // groupFeatures
            // 
            this.groupFeatures.Text = "Ос. Приметы";
            // 
            // groupCitizenship
            // 
            this.groupCitizenship.Text = "Гражданство";
            // 
            // columnTool
            // 
            this.columnTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripItem,
            this.editToolStripItem,
            this.moveToArchieveToolStripItem});
            this.columnTool.Name = "contextMenuStrip1";
            this.columnTool.Size = new System.Drawing.Size(192, 70);
            // 
            // deleteToolStripItem
            // 
            this.deleteToolStripItem.Name = "deleteToolStripItem";
            this.deleteToolStripItem.Size = new System.Drawing.Size(191, 22);
            this.deleteToolStripItem.Text = "Удалить";
            this.deleteToolStripItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // editToolStripItem
            // 
            this.editToolStripItem.Name = "editToolStripItem";
            this.editToolStripItem.Size = new System.Drawing.Size(191, 22);
            this.editToolStripItem.Text = "Изменить";
            this.editToolStripItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // moveToArchieveToolStripItem
            // 
            this.moveToArchieveToolStripItem.Name = "moveToArchieveToolStripItem";
            this.moveToArchieveToolStripItem.Size = new System.Drawing.Size(191, 22);
            this.moveToArchieveToolStripItem.Text = "Переместить в Архив";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1250, 554);
            this.Controls.Add(this.directoryControl);
            this.Controls.Add(this.topMenu);
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainForm";
            this.Text = "Main_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.directoryControl.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.archievePage.ResumeLayout(false);
            this.groupPage.ResumeLayout(false);
            this.groupPage.PerformLayout();
            this.columnTool.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem editingToolStrip;
        private System.Windows.Forms.TabControl directoryControl;
        private System.Windows.Forms.TabPage dataPage;
        private System.Windows.Forms.TabPage archievePage;
        private System.Windows.Forms.ListView criminalTable;
        private System.Windows.Forms.ColumnHeader dataID;
        private System.Windows.Forms.ColumnHeader dataName;
        private System.Windows.Forms.ColumnHeader dataSurname;
        private System.Windows.Forms.ColumnHeader dataBornDate;
        private System.Windows.Forms.ColumnHeader dataNickname;
        private System.Windows.Forms.ColumnHeader dataLastBusy;
        private System.Windows.Forms.ColumnHeader dataHeight;
        private System.Windows.Forms.ColumnHeader dataColorEye;
        private System.Windows.Forms.ColumnHeader dataColorHair;
        private System.Windows.Forms.ToolStripMenuItem addToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripItem;
        private System.Windows.Forms.ColumnHeader dataNowAdress;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripItem;
        private System.Windows.Forms.ContextMenuStrip columnTool;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem moveToArchieveToolStripItem;
        private System.Windows.Forms.ListView archiveTable;
        private System.Windows.Forms.ColumnHeader criminalID;
        private System.Windows.Forms.ColumnHeader criminalName;
        private System.Windows.Forms.ColumnHeader criminalSurname;
        private System.Windows.Forms.ColumnHeader criminalBornDate;
        private System.Windows.Forms.ColumnHeader criminalNickName;
        private System.Windows.Forms.ColumnHeader criminalLastBusy;
        private System.Windows.Forms.ColumnHeader dataGroup;
        private System.Windows.Forms.ColumnHeader dataFeatures;
        private System.Windows.Forms.ColumnHeader dataCitizenship;
        private System.Windows.Forms.TabPage groupPage;
        private System.Windows.Forms.ListView groupTable;
        private System.Windows.Forms.Label groupChooseLabel;
        private System.Windows.Forms.ComboBox groupChooseComboBox;
        private System.Windows.Forms.ColumnHeader groupID;
        private System.Windows.Forms.ColumnHeader groupSurname;
        private System.Windows.Forms.ColumnHeader groupName;
        private System.Windows.Forms.ColumnHeader groupBornDate;
        private System.Windows.Forms.ColumnHeader groupNickname;
        private System.Windows.Forms.ColumnHeader groupLastBusy;
        private System.Windows.Forms.ColumnHeader groupHeight;
        private System.Windows.Forms.ColumnHeader groupColorEye;
        private System.Windows.Forms.ColumnHeader groupColorHair;
        private System.Windows.Forms.ColumnHeader groupNowAdress;
        private System.Windows.Forms.ColumnHeader groupNameGroup;
        private System.Windows.Forms.ColumnHeader groupFeatures;
        private System.Windows.Forms.ColumnHeader groupCitizenship;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАлфивитуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИндексуToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}