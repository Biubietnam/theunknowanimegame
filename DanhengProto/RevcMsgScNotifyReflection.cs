using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DDC RID: 3548
	public static class RevcMsgScNotifyReflection
	{
		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x06009E8F RID: 40591 RVA: 0x001A81C4 File Offset: 0x001A63C4
		public static FileDescriptor Descriptor
		{
			get
			{
				return RevcMsgScNotifyReflection.descriptor;
			}
		}

		// Token: 0x0400410B RID: 16651
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSZXZjTXNnU2NOb3RpZnkucHJvdG8aDU1zZ1R5cGUucHJvdG8aDkNoYXRU",
			"eXBlLnByb3RvGhFMRkNLUFBETElKSS5wcm90byLCAQoPUmV2Y01zZ1NjTm90",
			"aWZ5EhQKDG1lc3NhZ2VfdGV4dBgCIAEoCRIcCgljaGF0X3R5cGUYCyABKA4y",
			"CS5DaGF0VHlwZRISCgpzb3VyY2VfdWlkGAogASgNEhIKCnRhcmdldF91aWQY",
			"BSABKA0SHgoMbWVzc2FnZV90eXBlGAMgASgOMgguTXNnVHlwZRIQCghleHRy",
			"YV9pZBgEIAEoDRIhCgtCTkFCTkNDTUlMTRgBIAEoCzIMLkxGQ0tQUERMSUpJ",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MsgTypeReflection.Descriptor,
			ChatTypeReflection.Descriptor,
			LFCKPPDLIJIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RevcMsgScNotify), RevcMsgScNotify.Parser, new string[]
			{
				"MessageText",
				"ChatType",
				"SourceUid",
				"TargetUid",
				"MessageType",
				"ExtraId",
				"BNABNCCMILM"
			}, null, null, null, null)
		}));
	}
}
