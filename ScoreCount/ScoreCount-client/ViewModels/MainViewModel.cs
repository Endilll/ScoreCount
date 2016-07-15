using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using oop_project_mvvm;

namespace ScoreCount_client.ViewModels {
	public class MainViewModel {
		public ICommand ExitCommand { get; set; }

		public MainViewModel() {
			ExitCommand = new RelayCommand(arg => Exit());
		}

		void Exit() {
			Application.Current.Shutdown();
		}
	}
}
