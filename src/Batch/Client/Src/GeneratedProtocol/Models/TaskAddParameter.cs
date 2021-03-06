// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An Azure Batch task to add.
    /// </summary>
    public partial class TaskAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddParameter class.
        /// </summary>
        public TaskAddParameter() { }

        /// <summary>
        /// Initializes a new instance of the TaskAddParameter class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the task within
        /// the job.</param>
        /// <param name="commandLine">The command line of the task. For
        /// multi-instance tasks, the command line is executed on the primary
        /// subtask after all the subtasks have finished executing the
        /// coordianation command line.</param>
        /// <param name="displayName">A display name for the task.</param>
        /// <param name="exitConditions">How the Batch service should respond
        /// when the task completes.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the task.</param>
        /// <param name="affinityInfo">A locality hint that can be used by the
        /// Batch service to select a compute node on which to start the new
        /// task.</param>
        /// <param name="constraints">The execution constraints that apply to
        /// this task.</param>
        /// <param name="runElevated">Whether to run the task in elevated
        /// mode.</param>
        /// <param name="multiInstanceSettings">Information about how to run
        /// the multi-instance task.</param>
        /// <param name="dependsOn">Any other tasks that this task depends
        /// on.</param>
        /// <param name="applicationPackageReferences">A list of application
        /// packages that the Batch service will deploy to the compute node
        /// before running the command line.</param>
        public TaskAddParameter(string id, string commandLine, string displayName = default(string), ExitConditions exitConditions = default(ExitConditions), System.Collections.Generic.IList<ResourceFile> resourceFiles = default(System.Collections.Generic.IList<ResourceFile>), System.Collections.Generic.IList<EnvironmentSetting> environmentSettings = default(System.Collections.Generic.IList<EnvironmentSetting>), AffinityInformation affinityInfo = default(AffinityInformation), TaskConstraints constraints = default(TaskConstraints), bool? runElevated = default(bool?), MultiInstanceSettings multiInstanceSettings = default(MultiInstanceSettings), TaskDependencies dependsOn = default(TaskDependencies), System.Collections.Generic.IList<ApplicationPackageReference> applicationPackageReferences = default(System.Collections.Generic.IList<ApplicationPackageReference>))
        {
            Id = id;
            DisplayName = displayName;
            CommandLine = commandLine;
            ExitConditions = exitConditions;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            AffinityInfo = affinityInfo;
            Constraints = constraints;
            RunElevated = runElevated;
            MultiInstanceSettings = multiInstanceSettings;
            DependsOn = dependsOn;
            ApplicationPackageReferences = applicationPackageReferences;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the task within the
        /// job.
        /// </summary>
        /// <remarks>
        /// The id can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than
        /// 64 characters. It is common to use a GUID for the id.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a display name for the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the command line of the task. For multi-instance
        /// tasks, the command line is executed on the primary subtask after
        /// all the subtasks have finished executing the coordianation
        /// command line.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot
        /// take advantage of shell features such as environment variable
        /// expansion. If you want to take advantage of such features, you
        /// should invoke the shell in the command line, for example using
        /// "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond when the task
        /// completes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitConditions")]
        public ExitConditions ExitConditions { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the resource files will only be
        /// downloaded to the compute node on which the primary subtask is
        /// executed.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceFiles")]
        public System.Collections.Generic.IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "environmentSettings")]
        public System.Collections.Generic.IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service
        /// to select a compute node on which to start the new task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affinityInfo")]
        public AffinityInformation AffinityInfo { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether to run the task in elevated mode.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// Gets or sets information about how to run the multi-instance task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiInstanceSettings")]
        public MultiInstanceSettings MultiInstanceSettings { get; set; }

        /// <summary>
        /// Gets or sets any other tasks that this task depends on.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dependsOn")]
        public TaskDependencies DependsOn { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service
        /// will deploy to the compute node before running the command line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationPackageReferences")]
        public System.Collections.Generic.IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }
            if (CommandLine == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "CommandLine");
            }
            if (this.ResourceFiles != null)
            {
                foreach (var element in this.ResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.EnvironmentSettings != null)
            {
                foreach (var element1 in this.EnvironmentSettings)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.AffinityInfo != null)
            {
                this.AffinityInfo.Validate();
            }
            if (this.MultiInstanceSettings != null)
            {
                this.MultiInstanceSettings.Validate();
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element2 in this.ApplicationPackageReferences)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
