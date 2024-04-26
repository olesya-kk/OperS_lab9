using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperS_lab9
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
            // Инициализация ComboBox с возможными разделами реестра
            comboBoxRegistryRoot.Items.Add("HKEY_CLASSES_ROOT");
            comboBoxRegistryRoot.Items.Add("HKEY_CURRENT_USER");
            comboBoxRegistryRoot.Items.Add("HKEY_LOCAL_MACHINE");
            comboBoxRegistryRoot.Items.Add("HKEY_USERS");
            comboBoxRegistryRoot.Items.Add("HKEY_CURRENT_CONFIG");
            comboBoxRegistryRoot.SelectedIndex = 0; // Выбираем HKEY_CLASSES_ROOT по умолчанию
        }
        // Метод для получения выбранного раздела реестра
        private RegistryKey GetSelectedRegistryRoot()
        {
            string selectedRoot = comboBoxRegistryRoot.SelectedItem.ToString();
            RegistryKey registryRoot = null;

            // Определяем выбранный раздел реестра
            switch (selectedRoot)
            {
                case "HKEY_CLASSES_ROOT":
                    registryRoot = Registry.ClassesRoot;
                    break;
                case "HKEY_CURRENT_USER":
                    registryRoot = Registry.CurrentUser;
                    break;
                case "HKEY_LOCAL_MACHINE":
                    registryRoot = Registry.LocalMachine;
                    break;
                case "HKEY_USERS":
                    registryRoot = Registry.Users;
                    break;
                case "HKEY_CURRENT_CONFIG":
                    registryRoot = Registry.CurrentConfig;
                    break;
            }

            return registryRoot;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            RegistryKey registryRoot = GetSelectedRegistryRoot();

            try
            {
                // Чтение значения из реестра
                string valueName = textBoxValueName.Text;
                object value = registryRoot.GetValue(valueName);
                if (value != null)
                {
                    textBoxValue.Text = value.ToString();
                    MessageBox.Show($"Значение {valueName} успешно прочитано из реестра.");
                }
                else
                {
                    MessageBox.Show($"Значение {valueName} не найдено в реестре.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении значения из реестра: {ex.Message}");
            }

        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            RegistryKey registryRoot = GetSelectedRegistryRoot();

            try
            {
                // Получаем имя значения и его новое значение из текстовых полей
                string valueName = textBoxValueName.Text;
                string valueData = textBoxValue.Text;

                // Записываем новое значение в реестр
                registryRoot.SetValue(valueName, valueData);
                MessageBox.Show($"Значение {valueName} успешно записано в реестр.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи значения в реестр: {ex.Message}");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RegistryKey registryRoot = GetSelectedRegistryRoot();

            try
            {
                // Получаем имя значения из текстового поля
                string valueName = textBoxValueName.Text;

                // Удаляем значение из реестра
                registryRoot.DeleteValue(valueName);
                MessageBox.Show($"Значение {valueName} успешно удалено из реестра.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении значения из реестра: {ex.Message}");
            }
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            const int WM_SETTINGCHANGE = 0x001A;
            if (m.Msg == WM_SETTINGCHANGE)
            {
                listBoxKeys.Items.Clear();
                buttonRead.PerformClick();
            }
            base.WndProc(ref m);
        }

    }
}
