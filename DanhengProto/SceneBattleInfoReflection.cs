using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200104E RID: 4174
	public static class SceneBattleInfoReflection
	{
		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600B9BB RID: 47547 RVA: 0x001F2832 File Offset: 0x001F0A32
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x04004B33 RID: 19251
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVTY2VuZUJhdHRsZUluZm8ucHJvdG8aEU5QRFBMRU1HRUZOLnByb3RvGhZT",
			"Y2VuZU1vbnN0ZXJXYXZlLnByb3RvGhFHREhFRE5LSUVMRS5wcm90bxoQQmF0",
			"dGxlQnVmZi5wcm90bxoWQmF0dGxlVGFyZ2V0TGlzdC5wcm90bxobQmF0dGxl",
			"RXZlbnRCYXR0bGVJbmZvLnByb3RvGhJCYXR0bGVBdmF0YXIucHJvdG8aGkJh",
			"dHRsZVJvZ3VlTWFnaWNJbmZvLnByb3RvGhtFdm9sdmVCdWlsZEJhdHRsZUlu",
			"Zm8ucHJvdG8ijgUKD1NjZW5lQmF0dGxlSW5mbxItCgxiYXR0bGVfZXZlbnQY",
			"ygogAygLMhYuQmF0dGxlRXZlbnRCYXR0bGVJbmZvEikKEmJhdHRsZV9hdmF0",
			"YXJfbGlzdBgGIAMoCzINLkJhdHRsZUF2YXRhchITCgtMS0FITEdOSUVDRhgN",
			"IAEoCBIZChFsb2dpY19yYW5kb21fc2VlZBgOIAEoDRITCgt3b3JsZF9sZXZl",
			"bBgMIAEoDRIsCgtPQUhET0xIQlBGSxjlBiABKAsyFi5Fdm9sdmVCdWlsZEJh",
			"dHRsZUluZm8SLAoRbW9uc3Rlcl93YXZlX2xpc3QYByADKAsyES5TY2VuZU1v",
			"bnN0ZXJXYXZlEh4KCWJ1ZmZfbGlzdBgJIAMoCzILLkJhdHRsZUJ1ZmYSEQoJ",
			"YmF0dGxlX2lkGA8gASgNEhQKDHJvdW5kc19saW1pdBgFIAEoDRIiCgtHSU9H",
			"S0dMQkFDQRiMCyABKAsyDC5OUERQTEVNR0VGThIQCghzdGFnZV9pZBgIIAEo",
			"DRI3ChdiYXR0bGVfcm9ndWVfbWFnaWNfaW5mbxjOASABKAsyFS5CYXR0bGVS",
			"b2d1ZU1hZ2ljSW5mbxIiCgtDR09CTE5MR0NNTxjtCyABKAsyDC5HREhFRE5L",
			"SUVMRRJDChJiYXR0bGVfdGFyZ2V0X2luZm8YgQEgAygLMiYuU2NlbmVCYXR0",
			"bGVJbmZvLkJhdHRsZVRhcmdldEluZm9FbnRyeRITCgtBRkhLTkNIRk5MRRgB",
			"IAEoDRpKChVCYXR0bGVUYXJnZXRJbmZvRW50cnkSCwoDa2V5GAEgASgNEiAK",
			"BXZhbHVlGAIgASgLMhEuQmF0dGxlVGFyZ2V0TGlzdDoCOAFCHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			NPDPLEMGEFNReflection.Descriptor,
			SceneMonsterWaveReflection.Descriptor,
			GDHEDNKIELEReflection.Descriptor,
			BattleBuffReflection.Descriptor,
			BattleTargetListReflection.Descriptor,
			BattleEventBattleInfoReflection.Descriptor,
			BattleAvatarReflection.Descriptor,
			BattleRogueMagicInfoReflection.Descriptor,
			EvolveBuildBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneBattleInfo), SceneBattleInfo.Parser, new string[]
			{
				"BattleEvent",
				"BattleAvatarList",
				"LKAHLGNIECF",
				"LogicRandomSeed",
				"WorldLevel",
				"OAHDOLHBPFK",
				"MonsterWaveList",
				"BuffList",
				"BattleId",
				"RoundsLimit",
				"GIOGKGLBACA",
				"StageId",
				"BattleRogueMagicInfo",
				"CGOBLNLGCMO",
				"BattleTargetInfo",
				"AFHKNCHFNLE"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
