using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000366 RID: 870
	public static class DeactivateFarmElementScRspReflection
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0006CC0E File Offset: 0x0006AE0E
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeactivateFarmElementScRspReflection.descriptor;
			}
		}

		// Token: 0x04000FB0 RID: 4016
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBEZWFjdGl2YXRlRmFybUVsZW1lbnRTY1JzcC5wcm90byJAChpEZWFjdGl2" + "YXRlRmFybUVsZW1lbnRTY1JzcBIRCgllbnRpdHlfaWQYASABKA0SDwoHcmV0" + "Y29kZRgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeactivateFarmElementScRsp), DeactivateFarmElementScRsp.Parser, new string[]
			{
				"EntityId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
