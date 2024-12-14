using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D36 RID: 3382
	public static class PVEBattleResultScRspReflection
	{
		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x001925A8 File Offset: 0x001907A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return PVEBattleResultScRspReflection.descriptor;
			}
		}

		// Token: 0x04003AB3 RID: 15027
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpQVkVCYXR0bGVSZXN1bHRTY1JzcC5wcm90bxoVQmF0dGxlRW5kU3RhdHVz",
			"LnByb3RvGhJCYXR0bGVBdmF0YXIucHJvdG8aDkl0ZW1MaXN0LnByb3RvIrED",
			"ChRQVkVCYXR0bGVSZXN1bHRTY1JzcBIQCghzdGFnZV9pZBgCIAEoDRIpChJi",
			"YXR0bGVfYXZhdGFyX2xpc3QYByADKAsyDS5CYXR0bGVBdmF0YXISEwoLT0JH",
			"QkhQS0xQSkgYCyABKA0SGwoTbWlzbWF0Y2hfdHVybl9jb3VudBgNIAEoDRIT",
			"CgtiaW5fdmVyc2lvbhgKIAEoCRIXCg9jaGVja19pZGVudGljYWwYBCABKAgS",
			"JQoSbXVsdGlwbGVfZHJvcF9kYXRhGAwgASgLMgkuSXRlbUxpc3QSEwoLcmVz",
			"X3ZlcnNpb24YBiABKAkSEwoLUExCQ0RERk1GSU8YBSABKA0SFwoEdW5rMRgB",
			"IAEoCzIJLkl0ZW1MaXN0EhgKBHVuazIY+QggASgLMgkuSXRlbUxpc3QSEQoJ",
			"YmF0dGxlX2lkGAMgASgNEhAKCGV2ZW50X2lkGAggASgNEhwKCWRyb3BfZGF0",
			"YRgJIAEoCzIJLkl0ZW1MaXN0EiQKCmVuZF9zdGF0dXMYDyABKA4yEC5CYXR0",
			"bGVFbmRTdGF0dXMSDwoHcmV0Y29kZRgOIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			BattleEndStatusReflection.Descriptor,
			BattleAvatarReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PVEBattleResultScRsp), PVEBattleResultScRsp.Parser, new string[]
			{
				"StageId",
				"BattleAvatarList",
				"OBGBHPKLPJH",
				"MismatchTurnCount",
				"BinVersion",
				"CheckIdentical",
				"MultipleDropData",
				"ResVersion",
				"PLBCDDFMFIO",
				"Unk1",
				"Unk2",
				"BattleId",
				"EventId",
				"DropData",
				"EndStatus",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
