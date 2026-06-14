using System;
using System.Collections.Generic;
using System.Text;

namespace pboFinalProfject.View
{
    public interface IFormLoadable
    {
        void LoadData();
        void RefreshData();
        void ResetForm();
        void SetupUIByRole();
    }
}
