using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B29 RID: 2857
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyEventSelectFriendCsReq : IMessage<MonopolyEventSelectFriendCsReq>, IMessage, IEquatable<MonopolyEventSelectFriendCsReq>, IDeepCloneable<MonopolyEventSelectFriendCsReq>, IBufferMessage
	{
		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06007E71 RID: 32369 RVA: 0x0014E489 File Offset: 0x0014C689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyEventSelectFriendCsReq> Parser
		{
			get
			{
				return MonopolyEventSelectFriendCsReq._parser;
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x0014E490 File Offset: 0x0014C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyEventSelectFriendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06007E73 RID: 32371 RVA: 0x0014E4A2 File Offset: 0x0014C6A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyEventSelectFriendCsReq.Descriptor;
			}
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x0014E4A9 File Offset: 0x0014C6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventSelectFriendCsReq()
		{
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x0014E4B1 File Offset: 0x0014C6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventSelectFriendCsReq(MonopolyEventSelectFriendCsReq other) : this()
		{
			this.pBCHJBFMOJB_ = other.pBCHJBFMOJB_;
			this.pHOGEMPLHLN_ = other.pHOGEMPLHLN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0014E4E2 File Offset: 0x0014C6E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventSelectFriendCsReq Clone()
		{
			return new MonopolyEventSelectFriendCsReq(this);
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06007E77 RID: 32375 RVA: 0x0014E4EA File Offset: 0x0014C6EA
		// (set) Token: 0x06007E78 RID: 32376 RVA: 0x0014E4F2 File Offset: 0x0014C6F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PBCHJBFMOJB
		{
			get
			{
				return this.pBCHJBFMOJB_;
			}
			set
			{
				this.pBCHJBFMOJB_ = value;
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x06007E79 RID: 32377 RVA: 0x0014E4FB File Offset: 0x0014C6FB
		// (set) Token: 0x06007E7A RID: 32378 RVA: 0x0014E503 File Offset: 0x0014C703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHOGEMPLHLN
		{
			get
			{
				return this.pHOGEMPLHLN_;
			}
			set
			{
				this.pHOGEMPLHLN_ = value;
			}
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x0014E50C File Offset: 0x0014C70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyEventSelectFriendCsReq);
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x0014E51A File Offset: 0x0014C71A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyEventSelectFriendCsReq other)
		{
			return other != null && (other == this || (this.PBCHJBFMOJB == other.PBCHJBFMOJB && this.PHOGEMPLHLN == other.PHOGEMPLHLN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x0014E558 File Offset: 0x0014C758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PBCHJBFMOJB)
			{
				num ^= this.PBCHJBFMOJB.GetHashCode();
			}
			if (this.PHOGEMPLHLN != 0U)
			{
				num ^= this.PHOGEMPLHLN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0014E5B0 File Offset: 0x0014C7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0014E5B8 File Offset: 0x0014C7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x0014E5C4 File Offset: 0x0014C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHOGEMPLHLN != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.PHOGEMPLHLN);
			}
			if (this.PBCHJBFMOJB)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.PBCHJBFMOJB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x0014E620 File Offset: 0x0014C820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PBCHJBFMOJB)
			{
				num += 2;
			}
			if (this.PHOGEMPLHLN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHOGEMPLHLN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x0014E66C File Offset: 0x0014C86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyEventSelectFriendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PBCHJBFMOJB)
			{
				this.PBCHJBFMOJB = other.PBCHJBFMOJB;
			}
			if (other.PHOGEMPLHLN != 0U)
			{
				this.PHOGEMPLHLN = other.PHOGEMPLHLN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0014E6BC File Offset: 0x0014C8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0014E6C8 File Offset: 0x0014C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PBCHJBFMOJB = input.ReadBool();
					}
				}
				else
				{
					this.PHOGEMPLHLN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400307C RID: 12412
		private static readonly MessageParser<MonopolyEventSelectFriendCsReq> _parser = new MessageParser<MonopolyEventSelectFriendCsReq>(() => new MonopolyEventSelectFriendCsReq());

		// Token: 0x0400307D RID: 12413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400307E RID: 12414
		public const int PBCHJBFMOJBFieldNumber = 14;

		// Token: 0x0400307F RID: 12415
		private bool pBCHJBFMOJB_;

		// Token: 0x04003080 RID: 12416
		public const int PHOGEMPLHLNFieldNumber = 6;

		// Token: 0x04003081 RID: 12417
		private uint pHOGEMPLHLN_;
	}
}
