using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A40 RID: 2624
	public static class LobbyJoinCsReqReflection
	{
		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06007479 RID: 29817 RVA: 0x00135AEF File Offset: 0x00133CEF
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyJoinCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002CCE RID: 11470
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2JieUpvaW5Dc1JlcS5wcm90bxoRUEdEQUNOSUJGTVAucHJvdG8iRAoO" + "TG9iYnlKb2luQ3NSZXESDwoHcm9vbV9pZBgMIAEoBBIhCgtESUZOREVHTUtO" + "QRgHIAEoCzIMLlBHREFDTklCRk1QQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PGDACNIBFMPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyJoinCsReq), LobbyJoinCsReq.Parser, new string[]
			{
				"RoomId",
				"DIFNDEGMKNA"
			}, null, null, null, null)
		}));
	}
}
