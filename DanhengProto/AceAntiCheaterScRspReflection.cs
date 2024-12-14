using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000026 RID: 38
	public static class AceAntiCheaterScRspReflection
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000536C File Offset: 0x0000356C
		public static FileDescriptor Descriptor
		{
			get
			{
				return AceAntiCheaterScRspReflection.descriptor;
			}
		}

		// Token: 0x04000077 RID: 119
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlBY2VBbnRpQ2hlYXRlclNjUnNwLnByb3RvIiYKE0FjZUFudGlDaGVhdGVy" + "U2NSc3ASDwoHcmV0Y29kZRgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AceAntiCheaterScRsp), AceAntiCheaterScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
