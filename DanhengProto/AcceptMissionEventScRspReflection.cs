using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200001E RID: 30
	public static class AcceptMissionEventScRspReflection
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004685 File Offset: 0x00002885
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptMissionEventScRspReflection.descriptor;
			}
		}

		// Token: 0x0400005B RID: 91
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1BY2NlcHRNaXNzaW9uRXZlbnRTY1JzcC5wcm90bxoNTWlzc2lvbi5wcm90" + "byJJChdBY2NlcHRNaXNzaW9uRXZlbnRTY1JzcBIdCgtJQVBJT0ZQTERFSxgP" + "IAEoCzIILk1pc3Npb24SDwoHcmV0Y29kZRgGIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMissionEventScRsp), AcceptMissionEventScRsp.Parser, new string[]
			{
				"IAPIOFPLDEK",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
