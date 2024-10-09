using CommunityToolkit.Mvvm.Input;
using MauiAgendaBuddy.Services.Navigation;


namespace MauiAgendaBuddy.ViewModels.Base;

public interface IViewModelBase : IQueryAttributable
{
    public INavigationService NavigationService { get; }

    public IAsyncRelayCommand InitializeAsyncCommand { get; }

    public bool IsBusy { get; }

    public bool IsInitialized { get; }

    Task InitializeAsync();
}