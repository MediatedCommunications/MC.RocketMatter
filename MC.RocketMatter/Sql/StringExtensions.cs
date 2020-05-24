using System;
using System.Collections.Generic;

namespace MC.RocketMatter.Sql {
    public static class StringExtensions {
        public static bool IsComplete(this string This) {
            var Valid = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) {
                "Complete",
                "Completed",
                "Archived",
            };

            return Valid.Contains(This);
        }

        public static bool IsIncomplete(this string This) {
            var Valid = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) {
                "Incomplete",
            };

            return Valid.Contains(This);
        }

        public static bool IsOpen(this string This) {
            var Valid = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) {
                "Open",
            };

            return Valid.Contains(This);
        }

        public static bool IsClosed(this string This) {
            var Valid = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) {
                "Close",
                "Closed",
            };

            return Valid.Contains(This);
        }

    }


}
