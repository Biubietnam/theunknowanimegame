using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A99 RID: 2713
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchBoxingClubOpponentScRsp : IMessage<MatchBoxingClubOpponentScRsp>, IMessage, IEquatable<MatchBoxingClubOpponentScRsp>, IDeepCloneable<MatchBoxingClubOpponentScRsp>, IBufferMessage
	{
		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06007837 RID: 30775 RVA: 0x0013EB81 File Offset: 0x0013CD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchBoxingClubOpponentScRsp> Parser
		{
			get
			{
				return MatchBoxingClubOpponentScRsp._parser;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x0013EB88 File Offset: 0x0013CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchBoxingClubOpponentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x0013EB9A File Offset: 0x0013CD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchBoxingClubOpponentScRsp.Descriptor;
			}
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x0013EBA1 File Offset: 0x0013CDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchBoxingClubOpponentScRsp()
		{
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x0013EBAC File Offset: 0x0013CDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchBoxingClubOpponentScRsp(MatchBoxingClubOpponentScRsp other) : this()
		{
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x0013EBF8 File Offset: 0x0013CDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchBoxingClubOpponentScRsp Clone()
		{
			return new MatchBoxingClubOpponentScRsp(this);
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x0013EC00 File Offset: 0x0013CE00
		// (set) Token: 0x0600783E RID: 30782 RVA: 0x0013EC08 File Offset: 0x0013CE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH Challenge
		{
			get
			{
				return this.challenge_;
			}
			set
			{
				this.challenge_ = value;
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x0600783F RID: 30783 RVA: 0x0013EC11 File Offset: 0x0013CE11
		// (set) Token: 0x06007840 RID: 30784 RVA: 0x0013EC19 File Offset: 0x0013CE19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x0013EC22 File Offset: 0x0013CE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchBoxingClubOpponentScRsp);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x0013EC30 File Offset: 0x0013CE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchBoxingClubOpponentScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Challenge, other.Challenge) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x0013EC80 File Offset: 0x0013CE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.challenge_ != null)
			{
				num ^= this.Challenge.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x0013ECD5 File Offset: 0x0013CED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x0013ECDD File Offset: 0x0013CEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x0013ECE8 File Offset: 0x0013CEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.challenge_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x0013ED40 File Offset: 0x0013CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.challenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Challenge);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x0013ED98 File Offset: 0x0013CF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchBoxingClubOpponentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.challenge_ != null)
			{
				if (this.challenge_ == null)
				{
					this.Challenge = new LJLLHIJKKOH();
				}
				this.Challenge.MergeFrom(other.Challenge);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x0013EE00 File Offset: 0x0013D000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x0013EE0C File Offset: 0x0013D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.challenge_ == null)
						{
							this.Challenge = new LJLLHIJKKOH();
						}
						input.ReadMessage(this.Challenge);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E2C RID: 11820
		private static readonly MessageParser<MatchBoxingClubOpponentScRsp> _parser = new MessageParser<MatchBoxingClubOpponentScRsp>(() => new MatchBoxingClubOpponentScRsp());

		// Token: 0x04002E2D RID: 11821
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E2E RID: 11822
		public const int ChallengeFieldNumber = 14;

		// Token: 0x04002E2F RID: 11823
		private LJLLHIJKKOH challenge_;

		// Token: 0x04002E30 RID: 11824
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04002E31 RID: 11825
		private uint retcode_;
	}
}
