﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MC.RocketMatter {
    public static class TaskExtensions {
        internal static ConfiguredTaskAwaitable DefaultAwait(this Task This) {
            return This.RunOnAnyThread();
        }

        internal static ConfiguredTaskAwaitable<T> DefaultAwait<T>(this Task<T> This) {
            return This.RunOnAnyThread();
        }

        private const bool __RunOnAnyThread = false;
        internal static ConfiguredTaskAwaitable RunOnAnyThread(this Task This) {
            return This.ConfigureAwait(__RunOnAnyThread);
        }

        internal static ConfiguredTaskAwaitable<T> RunOnAnyThread<T>(this Task<T> This) {
            return This.ConfigureAwait(__RunOnAnyThread);
        }
    }

}
