using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E6A RID: 3690
	public static class RogueCurrentInfoReflection
	{
		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600A498 RID: 42136 RVA: 0x001BA362 File Offset: 0x001B8562
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCurrentInfoReflection.descriptor;
			}
		}

		// Token: 0x0400433D RID: 17213
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZSb2d1ZUN1cnJlbnRJbmZvLnByb3RvGhJHYW1lQWVvbkluZm8ucHJvdG8a",
			"FVJvZ3VlTW9kdWxlSW5mby5wcm90bxoVUm9ndWVMaW5ldXBJbmZvLnByb3Rv",
			"Gh5Sb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb24ucHJvdG8aE1JvZ3VlQnVmZklu",
			"Zm8ucHJvdG8aEVJvZ3VlU3RhdHVzLnByb3RvGhVHYW1lTWlyYWNsZUluZm8u",
			"cHJvdG8aFlJvZ3VlVmlydHVhbEl0ZW0ucHJvdG8aElJvZ3VlTWFwSW5mby5w",
			"cm90byKcAwoQUm9ndWVDdXJyZW50SW5mbxIrChFnYW1lX21pcmFjbGVfaW5m",
			"bxgOIAEoCzIQLkdhbWVNaXJhY2xlSW5mbxIrChFyb2d1ZV9saW5ldXBfaW5m",
			"bxgHIAEoCzIQLlJvZ3VlTGluZXVwSW5mbxImCg9yb2d1ZV9hZW9uX2luZm8Y",
			"CyABKAsyDS5HYW1lQWVvbkluZm8SMQoOcGVuZGluZ19hY3Rpb24YBCABKAsy",
			"GS5Sb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb24SJwoPcm9ndWVfYnVmZl9pbmZv",
			"GAkgASgLMg4uUm9ndWVCdWZmSW5mbxIWCg5pc19leHBsb3JlX3dpbhgBIAEo",
			"CBIsChF2aXJ0dWFsX2l0ZW1faW5mbxgFIAEoCzIRLlJvZ3VlVmlydHVhbEl0",
			"ZW0SJQoLbW9kdWxlX2luZm8YDSABKAsyEC5Sb2d1ZU1vZHVsZUluZm8SHwoI",
			"cm9vbV9tYXAYBiABKAsyDS5Sb2d1ZU1hcEluZm8SHAoGc3RhdHVzGAwgASgO",
			"MgwuUm9ndWVTdGF0dXNCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			GameAeonInfoReflection.Descriptor,
			RogueModuleInfoReflection.Descriptor,
			RogueLineupInfoReflection.Descriptor,
			RogueCommonPendingActionReflection.Descriptor,
			RogueBuffInfoReflection.Descriptor,
			RogueStatusReflection.Descriptor,
			GameMiracleInfoReflection.Descriptor,
			RogueVirtualItemReflection.Descriptor,
			RogueMapInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCurrentInfo), RogueCurrentInfo.Parser, new string[]
			{
				"GameMiracleInfo",
				"RogueLineupInfo",
				"RogueAeonInfo",
				"PendingAction",
				"RogueBuffInfo",
				"IsExploreWin",
				"VirtualItemInfo",
				"ModuleInfo",
				"RoomMap",
				"Status"
			}, null, null, null, null)
		}));
	}
}
