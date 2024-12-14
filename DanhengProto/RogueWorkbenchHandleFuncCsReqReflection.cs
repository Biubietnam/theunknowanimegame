using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001036 RID: 4150
	public static class RogueWorkbenchHandleFuncCsReqReflection
	{
		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600B899 RID: 47257 RVA: 0x001EF939 File Offset: 0x001EDB39
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueWorkbenchHandleFuncCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004ACD RID: 19149
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZVdvcmtiZW5jaEhhbmRsZUZ1bmNDc1JlcS5wcm90bxofUm9ndWVX",
			"b3JrYmVuY2hDb250ZW50SW5mby5wcm90byKJAQodUm9ndWVXb3JrYmVuY2hI",
			"YW5kbGVGdW5jQ3NSZXESFgoOcHJvcF9lbnRpdHlfaWQYBSABKA0SGQoRd29y",
			"a2JlbmNoX2Z1bmNfaWQYBCABKA0SNQoRd29ya2JlbmNoX2NvbnRlbnQYCiAB",
			"KAsyGi5Sb2d1ZVdvcmtiZW5jaENvbnRlbnRJbmZvQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueWorkbenchContentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchHandleFuncCsReq), RogueWorkbenchHandleFuncCsReq.Parser, new string[]
			{
				"PropEntityId",
				"WorkbenchFuncId",
				"WorkbenchContent"
			}, null, null, null, null)
		}));
	}
}
