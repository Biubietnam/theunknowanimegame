using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000878 RID: 2168
	public static class GroupRefreshInfoReflection
	{
		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x000FEF1F File Offset: 0x000FD11F
		public static FileDescriptor Descriptor
		{
			get
			{
				return GroupRefreshInfoReflection.descriptor;
			}
		}

		// Token: 0x04002513 RID: 9491
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZHcm91cFJlZnJlc2hJbmZvLnByb3RvGhxTY2VuZUVudGl0eVJlZnJlc2hJ",
			"bmZvLnByb3RvGhtTY2VuZUdyb3VwUmVmcmVzaFR5cGUucHJvdG8ikgEKEEdy",
			"b3VwUmVmcmVzaEluZm8SLAoMcmVmcmVzaF90eXBlGAsgASgOMhYuU2NlbmVH",
			"cm91cFJlZnJlc2hUeXBlEg0KBXN0YXRlGAogASgNEhAKCGdyb3VwX2lkGAUg",
			"ASgNEi8KDnJlZnJlc2hfZW50aXR5GAYgAygLMhcuU2NlbmVFbnRpdHlSZWZy",
			"ZXNoSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			SceneEntityRefreshInfoReflection.Descriptor,
			SceneGroupRefreshTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GroupRefreshInfo), GroupRefreshInfo.Parser, new string[]
			{
				"RefreshType",
				"State",
				"GroupId",
				"RefreshEntity"
			}, null, null, null, null)
		}));
	}
}
