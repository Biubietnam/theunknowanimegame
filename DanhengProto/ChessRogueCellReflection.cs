using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001EC RID: 492
	public static class ChessRogueCellReflection
	{
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0003F1C5 File Offset: 0x0003D3C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueCellReflection.descriptor;
			}
		}

		// Token: 0x04000943 RID: 2371
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRDaGVzc1JvZ3VlQ2VsbC5wcm90bxofQ2hlc3NSb2d1ZUNlbGxTcGVjaWFs",
			"VHlwZS5wcm90bxoVQ2VsbEFkdmFuY2VJbmZvLnByb3RvGh9DaGVzc1JvZ3Vl",
			"Qm9hcmRDZWxsU3RhdHVzLnByb3RvIrgCCg5DaGVzc1JvZ3VlQ2VsbBITCgtp",
			"c191bmxvY2tlZBgIIAEoCBIRCgltYXJrX3R5cGUYDSABKA0SMAoMc3BlY2lh",
			"bF90eXBlGAwgASgOMhouQ2hlc3NSb2d1ZUNlbGxTcGVjaWFsVHlwZRITCgtJ",
			"RkVIR0dLTUhDQRgEIAMoDRINCgVwb3NfeRgOIAEoDRINCgVwb3NfeBgPIAEo",
			"DRIkCgpzdGFnZV9pbmZvGAIgASgLMhAuQ2VsbEFkdmFuY2VJbmZvEhIKCmJs",
			"b2NrX3R5cGUYByABKA0SCgoCaWQYBiABKA0SDwoHcm9vbV9pZBgFIAEoDRIv",
			"CgtjZWxsX3N0YXR1cxgBIAEoDjIaLkNoZXNzUm9ndWVCb2FyZENlbGxTdGF0",
			"dXMSEQoJaXNfdW5sb2NrGAogASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueCellSpecialTypeReflection.Descriptor,
			CellAdvanceInfoReflection.Descriptor,
			ChessRogueBoardCellStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCell), ChessRogueCell.Parser, new string[]
			{
				"IsUnlocked",
				"MarkType",
				"SpecialType",
				"IFEHGGKMHCA",
				"PosY",
				"PosX",
				"StageInfo",
				"BlockType",
				"Id",
				"RoomId",
				"CellStatus",
				"IsUnlock"
			}, null, null, null, null)
		}));
	}
}
