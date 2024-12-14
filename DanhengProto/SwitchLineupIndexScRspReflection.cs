using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200121A RID: 4634
	public static class SwitchLineupIndexScRspReflection
	{
		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600CF29 RID: 53033 RVA: 0x0022B5EA File Offset: 0x002297EA
		public static FileDescriptor Descriptor
		{
			get
			{
				return SwitchLineupIndexScRspReflection.descriptor;
			}
		}

		// Token: 0x04005360 RID: 21344
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTd2l0Y2hMaW5ldXBJbmRleFNjUnNwLnByb3RvIjgKFlN3aXRjaExpbmV1" + "cEluZGV4U2NSc3ASDQoFaW5kZXgYAyABKA0SDwoHcmV0Y29kZRgGIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SwitchLineupIndexScRsp), SwitchLineupIndexScRsp.Parser, new string[]
			{
				"Index",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
