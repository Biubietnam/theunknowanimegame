using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001F0 RID: 496
	public static class ChessRogueCellUpdateNotifyReflection
	{
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0003FD2F File Offset: 0x0003DF2F
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueCellUpdateNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000967 RID: 2407
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBDaGVzc1JvZ3VlQ2VsbFVwZGF0ZU5vdGlmeS5wcm90bxoUQ2hlc3NSb2d1",
			"ZUNlbGwucHJvdG8aHVJvZ3VlTW9kaWZpZXJTb3VyY2VUeXBlLnByb3RvGiBD",
			"aGVzc1JvZ3VlQ2VsbFVwZGF0ZVJlYXNvbi5wcm90byKyAQoaQ2hlc3NSb2d1",
			"ZUNlbGxVcGRhdGVOb3RpZnkSIgoJY2VsbF9saXN0GA8gAygLMg8uQ2hlc3NS",
			"b2d1ZUNlbGwSKwoGcmVhc29uGAQgASgOMhsuQ2hlc3NSb2d1ZUNlbGxVcGRh",
			"dGVSZWFzb24SMQoPbW9kaWZpZXJfc291cmNlGA4gASgOMhguUm9ndWVNb2Rp",
			"ZmllclNvdXJjZVR5cGUSEAoIYm9hcmRfaWQYAiABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueCellReflection.Descriptor,
			RogueModifierSourceTypeReflection.Descriptor,
			ChessRogueCellUpdateReasonReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCellUpdateNotify), ChessRogueCellUpdateNotify.Parser, new string[]
			{
				"CellList",
				"Reason",
				"ModifierSource",
				"BoardId"
			}, null, null, null, null)
		}));
	}
}
