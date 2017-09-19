using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DxLib {
    public static partial class DX {
        [DllImport("DxLibW.dll", EntryPoint = "dx_GetNowCount", CharSet = CharSet.Unicode)]
        extern static int dx_GetNowCount_x86([MarshalAs(UnmanagedType.Bool)]bool UseRDTSCFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_GetNowCount", CharSet = CharSet.Unicode)]
        extern static int dx_GetNowCount_x64([MarshalAs(UnmanagedType.Bool)]bool UseRDTSCFlag);
        public static int GetNowCount(bool UseRDTSCFlag = false) =>
            Environment.Is64BitProcess ? dx_GetNowCount_x64(UseRDTSCFlag) : dx_GetNowCount_x86(UseRDTSCFlag);

        [DllImport("DxLibW.dll", EntryPoint = "dx_GetNowHiPerformanceCount", CharSet = CharSet.Unicode)]
        extern static long dx_GetNowHiPerformanceCount_x86(int UseRDTSCFlag);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_GetNowHiPerformanceCount", CharSet = CharSet.Unicode)]
        extern static long dx_GetNowHiPerformanceCount_x64(int UseRDTSCFlag);
        public static long GetNowHiPerformanceCount() {
            if (System.IntPtr.Size == 4) {
                return dx_GetNowHiPerformanceCount_x86(FALSE);
            } else {
                return dx_GetNowHiPerformanceCount_x64(FALSE);
            }
        }
        public static long GetNowHiPerformanceCount(int UseRDTSCFlag) {
            if (System.IntPtr.Size == 4) {
                return dx_GetNowHiPerformanceCount_x86(UseRDTSCFlag);
            } else {
                return dx_GetNowHiPerformanceCount_x64(UseRDTSCFlag);
            }
        }

        [DllImport("DxLibW.dll", EntryPoint = "dx_GetDateTime", CharSet = CharSet.Unicode)]
        extern static int dx_GetDateTime_x86(out DATEDATA DateBuf);
        [DllImport("DxLibW_x64.dll", EntryPoint = "dx_GetDateTime", CharSet = CharSet.Unicode)]
        extern static int dx_GetDateTime_x64(out DATEDATA DateBuf);
        public static int GetDateTime(out DATEDATA DateBuf) {
            if (System.IntPtr.Size == 4) {
                return dx_GetDateTime_x86(out DateBuf);
            } else {
                return dx_GetDateTime_x64(out DateBuf);
            }
        }

    }
}
