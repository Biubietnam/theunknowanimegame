using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000302 RID: 770
	public static class ClockParkUnlockTalentScRspReflection
	{
		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00061E7E File Offset: 0x0006007E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClockParkUnlockTalentScRspReflection.descriptor;
			}
		}

		// Token: 0x04000E33 RID: 3635
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDbG9ja1BhcmtVbmxvY2tUYWxlbnRTY1JzcC5wcm90byJAChpDbG9ja1Bh" + "cmtVbmxvY2tUYWxlbnRTY1JzcBIPCgdyZXRjb2RlGAogASgNEhEKCXRhbGVu" + "dF9pZBgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkUnlockTalentScRsp), ClockParkUnlockTalentScRsp.Parser, new string[]
			{
				"Retcode",
				"TalentId"
			}, null, null, null, null)
		}));
	}
}
