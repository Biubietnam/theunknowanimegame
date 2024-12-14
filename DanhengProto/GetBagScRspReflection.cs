using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200062C RID: 1580
	public static class GetBagScRspReflection
	{
		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x000C1DF6 File Offset: 0x000BFFF6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetBagScRspReflection.descriptor;
			}
		}

		// Token: 0x04001C4C RID: 7244
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFHZXRCYWdTY1JzcC5wcm90bxoVV2FpdERlbFJlc291cmNlLnByb3RvGhRU",
			"dXJuRm9vZFN3aXRjaC5wcm90bxoLUmVsaWMucHJvdG8aD0VxdWlwbWVudC5w",
			"cm90bxoOTWF0ZXJpYWwucHJvdG8aDlBpbGVJdGVtLnByb3RvGg9NYXRlcmlh",
			"bDAucHJvdG8iuQMKC0dldEJhZ1NjUnNwEh8KC05HRU5PQkZGTEFCGAMgAygL",
			"MgouTWF0ZXJpYWwwEh8KC0hOQkhMQ0FLQUpHGAQgAygLMgouTWF0ZXJpYWww",
			"EiIKDmVxdWlwbWVudF9saXN0GA8gAygLMgouRXF1aXBtZW50EhMKC1BOQlBE",
			"T0dFS0dCGAUgAygNEhMKC0RIREpJSU9JUEtIGA0gAygNEh4KC0ZBTU5DSkZC",
			"QUZGGAYgAygLMgkuTWF0ZXJpYWwSEwoLQ0dGTEVLQ05KS0QYDiABKA0SJAoL",
			"SUJMUEhPUE9FT0sYCyADKA4yDy5UdXJuRm9vZFN3aXRjaBIgCg1tYXRlcmlh",
			"bF9saXN0GAcgAygLMgkuTWF0ZXJpYWwSGgoKcmVsaWNfbGlzdBgKIAMoCzIG",
			"LlJlbGljEg8KB3JldGNvZGUYCSABKA0SIQoOcGlsZV9pdGVtX2xpc3QYDCAD",
			"KAsyCS5QaWxlSXRlbRIwChZ3YWl0X2RlbF9yZXNvdXJjZV9saXN0GAggAygL",
			"MhAuV2FpdERlbFJlc291cmNlEhsKE3VubG9ja19mb3JtdWxhX2xpc3QYAiAD",
			"KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WaitDelResourceReflection.Descriptor,
			TurnFoodSwitchReflection.Descriptor,
			RelicReflection.Descriptor,
			EquipmentReflection.Descriptor,
			MaterialReflection.Descriptor,
			PileItemReflection.Descriptor,
			Material0Reflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetBagScRsp), GetBagScRsp.Parser, new string[]
			{
				"NGENOBFFLAB",
				"HNBHLCAKAJG",
				"EquipmentList",
				"PNBPDOGEKGB",
				"DHDJIIOIPKH",
				"FAMNCJFBAFF",
				"CGFLEKCNJKD",
				"IBLPHOPOEOK",
				"MaterialList",
				"RelicList",
				"Retcode",
				"PileItemList",
				"WaitDelResourceList",
				"UnlockFormulaList"
			}, null, null, null, null)
		}));
	}
}
