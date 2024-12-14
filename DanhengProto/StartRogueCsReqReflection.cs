using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C4 RID: 4548
	public static class StartRogueCsReqReflection
	{
		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600CB3B RID: 52027 RVA: 0x00221570 File Offset: 0x0021F770
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartRogueCsReqReflection.descriptor;
			}
		}

		// Token: 0x040051F6 RID: 20982
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVTdGFydFJvZ3VlQ3NSZXEucHJvdG8irwEKD1N0YXJ0Um9ndWVDc1JlcRIc",
			"ChR0cmlhbF9hdmF0YXJfaWRfbGlzdBgLIAMoDRIbChNiYXNlX2F2YXRhcl9p",
			"ZF9saXN0GA0gAygNEg8KB2FyZWFfaWQYCSABKA0SDwoHYWVvbl9pZBgPIAEo",
			"DRIhChlpbnRlcmFjdGVkX3Byb3BfZW50aXR5X2lkGAEgASgNEhwKFGRpc2Fi",
			"bGVfYWVvbl9pZF9saXN0GAggAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartRogueCsReq), StartRogueCsReq.Parser, new string[]
			{
				"TrialAvatarIdList",
				"BaseAvatarIdList",
				"AreaId",
				"AeonId",
				"InteractedPropEntityId",
				"DisableAeonIdList"
			}, null, null, null, null)
		}));
	}
}
