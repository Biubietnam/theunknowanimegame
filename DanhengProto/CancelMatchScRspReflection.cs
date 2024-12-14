using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200016A RID: 362
	public static class CancelMatchScRspReflection
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x0002EDE2 File Offset: 0x0002CFE2
		public static FileDescriptor Descriptor
		{
			get
			{
				return CancelMatchScRspReflection.descriptor;
			}
		}

		// Token: 0x040006D0 RID: 1744
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZDYW5jZWxNYXRjaFNjUnNwLnByb3RvIiMKEENhbmNlbE1hdGNoU2NSc3AS" + "DwoHcmV0Y29kZRgCIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CancelMatchScRsp), CancelMatchScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
