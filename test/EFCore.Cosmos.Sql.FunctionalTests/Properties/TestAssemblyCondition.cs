﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Cosmos.Sql.TestUtilities;

// Skip the entire assembly if cannot connect to CosmosDb
[assembly: CosmosDbConfiguredCondition]
