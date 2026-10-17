using System;
using System.ComponentModel;

namespace WinFormsApp4._11__.Models
{
    public class RepairOrder : INotifyPropertyChanged
    {
        private string id;
        private string customerName;
        private string phone;
        private string deviceType;
        private string description;
        private DateTime receivedDate;
        private decimal estimatedCost;
        private string status;
        private string imagePath;

        public string Id { get => id; set { id = value; OnPropertyChanged(nameof(Id)); } }
        public string CustomerName { get => customerName; set { customerName = value; OnPropertyChanged(nameof(CustomerName)); } }
        public string Phone { get => phone; set { phone = value; OnPropertyChanged(nameof(Phone)); } }
        public string DeviceType { get => deviceType; set { deviceType = value; OnPropertyChanged(nameof(DeviceType)); } }
        public string Description { get => description; set { description = value; OnPropertyChanged(nameof(Description)); } }
        public DateTime ReceivedDate { get => receivedDate; set { receivedDate = value; OnPropertyChanged(nameof(ReceivedDate)); } }
        public decimal EstimatedCost { get => estimatedCost; set { estimatedCost = value; OnPropertyChanged(nameof(EstimatedCost)); } }
        public string Status { get => status; set { status = value; OnPropertyChanged(nameof(Status)); } }
        public string ImagePath { get => imagePath; set { imagePath = value; OnPropertyChanged(nameof(ImagePath)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
