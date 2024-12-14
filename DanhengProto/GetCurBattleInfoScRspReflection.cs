using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000670 RID: 1648
	public static class GetCurBattleInfoScRspReflection
	{
		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060049DE RID: 18910 RVA: 0x000C934E File Offset: 0x000C754E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetCurBattleInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D5D RID: 7517
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRDdXJCYXR0bGVJbmZvU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxlSW5m",
			"by5wcm90bxoVQmF0dGxlRW5kU3RhdHVzLnByb3RvGhxBZXRoZXJEaXZpZGVC",
			"YXR0bGVJbmZvLnByb3RvIr0BChVHZXRDdXJCYXR0bGVJbmZvU2NSc3ASLAoL",
			"Rk1MTUdPTUVJS00YCiABKAsyFy5BZXRoZXJEaXZpZGVCYXR0bGVJbmZvEikK",
			"D2xhc3RfZW5kX3N0YXR1cxgDIAEoDjIQLkJhdHRsZUVuZFN0YXR1cxIPCgdy",
			"ZXRjb2RlGAQgASgNEhMKC05CSENOTEdQSURPGAsgASgNEiUKC2JhdHRsZV9p",
			"bmZvGA4gASgLMhAuU2NlbmVCYXR0bGVJbmZvQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor,
			BattleEndStatusReflection.Descriptor,
			AetherDivideBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetCurBattleInfoScRsp), GetCurBattleInfoScRsp.Parser, new string[]
			{
				"FMLMGOMEIKM",
				"LastEndStatus",
				"Retcode",
				"NBHCNLGPIDO",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
