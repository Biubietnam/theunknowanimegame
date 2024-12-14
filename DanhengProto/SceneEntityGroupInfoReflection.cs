using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001060 RID: 4192
	public static class SceneEntityGroupInfoReflection
	{
		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x001F5A17 File Offset: 0x001F3C17
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityGroupInfoReflection.descriptor;
			}
		}

		// Token: 0x04004BB1 RID: 19377
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpTY2VuZUVudGl0eUdyb3VwSW5mby5wcm90bxoVU2NlbmVFbnRpdHlJbmZv",
			"LnByb3RvIl4KFFNjZW5lRW50aXR5R3JvdXBJbmZvEg0KBXN0YXRlGAogASgN",
			"EiUKC2VudGl0eV9saXN0GAIgAygLMhAuU2NlbmVFbnRpdHlJbmZvEhAKCGdy",
			"b3VwX2lkGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SceneEntityInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityGroupInfo), SceneEntityGroupInfo.Parser, new string[]
			{
				"State",
				"EntityList",
				"GroupId"
			}, null, null, null, null)
		}));
	}
}
