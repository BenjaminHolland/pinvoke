﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

#pragma warning disable SA1303 // Const field names must begin with upper-case letter

namespace PInvoke
{
    /// <summary>
    /// Defines names of API Set dll's that may be used in P/Invoke signatures.
    /// </summary>
    /// <remarks>
    /// The API set names and members are documented here:
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/hh802935(v=vs.85).aspx
    /// </remarks>
    public static class ApiSets
    {
        /// <summary>
        /// The "api-ms-win-core-localization-l1-2-0.dll" constant.
        /// </summary>
        public const string api_ms_win_core_localization_l1_2_0 = "api-ms-win-core-localization-l1-2-0.dll";

        /// <summary>
        /// The "api-ms-win-core-localization-l1-2-1.dll" constant.
        /// </summary>
        public const string api_ms_win_core_localization_l1_2_1 = "api-ms-win-core-localization-l1-2-1.dll";

        /// <summary>
        /// The "api-ms-win-core-processthreads-l1-1-2.dll" constant.
        /// </summary>
        public const string api_ms_win_core_processthreads_l1_1_2 = "api-ms-win-core-processthreads-l1-1-2.dll";

        /// <summary>
        /// The "api-ms-win-core-io-l1-1-1.dll" constant.
        /// </summary>
        public const string api_ms_win_core_io_l1_1_1 = "api-ms-win-core-io-l1-1-1.dll";

        /// <summary>
        /// The "api-ms-win-core-file-l1-2-1.dll" constant.
        /// </summary>
        public const string api_ms_win_core_file_l1_2_1 = "api-ms-win-core-file-l1-2-1.dll";

        /// <summary>
        /// The "api-ms-win-core-synch-l1-2-0.dll" constant.
        /// </summary>
        public const string api_ms_win_core_synch_l1_2_0 = "api-ms-win-core-synch-l1-2-0.dll";

        /// <summary>
        /// The "api-ms-win-core-handle-l1-1-0.dll" constant.
        /// </summary>
        public const string api_ms_win_core_handle_l1_1_0 = "api-ms-win-core-handle-l1-1-0.dll";
    }
}
