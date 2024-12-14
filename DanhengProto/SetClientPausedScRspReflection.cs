using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010DA RID: 4314
	public static class SetClientPausedScRspReflection
	{
		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600C065 RID: 49253 RVA: 0x00205B02 File Offset: 0x00203D02
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetClientPausedScRspReflection.descriptor;
			}
		}

		// Token: 0x04004E05 RID: 19973
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRDbGllbnRQYXVzZWRTY1JzcC5wcm90byI3ChRTZXRDbGllbnRQYXVz" + "ZWRTY1JzcBIPCgdyZXRjb2RlGAEgASgNEg4KBnBhdXNlZBgJIAEoCEIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetClientPausedScRsp), SetClientPausedScRsp.Parser, new string[]
			{
				"Retcode",
				"Paused"
			}, null, null, null, null)
		}));
	}
}
