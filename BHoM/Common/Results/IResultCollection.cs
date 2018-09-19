﻿using BH.oM.Base;

namespace BH.oM.Common
{
    public interface IResultCollection : IObject, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        string ObjectId { get;  }
        
        /***************************************************/
    }
}