using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000510 RID: 1296
	public static class FeatureSwitchParamReflection
	{
		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x0009FE71 File Offset: 0x0009E071
		public static FileDescriptor Descriptor
		{
			get
			{
				return FeatureSwitchParamReflection.descriptor;
			}
		}

		// Token: 0x04001728 RID: 5928
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGZWF0dXJlU3dpdGNoUGFyYW0ucHJvdG8iKQoSRmVhdHVyZVN3aXRjaFBh" + "cmFtEhMKC3N3aXRjaF9saXN0GAEgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FeatureSwitchParam), FeatureSwitchParam.Parser, new string[]
			{
				"SwitchList"
			}, null, null, null, null)
		}));
	}
}
