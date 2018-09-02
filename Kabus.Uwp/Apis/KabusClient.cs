// <copyright file="KabusClient.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2018 PlanGrid, Inc. All rights reserved.
// </copyright>

using SexyHttp;

namespace Kabus.Uwp.Apis
{
    public class KabusClient
    {
        public static IKabusApi Create()
        {
            return HttpApiClient<IKabusApi>.Create("");
        }
    }
}