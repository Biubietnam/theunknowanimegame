using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001FB RID: 507
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueConfirmRollCsReq : IMessage<ChessRogueConfirmRollCsReq>, IMessage, IEquatable<ChessRogueConfirmRollCsReq>, IDeepCloneable<ChessRogueConfirmRollCsReq>, IBufferMessage
	{
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00040E4C File Offset: 0x0003F04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueConfirmRollCsReq> Parser
		{
			get
			{
				return ChessRogueConfirmRollCsReq._parser;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00040E53 File Offset: 0x0003F053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueConfirmRollCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00040E65 File Offset: 0x0003F065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueConfirmRollCsReq.Descriptor;
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00040E6C File Offset: 0x0003F06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueConfirmRollCsReq()
		{
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00040E74 File Offset: 0x0003F074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueConfirmRollCsReq(ChessRogueConfirmRollCsReq other) : this()
		{
			this.oKCOHJJEEAA_ = other.oKCOHJJEEAA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00040E99 File Offset: 0x0003F099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueConfirmRollCsReq Clone()
		{
			return new ChessRogueConfirmRollCsReq(this);
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00040EA1 File Offset: 0x0003F0A1
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00040EA9 File Offset: 0x0003F0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OKCOHJJEEAA
		{
			get
			{
				return this.oKCOHJJEEAA_;
			}
			set
			{
				this.oKCOHJJEEAA_ = value;
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00040EB2 File Offset: 0x0003F0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueConfirmRollCsReq);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00040EC0 File Offset: 0x0003F0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueConfirmRollCsReq other)
		{
			return other != null && (other == this || (this.OKCOHJJEEAA == other.OKCOHJJEEAA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OKCOHJJEEAA != 0U)
			{
				num ^= this.OKCOHJJEEAA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00040F2F File Offset: 0x0003F12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00040F37 File Offset: 0x0003F137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00040F40 File Offset: 0x0003F140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OKCOHJJEEAA != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00040F74 File Offset: 0x0003F174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OKCOHJJEEAA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OKCOHJJEEAA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00040FB2 File Offset: 0x0003F1B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueConfirmRollCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OKCOHJJEEAA != 0U)
			{
				this.OKCOHJJEEAA = other.OKCOHJJEEAA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00040FE3 File Offset: 0x0003F1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00040FEC File Offset: 0x0003F1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OKCOHJJEEAA = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400098F RID: 2447
		private static readonly MessageParser<ChessRogueConfirmRollCsReq> _parser = new MessageParser<ChessRogueConfirmRollCsReq>(() => new ChessRogueConfirmRollCsReq());

		// Token: 0x04000990 RID: 2448
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000991 RID: 2449
		public const int OKCOHJJEEAAFieldNumber = 4;

		// Token: 0x04000992 RID: 2450
		private uint oKCOHJJEEAA_;
	}
}
