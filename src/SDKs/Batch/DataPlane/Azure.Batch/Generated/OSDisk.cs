// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Settings for the operating system disk of the virtual machine.
    /// </summary>
    public partial class OSDisk : ITransportObjectProvider<Models.OSDisk>, IPropertyMetadata
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OSDisk"/> class.
        /// </summary>
        /// <param name='caching'>The type of caching to enable for the OS disk.</param>
        public OSDisk(
            Common.CachingType? caching = default(Common.CachingType?))
        {
            this.Caching = caching;
        }

        internal OSDisk(Models.OSDisk protocolObject)
        {
            this.Caching = UtilitiesInternal.MapNullableEnum<Models.CachingType, Common.CachingType>(protocolObject.Caching);
        }

        #endregion Constructors

        #region OSDisk

        /// <summary>
        /// Gets the type of caching to enable for the OS disk.
        /// </summary>
        public Common.CachingType? Caching { get; }

        #endregion // OSDisk

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.OSDisk ITransportObjectProvider<Models.OSDisk>.GetTransportObject()
        {
            Models.OSDisk result = new Models.OSDisk()
            {
                Caching = UtilitiesInternal.MapNullableEnum<Common.CachingType, Models.CachingType>(this.Caching),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}