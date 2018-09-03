using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Movel.Utils;

namespace Movel.Uwp
{
    public class UwpMovelDispatcher : IMovelDispatcher
    {
        public async Task<T> DispatchAsync<T>(Func<Task<T>> task)
        {
            var dispatcher = CoreApplication.MainView.Dispatcher;
            var completionSource = new TaskCompletionSource<T>();
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => completionSource.SetResult(await task()));
            return await completionSource.Task;
        }

        public async Task DispatchAsync(Func<Task> task)
        {
            var dispatcher = CoreApplication.MainView.Dispatcher;
            var completionSource = new TaskCompletionSource<object>();
            await dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
            {
                await task();
                completionSource.SetResult(null);
            });
            await completionSource.Task;
        }
    }
}