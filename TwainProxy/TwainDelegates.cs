﻿////////////////////////////////////////////////////////////////////////
//
// This file is part of pdn-twainable-plus, an Effect plugin for
// Paint.NET that imports images from TWAIN devices.
//
// Copyright (c) 2014, 2017, 2018 Nicholas Hayes
//
// This file is licensed under the MIT License.
// See LICENSE.txt for complete licensing and attribution information.
//
////////////////////////////////////////////////////////////////////////

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TwainProxy
{
    internal static class TwainDelegates
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwainEvent(ref TwainStructs.Identity appId, ref TwainStructs.Identity deviceId, DataGroup group, ushort argType, ushort msg, ref TwainStructs.Event item);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwianParent(ref TwainStructs.Identity appId, IntPtr deviceId, DataGroup group, ushort argType, ushort msg, ref IntPtr parentHWnd);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwainIdentity(ref TwainStructs.Identity appId, IntPtr deviceId, DataGroup group, ushort argType, ushort msg, ref TwainStructs.Identity currentDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwainUI(ref TwainStructs.Identity appId, ref TwainStructs.Identity deviceId, DataGroup group, ushort argType, ushort msg, ref TwainStructs.UserInterface item);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwainCapability(ref TwainStructs.Identity appId, ref TwainStructs.Identity deviceId, DataGroup group, ushort argType, ushort msg, ref TwainStructs.Capability item);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwianNativeTransfer(ref TwainStructs.Identity appId, ref TwainStructs.Identity deviceId, DataGroup group, ushort argType, ushort msg, ref IntPtr hDib);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwianPendingXfer(ref TwainStructs.Identity appId, ref TwainStructs.Identity deviceId, DataGroup group, ushort argType, ushort msg, ref TwainStructs.PendingXfers item);

        [UnmanagedFunctionPointer(CallingConvention.StdCall), SuppressUnmanagedCodeSecurity]
        internal delegate ResultCode TwainStatus(ref TwainStructs.Identity appId, IntPtr deviceId, DataGroup group, ushort argType, ushort msg, ref TwainStructs.Status status);
    }
}
