using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A48 RID: 2632
	public static class LobbyModifyPlayerInfoCsReqReflection
	{
		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x060074D4 RID: 29908 RVA: 0x0013684E File Offset: 0x00134A4E
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyModifyPlayerInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002CEB RID: 11499
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBMb2JieU1vZGlmeVBsYXllckluZm9Dc1JlcS5wcm90bxoVTG9iYnlNb2Rp",
			"ZnlUeXBlLnByb3RvGhFQR0RBQ05JQkZNUC5wcm90byJ0ChpMb2JieU1vZGlm",
			"eVBsYXllckluZm9Dc1JlcRIeCgR0eXBlGA0gASgOMhAuTG9iYnlNb2RpZnlU",
			"eXBlEiEKC0RJRk5ERUdNS05BGAggASgLMgwuUEdEQUNOSUJGTVASEwoLSkFG",
			"Q0FESkdQSkgYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LobbyModifyTypeReflection.Descriptor,
			PGDACNIBFMPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyModifyPlayerInfoCsReq), LobbyModifyPlayerInfoCsReq.Parser, new string[]
			{
				"Type",
				"DIFNDEGMKNA",
				"JAFCADJGPJH"
			}, null, null, null, null)
		}));
	}
}
