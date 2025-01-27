#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Boolean UnityEngine.XR.XRSettings::get_enabled()
extern void XRSettings_get_enabled_m5ECD63DA0B306F7A3FBFD6B67A5B0702F8AEFB54 (void);
// 0x00000002 System.String UnityEngine.XR.XRSettings::get_loadedDeviceName()
extern void XRSettings_get_loadedDeviceName_m0EC0BC3BFBF1483DBC766D882A54677F2DBFC4BA (void);
// 0x00000003 System.String[] UnityEngine.XR.XRSettings::get_supportedDevices()
extern void XRSettings_get_supportedDevices_mEF86DEEEEBBE9CABC4372C707C0A3D6D958E9FAF (void);
// 0x00000004 UnityEngine.XR.XRSettings/StereoRenderingMode UnityEngine.XR.XRSettings::get_stereoRenderingMode()
extern void XRSettings_get_stereoRenderingMode_mB194A58846A080153AC66A75F422600EE1BF1C8C (void);
// 0x00000005 System.Void UnityEngine.XR.XRDevice::DisableAutoXRCameraTracking(UnityEngine.Camera,System.Boolean)
extern void XRDevice_DisableAutoXRCameraTracking_mDFDDD1D32A4D623A5448533B5E8E02B9536A25DC (void);
// 0x00000006 System.Void UnityEngine.XR.XRDevice::InvokeDeviceLoaded(System.String)
extern void XRDevice_InvokeDeviceLoaded_m07DEE6645B38728C7B8615DAAD6BE592C1DC59F9 (void);
static Il2CppMethodPointer s_methodPointers[6] = 
{
	XRSettings_get_enabled_m5ECD63DA0B306F7A3FBFD6B67A5B0702F8AEFB54,
	XRSettings_get_loadedDeviceName_m0EC0BC3BFBF1483DBC766D882A54677F2DBFC4BA,
	XRSettings_get_supportedDevices_mEF86DEEEEBBE9CABC4372C707C0A3D6D958E9FAF,
	XRSettings_get_stereoRenderingMode_mB194A58846A080153AC66A75F422600EE1BF1C8C,
	XRDevice_DisableAutoXRCameraTracking_mDFDDD1D32A4D623A5448533B5E8E02B9536A25DC,
	XRDevice_InvokeDeviceLoaded_m07DEE6645B38728C7B8615DAAD6BE592C1DC59F9,
};
static const int32_t s_InvokerIndices[6] = 
{
	7033,
	7010,
	7010,
	7001,
	6466,
	6883,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_VRModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_VRModule_CodeGenModule = 
{
	"UnityEngine.VRModule.dll",
	6,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
