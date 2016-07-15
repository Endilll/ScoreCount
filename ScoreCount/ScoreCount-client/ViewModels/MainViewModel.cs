using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ScoreCount_client.Utilities;

namespace ScoreCount_client.ViewModels  {
	public class MainViewModel : INotifyPropertyChanged {
		public ICommand ExitCommand { get; set; }

		public MainViewModel() {
			ExitCommand = new RelayCommand(arg => Exit());
		}

		private void Exit() {
			Application.Current.Shutdown();
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
