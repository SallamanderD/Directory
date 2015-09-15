using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication1
{
    class Controller
    {

        // Метод для обновления основной таблицы, архива и группировок.        
        public static void InintializeTable(ListOfCriminals directoryList, ListView criminalTable, ListOfCriminalGroup listCriminalGroup)
        {
            
            criminalTable.Items.Clear();
            foreach (Criminal criminal in directoryList.Data)
            {
                AddColumns(criminal, criminalTable);
                CheckAndAddGroup(criminal, listCriminalGroup);
            }
            
        }

        // Добавление строки в таблицу.
        public static void AddColumns(Criminal criminal, ListView criminalTable)
        {            
            ListViewItem tempItem = new ListViewItem(criminal.Index.ToString());
            tempItem.SubItems.Add(criminal.Name);
            tempItem.SubItems.Add(criminal.Surname);
            tempItem.SubItems.Add(criminal.BornDate);
            tempItem.SubItems.Add(criminal.Nickname);
            tempItem.SubItems.Add(criminal.LastBusy);
            tempItem.SubItems.Add(criminal.Height.ToString());
            tempItem.SubItems.Add(criminal.ColorEye);
            tempItem.SubItems.Add(criminal.ColorHair);
            tempItem.SubItems.Add(criminal.NowAdress);
            tempItem.SubItems.Add(criminal.Group);
            tempItem.SubItems.Add(criminal.Features);
            tempItem.SubItems.Add(criminal.Cityzenship);
            criminalTable.Items.Add(tempItem);
                                       
        }

        public static void Search(ListOfCriminals fullDirectory, SearchForm src, ListView lv)
        {
            lv.Items.Clear();
            ListOfCriminals resultList = new ListOfCriminals();
            foreach (Criminal criminal in fullDirectory.Data)
            {
                if(criminal.Name.Contains(src.nameText.Text) && criminal.Surname.Contains(src.surnameText.Text) 
                    && criminal.Nickname.Contains(src.nicknameText.Text) && criminal.LastBusy.Contains(src.lastBusyText.Text) 
                    && criminal.Height.Contains(src.heightText.Text) && criminal.Group.Contains(src.groupText.Text) 
                    && criminal.Features.Contains(src.featuresText.Text) && criminal.ColorHair.Contains(src.colorHairText.Text) 
                    && criminal.ColorEye.Contains(src.colorEyeText.Text) && criminal.Cityzenship.Contains(src.citizenText.Text)
                    && criminal.BornDate.Contains(src.bornDateText.Text) && criminal.NowAdress.Contains(src.nowAdressText.Text))
                {
                    resultList.Data.Add(criminal);
                }
            }
            foreach (Criminal criminal in resultList.Data)
            {
                AddColumns(criminal, lv);
            }


        }

        // Проверка на существование группы, заданой у преступника и соответственно создание таковой или добавление преступника в уже существующую.
        public static void CheckAndAddGroup(Criminal criminal, ListOfCriminalGroup listCriminalGroup)
        {
            foreach (CriminalGroup criminalGroup in listCriminalGroup.criminalGroupData)
            {
                if (criminalGroup.name == criminal.Group && criminal.Group != "Неизвестна")
                {
                    criminalGroup.member.Add(criminal);
                    return;
                }
                else if (criminal.Group == "Неизвестна")
                    return;                  
            }
            CriminalGroup tempGroup = new CriminalGroup();
            tempGroup.name = criminal.Group;
            tempGroup.member.Add(criminal);
            listCriminalGroup.criminalGroupData.Add(tempGroup);
        }

        // Заполнение КомбоБокса данными из списка криминальных групп
        public static void InitializeComboBox(ListOfCriminalGroup listCriminalGroup, ComboBox BoxOfGroup)
        {
            BoxOfGroup.Items.Clear();
            foreach (CriminalGroup criminalGroup in listCriminalGroup.criminalGroupData)
            {
                BoxOfGroup.Items.Add(criminalGroup.name);
            }
        }

        // Метод для создания списка преступных группировок и заполнения ими КомбоБокса.
        public static void InitializeFullGroupSystem(ListOfCriminals FullDirectory, ComboBox BoxofGroup, ListOfCriminalGroup GroupList)
        {
            BoxofGroup.Items.Clear();
            GroupList.criminalGroupData.Clear();
            foreach (Criminal criminal in FullDirectory.Data)
            {
                CheckAndAddGroup(criminal, GroupList);
            }
            InitializeComboBox(GroupList, BoxofGroup);
        }
        
        // Метод для сохранения, путем бинарной сериализации.
        public static void SaveData(ListOfCriminals directoryList)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter SaveFormatter = new BinaryFormatter();
                using (FileStream SaveStream = new FileStream(SaveDialog.FileName, FileMode.OpenOrCreate))
                {
                    SaveFormatter.Serialize(SaveStream, directoryList.Data);
                }
            }
        }

        // Метод для редактирования строки в таблице а также проверки списка группировок.
        public static void EditColumns(Criminal criminal, ListOfCriminals directoryList, int index, ListView criminalTable, ListOfCriminalGroup listCriminalGroup)
        {
            criminal.Index = index + 1;
            directoryList.Data[index] = criminal;
            criminalTable.Items.Clear();
            
        }

        //  Метод для загрузки из файла с помощью все той же бинарной сериализации.
        public static void LoadData(ListOfCriminals directoryList)
        {            
            OpenFileDialog LoadDialog = new OpenFileDialog();
            if (LoadDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter LoadFormatter = new BinaryFormatter();
                using (FileStream LoadStream = new FileStream(LoadDialog.FileName, FileMode.OpenOrCreate))
                {
                    directoryList.Data = (List<Criminal>)LoadFormatter.Deserialize(LoadStream);
                }
            }
        }

        // Метод удаления строки из таблицы.
        public static void DeleteColumns(int index, ListView criminalTable, ListOfCriminals directoryList, ListOfCriminalGroup listCriminalGroup)
        {
            directoryList.Data.RemoveAt(index);
            for (int i = index; i < directoryList.Data.Count; i++)
                directoryList.Data[i].Index += -1;
            criminalTable.Items.Clear();
            
        }
    }
}
