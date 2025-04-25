using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Properties;
using UnityEngine;
using Commands;

namespace Assets.Scripts
{
    public class TestViewModel : ViewModel
    {
        [CreateProperty]
        public RelayCommand TestCommand { get; private set; }

        public TestViewModel()
        {
            TestCommand = new RelayCommand(ExecuteTestCommand);
        }

        void ExecuteTestCommand(object obj)
        {
            Debug.Log("Hello world!");
        }
    }
}
