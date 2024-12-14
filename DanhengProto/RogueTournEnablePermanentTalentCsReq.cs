using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F9D RID: 3997
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnablePermanentTalentCsReq : IMessage<RogueTournEnablePermanentTalentCsReq>, IMessage, IEquatable<RogueTournEnablePermanentTalentCsReq>, IDeepCloneable<RogueTournEnablePermanentTalentCsReq>, IBufferMessage
	{
		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600B219 RID: 45593 RVA: 0x001DEB29 File Offset: 0x001DCD29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnablePermanentTalentCsReq> Parser
		{
			get
			{
				return RogueTournEnablePermanentTalentCsReq._parser;
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x001DEB30 File Offset: 0x001DCD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnablePermanentTalentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600B21B RID: 45595 RVA: 0x001DEB42 File Offset: 0x001DCD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnablePermanentTalentCsReq.Descriptor;
			}
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x001DEB49 File Offset: 0x001DCD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnablePermanentTalentCsReq()
		{
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x001DEB51 File Offset: 0x001DCD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnablePermanentTalentCsReq(RogueTournEnablePermanentTalentCsReq other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x001DEB76 File Offset: 0x001DCD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnablePermanentTalentCsReq Clone()
		{
			return new RogueTournEnablePermanentTalentCsReq(this);
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600B21F RID: 45599 RVA: 0x001DEB7E File Offset: 0x001DCD7E
		// (set) Token: 0x0600B220 RID: 45600 RVA: 0x001DEB86 File Offset: 0x001DCD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x001DEB8F File Offset: 0x001DCD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnablePermanentTalentCsReq);
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x001DEB9D File Offset: 0x001DCD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnablePermanentTalentCsReq other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x001DEBCC File Offset: 0x001DCDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0U)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x001DEC0B File Offset: 0x001DCE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x001DEC13 File Offset: 0x001DCE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x001DEC1C File Offset: 0x001DCE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x001DEC50 File Offset: 0x001DCE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B228 RID: 45608 RVA: 0x001DEC8E File Offset: 0x001DCE8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnablePermanentTalentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0U)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x001DECBF File Offset: 0x001DCEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x001DECC8 File Offset: 0x001DCEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400486C RID: 18540
		private static readonly MessageParser<RogueTournEnablePermanentTalentCsReq> _parser = new MessageParser<RogueTournEnablePermanentTalentCsReq>(() => new RogueTournEnablePermanentTalentCsReq());

		// Token: 0x0400486D RID: 18541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400486E RID: 18542
		public const int TalentIdFieldNumber = 13;

		// Token: 0x0400486F RID: 18543
		private uint talentId_;
	}
}
