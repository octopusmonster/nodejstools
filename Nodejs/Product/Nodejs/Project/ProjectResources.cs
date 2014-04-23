﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Resources;
using System.Threading;
using CommonSR = Microsoft.VisualStudioTools.Project.SR;

namespace Microsoft.NodejsTools.Project {
    internal class SR : CommonSR {
        internal const string NodejsToolsForVisualStudio = "NodejsToolsForVisualStudio";

        internal const string CatalogLoadingDefault = "CatalogLoadingDefault";
        internal const string CatalogLoadingNoNpm = "CatalogLoadingNoNpm";
        internal const string CategoryStatus = "CategoryStatus";
        internal const string CategoryVersion = "CategoryVersion";
        internal const string DebuggerConnectionClosed = "DebuggerConnectionClosed";
        internal const string DebuggerModuleUpdateFailed = "DebuggerModuleUpdateFailed";
        internal const string DebuggerPort = "DebuggerPort";
        internal const string EnvironmentVariables = "EnvironmentVariables";
        internal const string InvalidPortNumber = "InvalidPortNumber";
        internal const string LaunchUrlToolTip = "LaunchUrlToolTip";
        internal const string LinkStatusLinkedFromGlobal = "LinkStatusLinkedFromGlobal";
        internal const string LinkStatusLinkedToProject = "LinkStatusLinkedToProject";
        internal const string LinkStatusLocallyInstalled = "LinkStatusLocallyInstalled";
        internal const string LinkStatusNotApplicableSubPackages = "LinkStatusNotApplicableSubPackages";
        internal const string LinkStatusNotLinkedToProject = "LinkStatusNotLinkedToProject";
        internal const string LinkStatusUnknown = "LinkStatusUnknown";
        internal const string NewVersionNo = "NewVersionNo";
        internal const string NewVersionNotApplicableSubpackage = "NewVersionNotApplicableSubpackage";
        internal const string NewVersionPackageCatalogNotRetrieved = "NewVersionPackageCatalogNotRetrieved";
        internal const string NewVersionUnknown = "NewVersionUnknown";
        internal const string NewVersionYes = "NewVersionYes";
        internal const string NodeExeArguments = "NodeExeArguments";
        internal const string NodeExeArgumentsDescription = "NodeExeArgumentsDescription";
        internal const string NodeExeArgumentsToolTip = "NodeExeArgumentsToolTip";
        internal const string NodeExeDoesntExist = "NodeExeDoesntExist";
        internal const string NodeExePath = "NodeExePath";
        internal const string NodeExePathDescription = "NodeExePathDescription";
        internal const string NodeExePathNotFound = "NodeExePathNotFound";
        internal const string NodeExePathToolTip = "NodeExePathToolTip";
        internal const string NodejsNotInstalled = "NodejsNotInstalled";
        internal const string NodejsNotInstalledShort = "NodejsNotInstalledShort";
        internal const string NodejsNotSupported = "NodejsNotSupported";
        internal const string NodejsPort = "NodejsPort";
        internal const string NodejsPortDescription = "NodejsPortDescription";
        internal const string NodejsPortToolTip = "NodejsPortToolTip";
        internal const string NoKeywordsInPackage = "NoKeywordsInPackage";
        internal const string NpmCancelled = "NpmCancelled";
        internal const string NpmCancelledWithErrors = "NpmCancelledWithErrors";
        internal const string NpmCompletedWithErrors = "NpmCompletedWithErrors";
        internal const string NpmNodePackageInstallation = "NpmNodePackageInstallation";
        internal const string NpmNodePackageInstallationDescription = "NpmNodePackageInstallationDescription";
        internal const string NpmNodePath = "NpmNodePath";
        internal const string NpmNodePathDescription = "NpmNodePathDescription";
        internal const string NpmOutputPaneTitle = "NpmOutputPaneTitle";
        internal const string NpmPackageAuthor = "NpmPackageAuthor";
        internal const string NpmPackageAuthorDescription = "NpmPackageAuthorDescription";
        internal const string NpmPackageDescription = "NpmPackageDescription";
        internal const string NpmPackageDescriptionDescription = "NpmPackageDescriptionDescription";
        internal const string NpmPackageIsBundledDependency = "NpmPackageIsBundledDependency";
        internal const string NpmPackageIsBundledDependencyDescription = "NpmPackageIsBundledDependencyDescription";
        internal const string NpmPackageIsDevDependency = "NpmPackageIsDevDependency";
        internal const string NpmPackageIsDevDependencyDescription = "NpmPackageIsDevDependencyDescription";
        internal const string NpmPackageIsListedInParentPackageJson = "NpmPackageIsListedInParentPackageJson";
        internal const string NpmPackageIsListedInParentPackageJsonDescription = "NpmPackageIsListedInParentPackageJsonDescription";
        internal const string NpmPackageIsMissing = "NpmPackageIsMissing";
        internal const string NpmPackageIsMissingDescription = "NpmPackageIsMissingDescription";
        internal const string NpmPackageIsOptionalDependency = "NpmPackageIsOptionalDependency";
        internal const string NpmPackageIsOptionalDependencyDescription = "NpmPackageIsOptionalDependencyDescription";
        internal const string NpmPackageKeywords = "NpmPackageKeywords";
        internal const string NpmPackageKeywordsDescription = "NpmPackageKeywordsDescription";
        internal const string NpmPackageLinkStatus = "NpmPackageLinkStatus";
        internal const string NpmPackageLinkStatusDescription = "NpmPackageLinkStatusDescription";
        internal const string NpmPackageName = "NpmPackageName";
        internal const string NpmPackageNameDescription = "NpmPackageNameDescription";
        internal const string NpmPackageNewVersionAvailable = "NpmPackageNewVersionAvailable";
        internal const string NpmPackageNewVersionAvailableDescription = "NpmPackageNewVersionAvailableDescription";
        internal const string NpmPackagePath = "NpmPackagePath";
        internal const string NpmPackagePathDescription = "NpmPackagePathDescription";
        internal const string NpmPackageRequestedVersionRange = "NpmPackageRequestedVersionRange";
        internal const string NpmPackageRequestedVersionRangeDescription = "NpmPackageRequestedVersionRangeDescription";
        internal const string NpmPackageType = "NpmPackageType";
        internal const string NpmPackageTypeDescription = "NpmPackageTypeDescription";
        internal const string NpmPackageVersion = "NpmPackageVersion";
        internal const string NpmPackageVersionDescription = "NpmPackageVersionDescription";
        internal const string NpmStatusExecuting = "NpmStatusExecuting";
        internal const string NpmStatusExecutingErrors = "NpmStatusExecutingErrors";
        internal const string NpmStatusExecutingQueued = "NpmStatusExecutingQueued";
        internal const string NpmStatusExecutingQueuedErrors = "NpmStatusExecutingQueuedErrors";
        internal const string NpmStatusReady = "NpmStatusReady";
        internal const string NpmStatusReadyWithErrors = "NpmStatusReadyWithErrors";
        internal const string NpmSuccessfullyCompleted = "NpmSuccessfullyCompleted";
        internal const string PackageCatalogRefresh0Days = "PackageCatalogRefresh0Days";
        internal const string PackageCatalogRefresh1Day = "PackageCatalogRefresh1Day";
        internal const string PackageCatalogRefresh1Month = "PackageCatalogRefresh1Month";
        internal const string PackageCatalogRefresh1Week = "PackageCatalogRefresh1Week";
        internal const string PackageCatalogRefresh2To7Days = "PackageCatalogRefresh2To7Days";
        internal const string PackageCatalogRefresh2Weeks = "PackageCatalogRefresh2Weeks";
        internal const string PackageCatalogRefresh3Months = "PackageCatalogRefresh3Months";
        internal const string PackageCatalogRefresh3Weeks = "PackageCatalogRefresh3Weeks";
        internal const string PackageCatalogRefresh6Months = "PackageCatalogRefresh6Months";
        internal const string PackageCatalogRefreshFailed = "PackageCatalogRefreshFailed";
        internal const string PackageCatalogRefreshing = "PackageCatalogRefreshing";
        internal const string PackageCatalogRefreshNever = "PackageCatalogRefreshNever";
        internal const string PackageCount = "PackageCount";
        internal const string PackageInstallationGlobal = "PackageInstallationGlobal";
        internal const string PackageInstallationLocal = "PackageInstallationLocal";
        internal const string PackageInstalledGlobally = "PackageInstalledGlobally";
        internal const string PackageInstalledGloballyOldVersion = "PackageInstalledGloballyOldVersion";
        internal const string PackageInstalledLocally = "PackageInstalledLocally";
        internal const string PackageInstalledLocallyOldVersion = "PackageInstalledLocallyOldVersion";
        internal const string PackageMatchCount = "PackageMatchCount";
        internal const string PackageTypeGlobal = "PackageTypeGlobal";
        internal const string PackageTypeGlobalSubpackage = "PackageTypeGlobalSubpackage";
        internal const string PackageTypeLocal = "PackageTypeLocal";
        internal const string PackageTypeLocalSubpackage = "PackageTypeLocalSubpackage";
        internal const string PropertiesClassGlobal = "PropertiesClassGlobal";
        internal const string PropertiesClassGlobalPackage = "PropertiesClassGlobalPackage";
        internal const string PropertiesClassGlobalSubPackage = "PropertiesClassGlobalSubPackage";
        internal const string PropertiesClassLocalPackage = "PropertiesClassLocalPackage";
        internal const string PropertiesClassLocalSubPackage = "PropertiesClassLocalSubPackage";
        internal const string PropertiesClassNpm = "PropertiesClassNpm";
        internal const string ReplInitializationMessage = "ReplInitializationMessage";
        internal const string RequestedVersionRangeNone = "RequestedVersionRangeNone";
        internal const string ScriptArgumentsToolTip = "ScriptArgumentsToolTip";
        internal const string StartBrowserToolTip = "StartBrowserToolTip";
        internal const string TestFramework = "TestFramework";
        internal const string TestFrameworkDescription = "TestFrameworkDescription";
        internal const string WorkingDirInvalidOrMissing = "WorkingDirInvalidOrMissing";
        internal const string WorkingDirToolTip = "WorkingDirToolTip";

        private static readonly Lazy<ResourceManager> _manager = new Lazy<ResourceManager>(
            () => new System.Resources.ResourceManager("Microsoft.NodejsTools.Resources", typeof(SR).Assembly),
            LazyThreadSafetyMode.ExecutionAndPublication
        );

        private static ResourceManager Manager {
            get {
                return _manager.Value;
            }
        }

        internal static new string GetString(string value, params object[] args) {
            return GetStringInternal(Manager, value, args) ?? CommonSR.GetString(value, args);
        }

        internal static string ProductName {
            get {
                return GetString(NodejsToolsForVisualStudio);
            }
        }
    }
}