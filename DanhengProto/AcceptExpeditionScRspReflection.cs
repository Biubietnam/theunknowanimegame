using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000016 RID: 22
	public static class AcceptExpeditionScRspReflection
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003AE1 File Offset: 0x00001CE1
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptExpeditionScRspReflection.descriptor;
			}
		}

		// Token: 0x04000043 RID: 67
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtBY2NlcHRFeHBlZGl0aW9uU2NSc3AucHJvdG8aEUpMSEhDSUpQT1BELnBy" + "b3RvIlkKFUFjY2VwdEV4cGVkaXRpb25TY1JzcBIvChlGVU5DX1VOTE9DS19J" + "RF9FWFBFRElUSU9OGAIgASgLMgwuSkxISENJSlBPUEQSDwoHcmV0Y29kZRgM" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			JLHHCIJPOPDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptExpeditionScRsp), AcceptExpeditionScRsp.Parser, new string[]
			{
				"FUNCUNLOCKIDEXPEDITION",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
