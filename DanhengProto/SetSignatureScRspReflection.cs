using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001130 RID: 4400
	public static class SetSignatureScRspReflection
	{
		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600C440 RID: 50240 RVA: 0x0020ECCE File Offset: 0x0020CECE
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetSignatureScRspReflection.descriptor;
			}
		}

		// Token: 0x04004F50 RID: 20304
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTZXRTaWduYXR1cmVTY1JzcC5wcm90byI3ChFTZXRTaWduYXR1cmVTY1Jz" + "cBIRCglzaWduYXR1cmUYDyABKAkSDwoHcmV0Y29kZRgEIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetSignatureScRsp), SetSignatureScRsp.Parser, new string[]
			{
				"Signature",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
