using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F6 RID: 4598
	public static class SubmitEmotionItemCsReqReflection
	{
		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600CD8B RID: 52619 RVA: 0x00227AA0 File Offset: 0x00225CA0
		public static FileDescriptor Descriptor
		{
			get
			{
				return SubmitEmotionItemCsReqReflection.descriptor;
			}
		}

		// Token: 0x040052E2 RID: 21218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxTdWJtaXRFbW90aW9uSXRlbUNzUmVxLnByb3RvGg5JdGVtTGlzdC5wcm90",
			"byJeChZTdWJtaXRFbW90aW9uSXRlbUNzUmVxEhEKCXNjcmlwdF9pZBgNIAEo",
			"DRIcCglpdGVtX2xpc3QYBSABKAsyCS5JdGVtTGlzdBITCgtGUFBFRkJLQkZE",
			"RBgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SubmitEmotionItemCsReq), SubmitEmotionItemCsReq.Parser, new string[]
			{
				"ScriptId",
				"ItemList",
				"FPPEFBKBFDD"
			}, null, null, null, null)
		}));
	}
}
