using Optsol.Components.Application.ViewModel;
using System.Collections.Generic;

namespace Optsol.Components.Application.Result
{
    public interface IServiceResultFactory
    {
        ServiceResut<TViewModel> Create<TViewModel>(TViewModel viewModel) where TViewModel : BaseViewModel;
        ServiceResultList<TViewModel> Create<TViewModel>(IEnumerable<TViewModel> viewModels) where TViewModel : BaseViewModel;
        ServiceResult Create();
    }
}