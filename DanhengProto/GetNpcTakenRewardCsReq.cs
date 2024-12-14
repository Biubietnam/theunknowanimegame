using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000751 RID: 1873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetNpcTakenRewardCsReq : IMessage<GetNpcTakenRewardCsReq>, IMessage, IEquatable<GetNpcTakenRewardCsReq>, IDeepCloneable<GetNpcTakenRewardCsReq>, IBufferMessage
	{
		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x000E170C File Offset: 0x000DF90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetNpcTakenRewardCsReq> Parser
		{
			get
			{
				return GetNpcTakenRewardCsReq._parser;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x000E1713 File Offset: 0x000DF913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetNpcTakenRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x060053BB RID: 21435 RVA: 0x000E1725 File Offset: 0x000DF925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetNpcTakenRewardCsReq.Descriptor;
			}
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x000E172C File Offset: 0x000DF92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcTakenRewardCsReq()
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x000E1734 File Offset: 0x000DF934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcTakenRewardCsReq(GetNpcTakenRewardCsReq other) : this()
		{
			this.npcId_ = other.npcId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x000E1759 File Offset: 0x000DF959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcTakenRewardCsReq Clone()
		{
			return new GetNpcTakenRewardCsReq(this);
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x060053BF RID: 21439 RVA: 0x000E1761 File Offset: 0x000DF961
		// (set) Token: 0x060053C0 RID: 21440 RVA: 0x000E1769 File Offset: 0x000DF969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x000E1772 File Offset: 0x000DF972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetNpcTakenRewardCsReq);
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x000E1780 File Offset: 0x000DF980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetNpcTakenRewardCsReq other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x000E17B0 File Offset: 0x000DF9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x000E17EF File Offset: 0x000DF9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x000E17F7 File Offset: 0x000DF9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x000E1800 File Offset: 0x000DFA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x000E1834 File Offset: 0x000DFA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x000E1872 File Offset: 0x000DFA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetNpcTakenRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x000E18A3 File Offset: 0x000DFAA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x000E18AC File Offset: 0x000DFAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NpcId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040020E9 RID: 8425
		private static readonly MessageParser<GetNpcTakenRewardCsReq> _parser = new MessageParser<GetNpcTakenRewardCsReq>(() => new GetNpcTakenRewardCsReq());

		// Token: 0x040020EA RID: 8426
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020EB RID: 8427
		public const int NpcIdFieldNumber = 6;

		// Token: 0x040020EC RID: 8428
		private uint npcId_;
	}
}
