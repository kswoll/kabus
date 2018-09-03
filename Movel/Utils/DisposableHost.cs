﻿using System;
using System.Collections.Generic;

namespace Movel.Utils
{
    public class DisposableHost : IDisposableHost
    {
        private readonly List<IDisposable> disposables = new List<IDisposable>();

        private bool isDisposed;

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
            foreach (var disposable in disposables)
            {
                disposable.Dispose();
            }

            disposables.Clear();
        }

        public void AddDisposable(IDisposable disposable)
        {
            disposables.Add(disposable);
        }

        public void RemoveDisposable(IDisposable disposable)
        {
            disposables.Add(disposable);
        }
    }
}