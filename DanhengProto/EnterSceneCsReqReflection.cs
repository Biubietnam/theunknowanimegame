using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000460 RID: 1120
	public static class EnterSceneCsReqReflection
	{
		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x00089786 File Offset: 0x00087986
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterSceneCsReqReflection.descriptor;
			}
		}

		// Token: 0x040013E1 RID: 5089
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVFbnRlclNjZW5lQ3NSZXEucHJvdG8ifgoPRW50ZXJTY2VuZUNzUmVxEhoK",
			"EmdhbWVfc3RvcnlfbGluZV9pZBgBIAEoDRIUCgxpc19jbG9zZV9tYXAYAiAB",
			"KAgSEwoLdGVsZXBvcnRfaWQYDSABKA0SEAoIZW50cnlfaWQYDiABKA0SEgoK",
			"Y29udGVudF9pZBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterSceneCsReq), EnterSceneCsReq.Parser, new string[]
			{
				"GameStoryLineId",
				"IsCloseMap",
				"TeleportId",
				"EntryId",
				"ContentId"
			}, null, null, null, null)
		}));
	}
}
