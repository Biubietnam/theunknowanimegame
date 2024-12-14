using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F2 RID: 2546
	public static class LeaveChallengeScRspReflection
	{
		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x0600710D RID: 28941 RVA: 0x0012D22E File Offset: 0x0012B42E
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x04002B89 RID: 11145
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlMZWF2ZUNoYWxsZW5nZVNjUnNwLnByb3RvIiYKE0xlYXZlQ2hhbGxlbmdl" + "U2NSc3ASDwoHcmV0Y29kZRgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveChallengeScRsp), LeaveChallengeScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
