using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000050 RID: 80
	public static class AetherDivideBattleInfoReflection
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000A685 File Offset: 0x00008885
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherDivideBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x0400013D RID: 317
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxBZXRoZXJEaXZpZGVCYXR0bGVJbmZvLnByb3RvGhBCYXR0bGVCdWZmLnBy",
			"b3RvGhZBZXRoZXJBdmF0YXJJbmZvLnByb3RvGhZTY2VuZU1vbnN0ZXJXYXZl",
			"LnByb3RvIuoBChZBZXRoZXJEaXZpZGVCYXR0bGVJbmZvEhEKCWJhdHRsZV9p",
			"ZBgFIAEoDRIQCghzdGFnZV9pZBgOIAEoDRIZChFsb2dpY19yYW5kb21fc2Vl",
			"ZBgPIAEoDRIeCglidWZmX2xpc3QYBCADKAsyCy5CYXR0bGVCdWZmEi0KEmJh",
			"dHRsZV9hdmF0YXJfbGlzdBgMIAMoCzIRLkFldGhlckF2YXRhckluZm8SEwoL",
			"TEtBSExHTklFQ0YYCSABKAgSLAoRbW9uc3Rlcl93YXZlX2xpc3QYDSADKAsy",
			"ES5TY2VuZU1vbnN0ZXJXYXZlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			BattleBuffReflection.Descriptor,
			AetherAvatarInfoReflection.Descriptor,
			SceneMonsterWaveReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideBattleInfo), AetherDivideBattleInfo.Parser, new string[]
			{
				"BattleId",
				"StageId",
				"LogicRandomSeed",
				"BuffList",
				"BattleAvatarList",
				"LKAHLGNIECF",
				"MonsterWaveList"
			}, null, null, null, null)
		}));
	}
}
