using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000372 RID: 882
	public static class DeleteFriendScRspReflection
	{
		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002748 RID: 10056 RVA: 0x0006DBA9 File Offset: 0x0006BDA9
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeleteFriendScRspReflection.descriptor;
			}
		}

		// Token: 0x04000FD9 RID: 4057
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEZWxldGVGcmllbmRTY1JzcC5wcm90byIxChFEZWxldGVGcmllbmRTY1Jz" + "cBIPCgdyZXRjb2RlGA4gASgNEgsKA3VpZBgBIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeleteFriendScRsp), DeleteFriendScRsp.Parser, new string[]
			{
				"Retcode",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
