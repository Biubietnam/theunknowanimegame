using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B15 RID: 2837
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyClickCellCsReq : IMessage<MonopolyClickCellCsReq>, IMessage, IEquatable<MonopolyClickCellCsReq>, IDeepCloneable<MonopolyClickCellCsReq>, IBufferMessage
	{
		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0014C5E8 File Offset: 0x0014A7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyClickCellCsReq> Parser
		{
			get
			{
				return MonopolyClickCellCsReq._parser;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06007D96 RID: 32150 RVA: 0x0014C5EF File Offset: 0x0014A7EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyClickCellCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x0014C601 File Offset: 0x0014A801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyClickCellCsReq.Descriptor;
			}
		}

		// Token: 0x06007D98 RID: 32152 RVA: 0x0014C608 File Offset: 0x0014A808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickCellCsReq()
		{
		}

		// Token: 0x06007D99 RID: 32153 RVA: 0x0014C610 File Offset: 0x0014A810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickCellCsReq(MonopolyClickCellCsReq other) : this()
		{
			this.mapId_ = other.mapId_;
			this.cellId_ = other.cellId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x0014C641 File Offset: 0x0014A841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickCellCsReq Clone()
		{
			return new MonopolyClickCellCsReq(this);
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x0014C649 File Offset: 0x0014A849
		// (set) Token: 0x06007D9C RID: 32156 RVA: 0x0014C651 File Offset: 0x0014A851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0014C65A File Offset: 0x0014A85A
		// (set) Token: 0x06007D9E RID: 32158 RVA: 0x0014C662 File Offset: 0x0014A862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x06007D9F RID: 32159 RVA: 0x0014C66B File Offset: 0x0014A86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyClickCellCsReq);
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x0014C679 File Offset: 0x0014A879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyClickCellCsReq other)
		{
			return other != null && (other == this || (this.MapId == other.MapId && this.CellId == other.CellId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x0014C6B8 File Offset: 0x0014A8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x0014C710 File Offset: 0x0014A910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DA3 RID: 32163 RVA: 0x0014C718 File Offset: 0x0014A918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DA4 RID: 32164 RVA: 0x0014C724 File Offset: 0x0014A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MapId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.MapId);
			}
			if (this.CellId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.CellId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DA5 RID: 32165 RVA: 0x0014C780 File Offset: 0x0014A980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007DA6 RID: 32166 RVA: 0x0014C7D8 File Offset: 0x0014A9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyClickCellCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DA7 RID: 32167 RVA: 0x0014C828 File Offset: 0x0014AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DA8 RID: 32168 RVA: 0x0014C834 File Offset: 0x0014AA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CellId = input.ReadUInt32();
					}
				}
				else
				{
					this.MapId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400303C RID: 12348
		private static readonly MessageParser<MonopolyClickCellCsReq> _parser = new MessageParser<MonopolyClickCellCsReq>(() => new MonopolyClickCellCsReq());

		// Token: 0x0400303D RID: 12349
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400303E RID: 12350
		public const int MapIdFieldNumber = 13;

		// Token: 0x0400303F RID: 12351
		private uint mapId_;

		// Token: 0x04003040 RID: 12352
		public const int CellIdFieldNumber = 14;

		// Token: 0x04003041 RID: 12353
		private uint cellId_;
	}
}
