using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D68 RID: 3432
	public static class RaidCollectionEnterNextRaidScRspReflection
	{
		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x06009961 RID: 39265 RVA: 0x00198407 File Offset: 0x00196607
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidCollectionEnterNextRaidScRspReflection.descriptor;
			}
		}

		// Token: 0x04003B8B RID: 15243
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZSYWlkQ29sbGVjdGlvbkVudGVyTmV4dFJhaWRTY1JzcC5wcm90bxoRT0lJ",
			"T0xDUEJMQ0YucHJvdG8iUAogUmFpZENvbGxlY3Rpb25FbnRlck5leHRSYWlk",
			"U2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIbCgVzY2VuZRgNIAEoCzIMLk9JSU9M",
			"Q1BCTENGQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			OIIOLCPBLCFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionEnterNextRaidScRsp), RaidCollectionEnterNextRaidScRsp.Parser, new string[]
			{
				"Retcode",
				"Scene"
			}, null, null, null, null)
		}));
	}
}
