using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Movel.Utils;

namespace Movel.Uwp
{
    public class MovelPage<T> : Page, IDisposableHost
        where T : class
    {
        private readonly DisposableHost disposableHost = new DisposableHost();

        private T viewModel;
        private bool isDisposed;

        public MovelPage()
        {
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            ViewModel = (T)args.NewValue;
        }

        public T ViewModel
        {
            get => viewModel;
            set
            {
                if (viewModel != value)
                {
                    (viewModel as IDisposable)?.Dispose();
                    var oldViewModel = viewModel;
                    viewModel = value;
                    DataContext = value;
                    OnViewModelChanged(oldViewModel, value);
                }
            }
        }

        protected virtual void OnViewModelChanged(T oldModel, T newModel)
        {
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                OnDispose();
                isDisposed = true;
            }
        }

        protected virtual void OnDispose()
        {
            disposableHost.Dispose();
            (ViewModel as IDisposable)?.Dispose();
        }

        public void AddDisposable(IDisposable disposable)
        {
            disposableHost.AddDisposable(disposable);
        }

        public void RemoveDisposable(IDisposable disposable)
        {
            disposableHost.RemoveDisposable(disposable);
        }
    }
}