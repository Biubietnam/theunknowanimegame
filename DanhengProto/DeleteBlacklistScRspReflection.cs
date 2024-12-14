using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200036E RID: 878
	public static class DeleteBlacklistScRspReflection
	{
		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x0006D53E File Offset: 0x0006B73E
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeleteBlacklistScRspReflection.descriptor;
			}
		}

		// Token: 0x04000FCB RID: 4043
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEZWxldGVCbGFja2xpc3RTY1JzcC5wcm90byI0ChREZWxldGVCbGFja2xp" + "c3RTY1JzcBIPCgdyZXRjb2RlGAQgASgNEgsKA3VpZBgPIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeleteBlacklistScRsp), DeleteBlacklistScRsp.Parser, new string[]
			{
				"Retcode",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
