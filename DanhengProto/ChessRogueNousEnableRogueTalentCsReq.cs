using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000255 RID: 597
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousEnableRogueTalentCsReq : IMessage<ChessRogueNousEnableRogueTalentCsReq>, IMessage, IEquatable<ChessRogueNousEnableRogueTalentCsReq>, IDeepCloneable<ChessRogueNousEnableRogueTalentCsReq>, IBufferMessage
	{
		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x0004D71D File Offset: 0x0004B91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousEnableRogueTalentCsReq> Parser
		{
			get
			{
				return ChessRogueNousEnableRogueTalentCsReq._parser;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0004D724 File Offset: 0x0004B924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousEnableRogueTalentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0004D736 File Offset: 0x0004B936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousEnableRogueTalentCsReq.Descriptor;
			}
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0004D73D File Offset: 0x0004B93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEnableRogueTalentCsReq()
		{
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0004D745 File Offset: 0x0004B945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEnableRogueTalentCsReq(ChessRogueNousEnableRogueTalentCsReq other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0004D76A File Offset: 0x0004B96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousEnableRogueTalentCsReq Clone()
		{
			return new ChessRogueNousEnableRogueTalentCsReq(this);
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0004D772 File Offset: 0x0004B972
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0004D77A File Offset: 0x0004B97A
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

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0004D783 File Offset: 0x0004B983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousEnableRogueTalentCsReq);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004D791 File Offset: 0x0004B991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousEnableRogueTalentCsReq other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
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

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0004D7FF File Offset: 0x0004B9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0004D807 File Offset: 0x0004BA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0004D810 File Offset: 0x0004BA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0004D844 File Offset: 0x0004BA44
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

		// Token: 0x06001ACC RID: 6860 RVA: 0x0004D882 File Offset: 0x0004BA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousEnableRogueTalentCsReq other)
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

		// Token: 0x06001ACD RID: 6861 RVA: 0x0004D8B3 File Offset: 0x0004BAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0004D8BC File Offset: 0x0004BABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TalentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B54 RID: 2900
		private static readonly MessageParser<ChessRogueNousEnableRogueTalentCsReq> _parser = new MessageParser<ChessRogueNousEnableRogueTalentCsReq>(() => new ChessRogueNousEnableRogueTalentCsReq());

		// Token: 0x04000B55 RID: 2901
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B56 RID: 2902
		public const int TalentIdFieldNumber = 15;

		// Token: 0x04000B57 RID: 2903
		private uint talentId_;
	}
}
