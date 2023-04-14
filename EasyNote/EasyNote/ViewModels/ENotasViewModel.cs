using EasyNote.Controller;
using EasyNote.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace EasyNote.ViewModels
{
    public class ENotasViewModel
    {
        public string notasId { get; set; }
        public string NotasDescrip { get; set; }
        public string notas_Image { get; set; }

       
        FirebaseHelper services;

        
        private Command AddNotasCommand { get; }
        private ObservableCollection<ENotas> _ubicaciones = new ObservableCollection<ENotas>();
        public ObservableCollection<ENotas> Employees { get; set; }
        public ObservableCollection<string> Employeess { get; set; }
        public string SelectedEmployee { get; set; }

        public ObservableCollection<ENotas> ENotas
        {
            get { return _ubicaciones; }
            set
            {
                _ubicaciones = value;
                // OnPropertyChanged();
            }
        }
        

        public ENotasViewModel()
        {
            services = new FirebaseHelper();
            ENotas = services.getNotas();
   

        }


    }
}
