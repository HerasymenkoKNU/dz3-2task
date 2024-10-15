using System;
using Microsoft.Maui.Controls;
namespace dz3_task2_2_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Отримати значення з поля введення
            if (int.TryParse(numberEntry.Text, out int number))
            {
                // Відобразити повідомлення
                DisplayAlert("Результат", $"Ви ввели число {number}.", "ОК");
            }
            else
            {
                // Якщо введено не число, показати повідомлення про помилку
                DisplayAlert("Помилка", "Будь ласка, введіть коректне ціле число.", "ОК");
            }
        }
    }

}
