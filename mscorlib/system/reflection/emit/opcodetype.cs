// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*============================================================
**
**Class: OpCodeType
** 
** <OWNER>WESU</OWNER>
**
**Purpose: Exposes OpCodeType Attribute of IL .
**
** THIS FILE IS AUTOMATICALLY GENERATED. DO NOT EDIT BY HAND!
** See clr\src\inc\opcodegen.pl for more information.**
============================================================*/
namespace System.Reflection.Emit {

using System;

[Serializable]
[System.Runtime.InteropServices.ComVisible(true)]
public enum OpCodeType
{

#if !FEATURE_CORECLR
    /// <internalonly/>
    [Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
    Annotation  = 0,
#endif
    Macro       = 1,
    Nternal     = 2,
    Objmodel    = 3,
    Prefix      = 4,
    Primitive   = 5,
}
}
