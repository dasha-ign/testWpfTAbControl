using MathCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWpfTAbControl
{
    public class View1Model : ViewModel
    {

        #region ModelNumber : int - model number

        ///<summary>model number</summary>
        private int _ModelNumber;

        ///<summary>model number</summary>
        public int ModelNumber { get => _ModelNumber; set => Set(ref _ModelNumber, value); }

        #endregion

        public View1Model(int num)
        {
            ModelNumber = num;
        }
    }
}
